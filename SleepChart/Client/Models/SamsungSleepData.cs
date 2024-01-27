using CsvHelper.Configuration.Attributes;

namespace SleepChart.Client.Models
{
    public class SamsungSleepData
    {
        [Name("com.samsung.health.sleep.start_time")]
        public string SleepStartTime { get; set; }

        [Name("com.samsung.health.sleep.end_time")]
        public string SleepEndTime { get; set; }

        [Name("com.samsung.health.sleep.time_offset")]
        public string TimeOffset { get; set; }
    }
}
