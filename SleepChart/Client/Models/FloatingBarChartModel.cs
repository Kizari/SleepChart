using System.Collections.Generic;

namespace SleepChart.Client.Models
{
    public class FloatingBarChartModel
    {
        public FloatingBarChartModel()
        {
            Labels = new List<string>();
            Datasets = new List<FloatingBarChartData>();
        }

        public IList<string> Labels { get; set; }
        public IList<FloatingBarChartData> Datasets { get; set; }
    }

    public class FloatingBarChartData
    {
        public FloatingBarChartData()
        {
            Data = new List<int[]>();
        }

        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public double BarPercentage { get; set; }
        public List<int[]> Data { get; set; }
    }
}
