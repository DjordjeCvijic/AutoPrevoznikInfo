using AutoPrevoznikInfo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AutoPrevoznikInfo.DataAccess
{
    class WorkerRecordAccesData
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AutoPrevoznikInfo"].ConnectionString;

        public List<WorkerRecord> GetWorkerRecords()
        {
            List<WorkerRecord> result = new List<WorkerRecord>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from worker_record";
            MySqlDataReader reader = cmd.ExecuteReader();
            WorkerDataAccess workerDA = new WorkerDataAccess();
            while (reader.Read())
            {
                string date = reader.GetString(2).Split(" ")[0];
                result.Add(new WorkerRecord()
                {
                    WorkerRecordID = reader.GetInt32(0),
                    Worker = workerDA.GetWorkerWithID(reader.GetInt32(1)),
                    Date = date,
                    EnterTime = reader.GetString(3),
                    ExitTime = reader.GetString(4),
                    Note = reader.GetString(5)
                }) ;
            }
            reader.Close();
            conn.Close();
            return result;
        }
        public void AddEntry(WorkerRecord record)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO worker_record (worker_recordID, workerID, date, enter_time, exit_time,note) " +
               "VALUES (@worker_recordID, @workerID, @date, @enter_time, @exit_time,@note)";
            cmd.Parameters.AddWithValue("@worker_recordID", 0);
            cmd.Parameters.AddWithValue("@workerID", record.Worker.WorkerID);
            cmd.Parameters.AddWithValue("@date",record.Date);
            cmd.Parameters.AddWithValue("@enter_time", record.EnterTime);
            cmd.Parameters.AddWithValue("@exit_time", "");
            cmd.Parameters.AddWithValue("@note", record.Note);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AddExitTime(WorkerRecord record)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE worker_record SET workerID=@workerID, date=@date, enter_time=@enter_time, exit_time=@exit_time, note=@note "+
                "WHERE worker_recordID=@worker_recordID"; 

            cmd.Parameters.AddWithValue("@worker_recordID", record.WorkerRecordID);
            cmd.Parameters.AddWithValue("@workerID", record.Worker.WorkerID);
            cmd.Parameters.AddWithValue("@date", record.Date);
            cmd.Parameters.AddWithValue("@enter_time", record.EnterTime);
            cmd.Parameters.AddWithValue("@exit_time", record.ExitTime);
            cmd.Parameters.AddWithValue("@note", record.Note);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public WorkerRecord GetWorkerRecordByID(int id)
        {
            WorkerRecord result = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from worker_record WHERE worker_recordID=@worker_recordID";
            cmd.Parameters.AddWithValue("@worker_recordID", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            WorkerDataAccess workerDA = new WorkerDataAccess();
            while (reader.Read())
            {
                string date = reader.GetString(2).Split(" ")[0];
                result = new WorkerRecord()
                {
                    WorkerRecordID = reader.GetInt32(0),
                    Worker = workerDA.GetWorkerWithID(reader.GetInt32(1)),
                    Date = date,
                    EnterTime = reader.GetString(3),
                    ExitTime = reader.GetString(4),
                    Note = reader.GetString(5)
                };
            }
            reader.Close();
            conn.Close();
            return result;
        }


    }
}
