using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPrevoznikInfo.Model
{
    class WorkerRecord
    {
        public int WorkerRecordID { get; set; }
        public Worker Worker { get; set; }
        public string Date { get; set; }
        public string EnterTime { get; set; }
        public string ExitTime { get; set; }
        public string Note { get; set; }

    }
}
