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
        }
}
