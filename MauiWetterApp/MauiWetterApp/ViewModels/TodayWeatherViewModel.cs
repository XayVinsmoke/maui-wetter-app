using MauiWetterApp.Models;
using System.Collections.ObjectModel;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace MauiWetterApp.ViewModels;

internal class TodayWeatherViewModel : NotifyBase
{
    public ObservableCollection<Weather> Weathers { get; } = new ObservableCollection<Weather>();
    public ObservableCollection<Weather> WeeklyForecasts { get; } = new ObservableCollection<Weather>();

    public TodayWeatherViewModel()
    {
        //empty
    }

    public void InitializeData()
    {
        if (Weathers.Count == 0)
        {
            Random random = new Random();
            DateTime startDateTime = DateTime.Now;

            for (int i = 0; i < 24; i++)
            {
                Weather weatherTemp = new Weather();
                weatherTemp.Temperature = random.Next(-10, 45);
                weatherTemp.DateTime = startDateTime.AddHours(i);

                Weathers.Add(weatherTemp);
            }

            for (int i = 0; i <= 7; i++)
            {
                Weather weeklyTemp = new Weather();
                weeklyTemp.Temperature = random.Next(-10, 45);
                weeklyTemp.DateTime = startDateTime.AddDays(i);

                WeeklyForecasts.Add(weeklyTemp);
            }
        }
    }
}