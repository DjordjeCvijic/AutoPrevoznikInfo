using AutoPrevoznikInfo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AutoPrevoznikInfo.DataAccess
{
    class WorkerDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AutoPrevoznikInfo"].ConnectionString;

        public List<Worker> GetWorkers()
        {
            List<Worker> result = new List<Worker>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from worker";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                result.Add(new Worker()
                {
                    WorkerID = reader.GetInt32(0),
                    WorkerCode= reader.GetString(1),
                    FirstName= reader.GetString(2),
                    LastName= reader.GetString(3),
                    Username= reader.GetString(4),
                    Password= reader.GetString(5),
                    PhoneNumber= reader.GetString(6),
                    WorkerType= reader.GetString(7)
                });
            }
            reader.Close();
            conn.Close();
            return result;
        }
        public Worker GetWorkerWithID(int id)
        {
            Worker result=null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from worker WHERE workerID=@workerID";
            cmd.Parameters.AddWithValue("@workerID", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                result=new Worker()
                {
                    WorkerID = reader.GetInt32(0),
                    WorkerCode = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Username = reader.GetString(4),
                    Password = reader.GetString(5),
                    PhoneNumber = reader.GetString(6),
                    WorkerType = reader.GetString(7)
                };
            }
            reader.Close();
            conn.Close();
            return result;

        }
        public List<Driver> GetDrivers()
        {
            List<Driver> result = new List<Driver>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from worker";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(7).Equals("V"))//ovo je lose odradjeno
                {
                    result.Add(new Driver()
                    {
                        WorkerID = reader.GetInt32(0),
                        WorkerCode = reader.GetString(1),
                        FirstName = reader.GetString(2),
                        LastName = reader.GetString(3),
                        Username = reader.GetString(4),
                        Password = reader.GetString(5),
                        PhoneNumber = reader.GetString(6),
                        WorkerType = reader.GetString(7),
                        Buses = new List<Bus>()
                        //treba jos dodati listu buseva koje on vozi
                    }) ;
                }
                
            }
            reader.Close();
            conn.Close();

            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from driver INNER JOIN " +
                "bus_has_driver ON driver.driverID = bus_has_driver.driver_driverID " +
                "INNER JOIN bus ON bus_has_driver.bus_busID = bus.busID";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int driverId = reader.GetInt32(0);
                Driver driverToAddBus = null;
                foreach(Driver d in result)
                {
                    if (d.WorkerID == driverId)
                    {
                        driverToAddBus = d;
                    }
                }
                driverToAddBus.Buses.Add(new Bus()
                {
                    BusId = reader.GetInt32(3),
                    GarageNumber=reader.GetString(4),
                    BusType=reader.GetString(5),
                    NumberOfSeats=reader.GetInt32(6),
                    NumberOfDoors=reader.GetInt32(7),
                    Capacity= reader.GetInt32(8)
                });
            }
            reader.Close();
            return result;
        }

        public void AddDriver(Driver driver)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            //dodavanje u tabelu worker
            cmd.CommandText = "INSERT INTO worker (workerID, worker_code, first_name, last_name, username, password, phone_number, " +
                "worker_type) " +
                "VALUES (@workerID, @worker_code, @first_name, @last_name, @user_name, @password, @phone_number, @worker_type)";
            cmd.Parameters.AddWithValue("@workerID", driver.WorkerID);
            cmd.Parameters.AddWithValue("@worker_code", driver.WorkerCode);
            cmd.Parameters.AddWithValue("@first_name", driver.FirstName);
            cmd.Parameters.AddWithValue("@last_name", driver.LastName);
            cmd.Parameters.AddWithValue("@user_name", driver.Username);
            cmd.Parameters.AddWithValue("@password", driver.Password);
            cmd.Parameters.AddWithValue("@phone_number", driver.PhoneNumber);
            cmd.Parameters.AddWithValue("@worker_type", driver.WorkerType);
            cmd.ExecuteNonQuery();
            conn.Close();
            //dodavanje u tabelu driver
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO driver(driverID) VALUES(@driverID)";
            cmd.Parameters.AddWithValue("@driverID", driver.WorkerID);
            cmd.ExecuteNonQuery();
            conn.Close();
            //dodavanje u tabelu bus_has_driver
            conn = new MySqlConnection(connectionString);
            conn.Open();
            foreach (Bus b in driver.Buses)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO bus_has_driver(bus_busID,driver_driverID) VALUES(@bus_busID,@driver_driverID)";
                cmd.Parameters.AddWithValue("@driver_driverID", driver.WorkerID);
                cmd.Parameters.AddWithValue("@bus_busID", b.BusId);
                cmd.ExecuteNonQuery();
            }
            
            conn.Close();

        }
        public int CountWorkers()
        {
  
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM worker ";
            
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return count;
        }
        public void updateDriver(Driver driverToUpdate)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE worker SET worker_code=@worker_code, first_name=@first_name, last_name=@last_name, username=@username, password=@password," +
                " phone_number=@phone_number, worker_type=@worker_type WHERE worker.workerID=@workerID";
            cmd.Parameters.AddWithValue("@workerID", driverToUpdate.WorkerID);
            cmd.Parameters.AddWithValue("@worker_code", driverToUpdate.WorkerCode);
            cmd.Parameters.AddWithValue("@first_name", driverToUpdate.FirstName);
            cmd.Parameters.AddWithValue("@last_name", driverToUpdate.LastName);
            cmd.Parameters.AddWithValue("@username", driverToUpdate.Username);
            cmd.Parameters.AddWithValue("@password", driverToUpdate.Password);
            cmd.Parameters.AddWithValue("@phone_number", driverToUpdate.PhoneNumber);
            cmd.Parameters.AddWithValue("@worker_type", driverToUpdate.WorkerType);
            cmd.ExecuteNonQuery();
            conn.Close();

            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM bus_has_driver WHERE driver_driverID=@driverID";
            cmd.Parameters.AddWithValue("@driverID",driverToUpdate.WorkerID);
            cmd.ExecuteReader();
            conn.Close();

            //dodavanje u tabelu bus_has_driver
            conn = new MySqlConnection(connectionString);
            conn.Open();
            foreach (Bus b in driverToUpdate.Buses)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO bus_has_driver(bus_busID,driver_driverID) VALUES(@bus_busID,@driver_driverID)";
                cmd.Parameters.AddWithValue("@driver_driverID", driverToUpdate.WorkerID);
                cmd.Parameters.AddWithValue("@bus_busID", b.BusId);
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        public bool CheckIfUsernameUnique(string username)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM worker WHERE username=@username";
            cmd.Parameters.AddWithValue("@username", username);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            if (count == 0)
            {
                return true;
            }
            else return false;
        }

        public void DeleteDriver(Driver driverToDelete)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            //brisanje iz bus_has_driver
            cmd.CommandText = "DELETE FROM bus_has_driver WHERE driver_driverID=@driverID";
            cmd.Parameters.AddWithValue("@driverID", driverToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();

            //brisanje iz driver
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM driver WHERE driverID=@driverID1";
            cmd.Parameters.AddWithValue("@driverID1", driverToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();

            //brisanje is worker
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM worker WHERE workerID=@workerID";
            cmd.Parameters.AddWithValue("@workerID", driverToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();

        }
    }
}
