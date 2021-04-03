using AutoPrevoznikInfo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AutoPrevoznikInfo.DataAccess
{
    class BusLineDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AutoPrevoznikInfo"].ConnectionString;

        public List<BusLine> GetBusLine()
        {
            List<BusLine> result = new List<BusLine>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from bus_line";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                result.Add(new BusLine()
                {
                    
                });
            }
            reader.Close();
            conn.Close();
            return result;
        }
    }
}
