﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPrevoznikInfo.Model
{
    class Bus
    {
        public int BusId { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfDoors { get; set; }
        public string GarageNumber { get; set; }
        public string BusType { get; set; }
    }
}
