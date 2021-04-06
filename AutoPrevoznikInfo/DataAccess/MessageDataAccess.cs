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
        public void AddMessage(Message message)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO message (messageID, from_workerID, to_workerID, date, message_content) " +
               "VALUES (@messageID, @from_workerID, @to_workerID, @date, @message_contentne)";
            cmd.Parameters.AddWithValue("@messageID", 0);
            cmd.Parameters.AddWithValue("@from_workerID", message.FromWorker.WorkerID);
            cmd.Parameters.AddWithValue("@to_workerID", message.ToWorker.WorkerID);
            cmd.Parameters.AddWithValue("@date", message.Date);
            cmd.Parameters.AddWithValue("@message_contentne", message.MessageContent);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Message> GetWorkerMessages(Worker worker)
        {
            WorkerDataAccess workerDA = new WorkerDataAccess();
            List<Message> result = new List<Message>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from message WHERE message.to_workerID=@workerID";
            cmd.Parameters.AddWithValue("@workerID", worker.WorkerID);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Message()
                {
                    MessageID = reader.GetInt32(0),
                    FromWorker = workerDA.GetWorkerWithID(reader.GetInt32(1)),
                    ToWorker = worker,
                    Date=reader.GetString(3),
                    MessageContent= reader.GetString(4)

                }) ;
            }
            reader.Close();
            conn.Close();
            return result;
        }
    }
   
}
