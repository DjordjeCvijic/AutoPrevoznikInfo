using AutoPrevoznikInfo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AutoPrevoznikInfo.DataAccess
{
    class ShiftScheduleDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AutoPrevoznikInfo"].ConnectionString;
        private WorkerDataAccess workerDA = new WorkerDataAccess();
        public List<ShiftSchedule> GetAllShiftSchedule()
        {
            List<ShiftSchedule> result = new List<ShiftSchedule>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from shift_schedule";
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {

                result.Add(new ShiftSchedule()
                {
                    ShiftScheduleID = reader.GetInt32(0),
                    Worker = workerDA.GetWorkerWithID(reader.GetInt32(1)),
                    Date = reader.GetString(2),
                    StartTime = reader.GetString(3),
                    EndTime = reader.GetString(4),
                    
                });
            }
            reader.Close();
            conn.Close();
            return result;
        }
        public List<ShiftSchedule> GetDoorkeeperShiftSchedule()
        {

            List<Worker> doorkeepers = workerDA.GetDoorkeeper();
            List<int> doorkeepersIDs = new List<int>();
            foreach (Worker w in doorkeepers)
                doorkeepersIDs.Add(w.WorkerID);

            List<ShiftSchedule> result = new List<ShiftSchedule>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from shift_schedule";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (doorkeepersIDs.Contains(reader.GetInt32(1)))
                {
                    result.Add(new ShiftSchedule()
                    {
                        ShiftScheduleID = reader.GetInt32(0),
                        Worker = workerDA.GetWorkerWithID(reader.GetInt32(1)),
                        Date = reader.GetString(2),
                        StartTime = reader.GetString(3),
                        EndTime = reader.GetString(4),

                    });
                }
                
            }
            reader.Close();
            conn.Close();
            return result;
        }

        public void AddShiftSchedule(ShiftSchedule shift)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO shift_schedule (shift_scheduleID, worker_workerID, date, start_time,end_time) " +
               "VALUES (@shift_scheduleID, @worker_workerID, @date, @start_time, @end_time)";
            cmd.Parameters.AddWithValue("@shift_scheduleID", 0);
            cmd.Parameters.AddWithValue("@worker_workerID", shift.Worker.WorkerID);
            cmd.Parameters.AddWithValue("@date", shift.Date);
            cmd.Parameters.AddWithValue("@start_time", shift.StartTime);
            cmd.Parameters.AddWithValue("@end_time", shift.EndTime);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<ShiftSchedule> GetShiftScheduleByWorkerID(int id)
        {
            List<ShiftSchedule> result = new List<ShiftSchedule>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from shift_schedule WHERE worker_workerID=@workerID";
            cmd.Parameters.AddWithValue("@workerID", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            WorkerDataAccess workerDA = new WorkerDataAccess();
            while (reader.Read())
            {

                result.Add(  new ShiftSchedule()
                {
                    ShiftScheduleID = reader.GetInt32(0),
                    Worker = workerDA.GetWorkerWithID(reader.GetInt32(1)),
                    Date = reader.GetString(2),
                    StartTime = reader.GetString(3),
                    EndTime = reader.GetString(4),
                   
                });
            }
            reader.Close();
            conn.Close();
            return result;
        }
        public void DeleteShiftSchedule(ShiftSchedule shiftToDelete)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM shift_schedule WHERE shift_scheduleID=@shiftID";
            cmd.Parameters.AddWithValue("@shiftID", shiftToDelete.ShiftScheduleID);
            cmd.ExecuteReader();
            conn.Close();

            
        }

      
    }
}
