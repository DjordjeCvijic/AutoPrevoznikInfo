using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPrevoznikInfo.Model
{
    class Message
    {
        public int MessageID { get; set; }
        public Worker FromWorker { get; set; }
        public Worker ToWorker { get; set; }
        public string Date { get; set; }
        public string MessageContent { get; set; }


    }
    
}
