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
    }
}
