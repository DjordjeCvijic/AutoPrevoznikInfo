using AutoPrevoznikInfo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AutoPrevoznikInfo.DataAccess
{
    class BusDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AutoPrevoznikInfo"].ConnectionString;

        public List<Bus> GetBuses()
        {
            List<Bus> result = new List<Bus>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from bus";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               
                result.Add(new Bus()
                {
                   BusId= reader.GetInt32(0),
                    GarageNumber = reader.GetString(1),
                    BusType = reader.GetString(2),
                    NumberOfSeats = reader.GetInt32(3),
                   NumberOfDoors= reader.GetInt32(4),
                   Capacity= reader.GetInt32(5)

                });
            }
            reader.Close();
            conn.Close();
            return result;
        }

        public void AddBus(Bus busToAdd)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO bus (busID, garage_number, bus_type, number_of_seats, number_of_doors, capacity) " +
                "VALUES (@busID, @garage_number, @bus_type, @number_of_seats, @number_of_doors, @capacity)";
            cmd.Parameters.AddWithValue("@busID", 0);
            cmd.Parameters.AddWithValue("@garage_number", busToAdd.GarageNumber);
            cmd.Parameters.AddWithValue("@bus_type", busToAdd.BusType);
            cmd.Parameters.AddWithValue("@number_of_seats", busToAdd.NumberOfSeats);
            cmd.Parameters.AddWithValue("@number_of_doors", busToAdd.NumberOfDoors);
            cmd.Parameters.AddWithValue("@capacity", busToAdd.Capacity);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateBus(Bus busToUpdate)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE bus SET garage_number=@garage_number, bus_type=@bus_type, number_of_seats=@number_of_seats, number_of_doors=@number_of_doors, capacity=@capacity" +
                " WHERE busID=@busID";
            cmd.Parameters.AddWithValue("@busID", busToUpdate.BusId);
            cmd.Parameters.AddWithValue("@garage_number", busToUpdate.GarageNumber);
            cmd.Parameters.AddWithValue("@bus_type", busToUpdate.BusType);
            cmd.Parameters.AddWithValue("@number_of_seats", busToUpdate.NumberOfSeats);
            cmd.Parameters.AddWithValue("@number_of_doors", busToUpdate.NumberOfDoors);
            cmd.Parameters.AddWithValue("@capacity", busToUpdate.Capacity);
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteBus(Bus busToDelete)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            //brisanje iz bus_has_driver
            cmd.CommandText = "DELETE FROM bus_has_driver WHERE bus_busID=@busID";
            cmd.Parameters.AddWithValue("@busID", busToDelete.BusId);
            cmd.ExecuteReader();
            conn.Close();

            //brisanje iz bus_line_has_bus
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM bus_line_has_bus WHERE bus_busID=@busID1";
            cmd.Parameters.AddWithValue("@busID1", busToDelete.BusId);
            cmd.ExecuteReader();
            conn.Close();

            //brisanje is bus
            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM bus WHERE busID=@busID2";
            cmd.Parameters.AddWithValue("@busID2", busToDelete.BusId);
            cmd.ExecuteReader();
            conn.Close();

        }
        public int CountBuses()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM bus ";

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return count;
        }
        public int GetLastID()
        {
            int result=0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from bus ORDER BY busID ASC";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetInt32(0);
                
            }
            reader.Close();
            conn.Close();
            return result;
        }
        public Bus GetBusWithID(int id)
        {
            Bus result = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from bus WHERE busID=@busID";
            cmd.Parameters.AddWithValue("@busID", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                result = new Bus()
                {
                    BusId = reader.GetInt32(0),
                    GarageNumber = reader.GetString(1),
                    BusType = reader.GetString(2),
                    NumberOfSeats = reader.GetInt32(3),
                    NumberOfDoors = reader.GetInt32(4),
                    Capacity = reader.GetInt32(5)
                };
            }
            reader.Close();
            conn.Close();
            return result;
        }

    }
}
