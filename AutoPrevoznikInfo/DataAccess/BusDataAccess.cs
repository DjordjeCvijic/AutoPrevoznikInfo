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
                   NumberOfSeats= reader.GetInt32(1),
                   NumberOfDoors= reader.GetInt32(2),
                   GarageNumber=reader.GetString(3),
                   BusType= reader.GetString(4)
                });
            }
            reader.Close();
            conn.Close();
            return result;
        }
        }
}
