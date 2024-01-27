using CsvHelper.Configuration.Attributes;

namespace SleepChart.Client.Models
{
    public class FitbitSleepData
    {
        [Name("Start Time")]
        public string SleepStartTime { get; set; }

        [Name("End Time")]
        public string SleepEndTime { get; set; }
    }
}
