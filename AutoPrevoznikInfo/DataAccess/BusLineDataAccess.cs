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
            BusStationDataAccess busStationDA = new BusStationDataAccess();
            while (reader.Read())
            {

                result.Add(new BusLine()
                {
                    BusLineID = reader.GetInt32(0),
                    StartBusStation = busStationDA.GetBusStationWithID(reader.GetInt32(1)),
                    EndBusStation = busStationDA.GetBusStationWithID(reader.GetInt32(2)),
                    BusLineCode = reader.GetString(3),
                    Name = reader.GetString(4)

                }) ;
            }
            reader.Close();
            conn.Close();
            return result;
        }

        public BusLine GetBusLineWithID(int id)
        {
            BusLine result = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from bus_line WHERE bus_lineID=@bus_lineID";
            cmd.Parameters.AddWithValue("@bus_lineID", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            BusStationDataAccess busStationDA = new BusStationDataAccess();//ovo treba izmijeniti jer ne treba while petlja
            while (reader.Read())
            {

                result = new BusLine()
                {
                    BusLineID = reader.GetInt32(0),
                    StartBusStation= busStationDA.GetBusStationWithID(reader.GetInt32(1)),
                    EndBusStation = busStationDA.GetBusStationWithID(reader.GetInt32(2)),
                    BusLineCode=reader.GetString(3),
                    Name=reader.GetString(4)
                };
            }
            reader.Close();
            conn.Close();
            return result;
        }
    }
}
