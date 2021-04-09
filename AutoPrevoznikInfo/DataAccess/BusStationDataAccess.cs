using AutoPrevoznikInfo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AutoPrevoznikInfo.DataAccess
{
    class BusStationDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AutoPrevoznikInfo"].ConnectionString;

        public List<BusStation> GetBusStations()
        {
            List<BusStation> result = new List<BusStation>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from bus_station";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                result.Add(new BusStation()
                {
                    BusStationID=reader.GetInt32(0),
                    BusStationCode=reader.GetString(1),
                    Name=reader.GetString(2)
                });
            }
            reader.Close();
            conn.Close();
            return result;
        }
        public BusStation GetBusStationWithID(int id)
        {
            BusStation result = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from bus_station WHERE bus_stationID=@bus_stationID";
            cmd.Parameters.AddWithValue("@bus_stationID", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                result = new BusStation()
                {
                    BusStationID = reader.GetInt32(0),
                    BusStationCode = reader.GetString(1),
                    Name = reader.GetString(2),
             
                };
            }
            reader.Close();
            conn.Close();
            return result;
        }
    }
}
