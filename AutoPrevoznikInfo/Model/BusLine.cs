using AutoPrevoznikInfo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPrevoznikInfo.Model
{
    class BusLine
    {
        public int BusLineID{get;set;}
        public BusStation StartBusStation { get; set; }
        public BusStation EndBusStation { get; set; }
        public string BusLineCode { get; set; }
        public string Name { get; set; }
    }
}
