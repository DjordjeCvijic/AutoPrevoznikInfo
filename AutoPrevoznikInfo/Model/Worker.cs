using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPrevoznikInfo.Model
{
    public class Worker
    {
        public int WorkerID { get; set; }
        public string WorkerCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkerType { get; set; }
    }
}
