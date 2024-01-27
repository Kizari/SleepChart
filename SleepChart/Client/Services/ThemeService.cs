namespace SleepChart.Client.Services
{
    public enum Theme { Light, Dark }

    public class ThemeService
    {
        public Theme Theme { get; set; } = Theme.Dark;
        public string BackgroundColor => Theme == Theme.Light ? "#f4f6f7" : "#2a2c2d";
        public string BorderColor => Theme == Theme.Light ? "#cacccd" : "#5a5c5d";
        public string TextColor => Theme == Theme.Light ? "#2a2c2d" : "#dadedc";
        public string LinkColor => Theme == Theme.Light ? "steelblue" : "steelblue";
        public string HeaderBackground => Theme == Theme.Light ? "#ffffff" : "#000000";
    }
}
