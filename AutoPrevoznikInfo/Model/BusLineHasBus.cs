using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPrevoznikInfo.Model
{
    class BusLineHasBus
    {
        public int BusLineHasBusID{get;set;}
        public BusLine BusLine { get; set; }
        public Bus Bus { get; set; }
        public Worker Driver { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
