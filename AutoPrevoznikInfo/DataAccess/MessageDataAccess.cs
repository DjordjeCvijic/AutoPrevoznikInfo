using AutoPrevoznikInfo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AutoPrevoznikInfo.DataAccess
{
    class MessageDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AutoPrevoznikInfo"].ConnectionString;

        public List<Message> GetMessages()
        {
            List<Message> result = new List<Message>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from message";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                result.Add(new Message()
                {
                    
                });
            }
            reader.Close();
            conn.Close();
            return result;
        }
    }
}
