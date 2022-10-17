using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya
{
    public struct Tick
    {
        public DateTime Timestamp { get; set; }
        public float Bid { get; set; }
        public Tick(string[] data)
        {
            Timestamp = Convert.ToDateTime(data[0]);
            Bid = Convert.ToSingle(data[1]);
        }
    }
}
