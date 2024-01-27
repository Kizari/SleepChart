using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SleepChart.Client.Models
{
    public class Day
    {
        public DateTime Date { get; set; }
        public IEnumerable<Bar> Bars { get; set; }
    }
}
