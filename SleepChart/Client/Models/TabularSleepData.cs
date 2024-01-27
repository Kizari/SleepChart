using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SleepChart.Client.Models
{
    public class TabularSleepData
    {
        public DateTime Date { get; set; }
        public DateTime TimeToBed { get; set; }
        public DateTime SleepStart { get; set; }
        public DateTime TimeUp { get; set; }
        public double HoursOfSleep { get; set; }
        public int AutoAwakenings { get; set; }
        public int UserAwakenings { get; set; }
        public string Comments { get; set; }
    }
}
