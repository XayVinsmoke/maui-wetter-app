using MauiWetterApp.Collections;

namespace MauiWetterApp.Models;

internal class Weather : NotifyBase
{
    private string _condition;
    private int _temperature = 0;
    private DateTime _dateTime = DateTime.Now;
    private ImageSource _weatherImage;


    public string Condition
    { 
        get => _condition;
        set
        {
            if(_condition != value)
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }

        }
    }

    public int Temperature
    {
        get => _temperature;
        set
        {
            if(_temperature != value)
            {
                _temperature = value;
                OnPropertyChanged(nameof(Temperature));
            }
        }
    }

    public ImageSource WeatherImage 
    { 
        get => _weatherImage;
        set
        {
            if(_weatherImage != value)
            {
                _weatherImage = value;
                OnPropertyChanged(nameof(WeatherImage));
            }
        }           
    }

    public DateTime DateTime
    { 
        get => _dateTime;
        set
        {
            if(_dateTime != value)
            {
                _dateTime = value;
                OnPropertyChanged(nameof(DateTime));
            }

        }
    }

    private ImageSource DetermineWeatherImage(string condition)
    {
        switch (condition)
        {
            case "Sunny":
                return ImageSource.FromFile("sunny.png");
            case "Cloudy":
                return ImageSource.FromFile("cloudydark.png");
            case "Rainy":
                return ImageSource.FromFile("raindark.png");

            default:
                return ImageSource.FromFile("cloudydark.png");
        }
    }

    public Weather()
    {
        _condition = GetRandomWeatherCondition();

        WeatherImage = DetermineWeatherImage(_condition);
        
    }

    private string GetRandomWeatherCondition()
    {
        var values = Enum.GetValues(typeof(WeatherConditions));
        var random = new Random();
        return values.GetValue(random.Next(values.Length)).ToString();
    }


}