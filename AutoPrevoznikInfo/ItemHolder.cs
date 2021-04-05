using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPrevoznikInfo
{
    public class ItemHolder
    {
        public string text { get; set; }
        public object value { get; set; }

        public override string ToString()
        {
            return text;
        }
    }
}
