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
                    WorkerCode = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Username = reader.GetString(4),
                    Password = reader.GetString(5),
                    PhoneNumber = reader.GetString(6),
                    WorkerType = reader.GetString(7),
                    Theme=reader.GetString(8)
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
                    WorkerType = reader.GetString(7),
                    Theme = reader.GetString(8)
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
                if (reader.GetString(7).Equals("V"))
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
                        Theme = reader.GetString(8),
                        Buses = new List<Bus>()
                        
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
        public List<Worker> GetDoorkeeper()
        {
            List<Worker> result = new List<Worker>();
            List<int> listOfDoorkeeper = new List<int>();

            
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from doorkeeper";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listOfDoorkeeper.Add(reader.GetInt32(0));

            }
            reader.Close();
            conn.Close();

            foreach (int i in listOfDoorkeeper)
                result.Add(GetWorkerWithID(i));
            return result;

        }
      

        public void AddDriver(Driver driver)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            //dodavanje u tabelu worker
            cmd.CommandText = "INSERT INTO worker (workerID, worker_code, first_name, last_name, username, password, phone_number, " +
                "worker_type, theme) " +
                "VALUES (@workerID, @worker_code, @first_name, @last_name, @user_name, @password, @phone_number, @worker_type, @theme)";
            cmd.Parameters.AddWithValue("@workerID",0);
            cmd.Parameters.AddWithValue("@worker_code", driver.WorkerCode);
            cmd.Parameters.AddWithValue("@first_name", driver.FirstName);
            cmd.Parameters.AddWithValue("@last_name", driver.LastName);
            cmd.Parameters.AddWithValue("@user_name", driver.Username);
            cmd.Parameters.AddWithValue("@password", driver.Password);
            cmd.Parameters.AddWithValue("@phone_number", driver.PhoneNumber);
            cmd.Parameters.AddWithValue("@worker_type", driver.WorkerType);
            cmd.Parameters.AddWithValue("@theme", "W");
            cmd.ExecuteNonQuery();
            long driverId = cmd.LastInsertedId;
            conn.Close();
            //dodavanje u tabelu driver
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO driver(driverID) VALUES(@driverID)";
            cmd.Parameters.AddWithValue("@driverID", driverId);
            cmd.ExecuteNonQuery();
            conn.Close();
            //dodavanje u tabelu bus_has_driver
            conn = new MySqlConnection(connectionString);
            conn.Open();
            foreach (Bus b in driver.Buses)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO bus_has_driver(bus_busID,driver_driverID) VALUES(@bus_busID,@driver_driverID)";
                cmd.Parameters.AddWithValue("@driver_driverID", driverId);
                cmd.Parameters.AddWithValue("@bus_busID", b.BusId);
                cmd.ExecuteNonQuery();
            }
            
            conn.Close();

        }

        public void AddDoorkeeper(Worker doorkeeper)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            //dodavanje u tabelu worker
            cmd.CommandText = "INSERT INTO worker (workerID, worker_code, first_name, last_name, username, password, phone_number, " +
                "worker_type, theme) " +
                "VALUES (@workerID, @worker_code, @first_name, @last_name, @user_name, @password, @phone_number, @worker_type, @theme)";
            cmd.Parameters.AddWithValue("@workerID", 0);
            cmd.Parameters.AddWithValue("@worker_code", doorkeeper.WorkerCode);
            cmd.Parameters.AddWithValue("@first_name", doorkeeper.FirstName);
            cmd.Parameters.AddWithValue("@last_name", doorkeeper.LastName);
            cmd.Parameters.AddWithValue("@user_name", doorkeeper.Username);
            cmd.Parameters.AddWithValue("@password", doorkeeper.Password);
            cmd.Parameters.AddWithValue("@phone_number", doorkeeper.PhoneNumber);
            cmd.Parameters.AddWithValue("@worker_type", doorkeeper.WorkerType);
            cmd.Parameters.AddWithValue("@theme", "W");
            cmd.ExecuteNonQuery();
            long doorkeeperID = cmd.LastInsertedId;
            conn.Close();

            //dodavanje u tabelu doorkeeper
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO doorkeeper(doorkeeperID) VALUES(@doorkeeperID)";
            cmd.Parameters.AddWithValue("@doorkeeperID", doorkeeperID);
            cmd.ExecuteNonQuery();
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
        public int GetLastID()
        {
            int result = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from worker ORDER BY workerID ASC";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetInt32(0);

            }
            reader.Close();
            conn.Close();
            return result;
        }
        public void UpdateDriver(Driver driverToUpdate)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE worker SET worker_code=@worker_code, first_name=@first_name, last_name=@last_name, username=@username, password=@password," +
                " phone_number=@phone_number, worker_type=@worker_type, theme=@theme WHERE worker.workerID=@workerID";
            cmd.Parameters.AddWithValue("@workerID", driverToUpdate.WorkerID);
            cmd.Parameters.AddWithValue("@worker_code", driverToUpdate.WorkerCode);
            cmd.Parameters.AddWithValue("@first_name", driverToUpdate.FirstName);
            cmd.Parameters.AddWithValue("@last_name", driverToUpdate.LastName);
            cmd.Parameters.AddWithValue("@username", driverToUpdate.Username);
            cmd.Parameters.AddWithValue("@password", driverToUpdate.Password);
            cmd.Parameters.AddWithValue("@phone_number", driverToUpdate.PhoneNumber);
            cmd.Parameters.AddWithValue("@worker_type", driverToUpdate.WorkerType);
            cmd.Parameters.AddWithValue("@theme", driverToUpdate.Theme);
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
        public void UpdateWorker(Worker doorkeeperToUpdate)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE worker SET worker_code=@worker_code, first_name=@first_name, last_name=@last_name, username=@username, password=@password," +
                " phone_number=@phone_number, worker_type=@worker_type, theme=@theme WHERE worker.workerID=@workerID";
            cmd.Parameters.AddWithValue("@workerID", doorkeeperToUpdate.WorkerID);
            cmd.Parameters.AddWithValue("@worker_code", doorkeeperToUpdate.WorkerCode);
            cmd.Parameters.AddWithValue("@first_name", doorkeeperToUpdate.FirstName);
            cmd.Parameters.AddWithValue("@last_name", doorkeeperToUpdate.LastName);
            cmd.Parameters.AddWithValue("@username", doorkeeperToUpdate.Username);
            cmd.Parameters.AddWithValue("@password", doorkeeperToUpdate.Password);
            cmd.Parameters.AddWithValue("@phone_number", doorkeeperToUpdate.PhoneNumber);
            cmd.Parameters.AddWithValue("@worker_type", doorkeeperToUpdate.WorkerType);
            cmd.Parameters.AddWithValue("@theme", doorkeeperToUpdate.Theme);
            cmd.ExecuteNonQuery();
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


            //brisanje iz bus_line_has_bus
            
            cmd.CommandText = "DELETE FROM bus_line_has_bus WHERE driver_driverID=@driverID2";
            cmd.Parameters.AddWithValue("@driverID2", driverToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();

            //brisanje iz shift_schedule
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM shift_schedule WHERE worker_workerID=@driverID3";
            cmd.Parameters.AddWithValue("@driverID3", driverToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();
            //brisanje iz worker_record
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM worker_record WHERE workerID=@driverID4";
            cmd.Parameters.AddWithValue("@driverID4", driverToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();
            //brisanje iz bus_has_driver
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM bus_has_driver WHERE driver_driverID=@driverID";
            cmd.Parameters.AddWithValue("@driverID", driverToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();
            //brisanje iz message
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM message WHERE to_workerID=@driverID5";
            cmd.Parameters.AddWithValue("@driverID5", driverToDelete.WorkerID);
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
        public void DeleteDoorkeeper(Worker doorkeeperToDelete)
        {
            //brisanje iz doorkeeper
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM doorkeeper WHERE doorkeeperID=@doorkeeperID";
            cmd.Parameters.AddWithValue("@doorkeeperID", doorkeeperToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();

            //brisanje iz shift_schedule
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM shift_schedule WHERE worker_workerID=@workerID1";
            cmd.Parameters.AddWithValue("@workerID1", doorkeeperToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();
            //brisanje iz message
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM message WHERE to_workerID=@workerID2";
            cmd.Parameters.AddWithValue("@workerID2", doorkeeperToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();
            //brisanje iz worker_record
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM worker_record WHERE workerID=@workerID3";
            cmd.Parameters.AddWithValue("@workerID3", doorkeeperToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();

            //brisanje is worker
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM worker WHERE workerID=@workerID";
            cmd.Parameters.AddWithValue("@workerID", doorkeeperToDelete.WorkerID);
            cmd.ExecuteReader();
            conn.Close();


        }
    }
}
