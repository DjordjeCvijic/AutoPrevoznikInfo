using AutoPrevoznikInfo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AutoPrevoznikInfo.DataAccess
{
    class BusLineHasBusDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AutoPrevoznikInfo"].ConnectionString;
        private BusLineDataAccess busLineDA = new BusLineDataAccess();
        private BusDataAccess busDA = new BusDataAccess();
        private WorkerDataAccess workerDA = new WorkerDataAccess();
        ShiftScheduleDataAccess shiftScheduleDA = new ShiftScheduleDataAccess();
        public List<BusLineHasBus> GetBusLineHasBus()
        {
            List<BusLineHasBus> result = new List<BusLineHasBus>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from bus_line_has_bus";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                result.Add(new BusLineHasBus()
                {
                    BusLineHasBusID = reader.GetInt32(0),
                    BusLine = busLineDA.GetBusLineWithID(reader.GetInt32(1)),
                    Bus=busDA.GetBusWithID(reader.GetInt32(2)),
                    Driver=workerDA.GetWorkerWithID(reader.GetInt32(3)),
                    Date= reader.GetString(4),
                    StartTime=reader.GetString(5),
                    EndTime=reader.GetString(6)

                });
            }
            reader.Close();
            conn.Close();
            return result;
        }

        public void AddBusLineHasBus(BusLineHasBus elementToAdd)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            //dodavanje u bus_line_has_bus
            cmd.CommandText = "INSERT INTO bus_line_has_bus (bus_line_has_busID, bus_line_bus_lineID, bus_busID, driver_driverID, date, start_time, " +
                "end_time) " +
                "VALUES (@bus_line_has_busID, @bus_line_bus_lineID, @bus_busID, @driver_driverID, @date, @start_time, @end_time)";
            cmd.Parameters.AddWithValue("@bus_line_has_busID", 0);
            cmd.Parameters.AddWithValue("@bus_line_bus_lineID", elementToAdd.BusLine.BusLineID);
            cmd.Parameters.AddWithValue("@bus_busID",elementToAdd.Bus.BusId);
            cmd.Parameters.AddWithValue("@driver_driverID", elementToAdd.Driver.WorkerID);
            cmd.Parameters.AddWithValue("@date", elementToAdd.Date);
            cmd.Parameters.AddWithValue("@start_time", elementToAdd.StartTime);
            cmd.Parameters.AddWithValue("@end_time", elementToAdd.EndTime);
            
            cmd.ExecuteNonQuery();
            conn.Close();
            //dodavanje u tabelu shift_schedule
            ShiftSchedule shiftToAdd = new ShiftSchedule
            {
                Worker = elementToAdd.Driver,
                Date = elementToAdd.Date,
                StartTime = elementToAdd.StartTime,
                EndTime = elementToAdd.EndTime
            };
            
            shiftScheduleDA.AddShiftSchedule(shiftToAdd);
        }
        public void DeleteBusLineHasBus(BusLineHasBus elementToDelete)
        {
         
             MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM bus_line_has_bus WHERE bus_line_has_busID=@bus_line_has_busID";
            cmd.Parameters.AddWithValue("@bus_line_has_busID", elementToDelete.BusLineHasBusID);
            cmd.ExecuteReader();
            conn.Close();
        }

    }
}
