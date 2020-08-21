using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.src.Entity
{
    public class DistanceFromTo
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Distance { get; set; }

        public DistanceFromTo(string @from, string to, int distance)
        {
            From = @from;
            To = to;
            Distance = distance;
        }
    }
}
