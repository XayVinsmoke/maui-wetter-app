using MauiWetterApp.Models;
using System.Collections.ObjectModel;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace MauiWetterApp.ViewModels;

internal class TodayWeatherViewModel : NotifyBase
{
    public ObservableCollection<Weather> Weathers { get; } = new ObservableCollection<Weather>();

    public TodayWeatherViewModel() 
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
      
    }

   
}
