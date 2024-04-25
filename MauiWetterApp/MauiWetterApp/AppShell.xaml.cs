using MauiWetterApp.Views;

namespace MauiWetterApp
{
    public partial class AppShell : Shell
    {
        private const string WeatherDetailPageBase = $"{nameof(TodayWeatherPage)}/{nameof(WeatherDetailPage)}";
        public const string WeatherDetailPageRoute = $"///{WeatherDetailPageBase}";
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(WeatherDetailPageBase, typeof(WeatherDetailPage));
        }
    }
}
