using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPrevoznikInfo.Model
{
    public class Driver :Worker
    {
        public List<Bus> Buses { get; set; }
    }
}
