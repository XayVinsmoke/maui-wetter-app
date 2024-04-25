using MauiWetterApp.Models;

namespace MauiWetterApp.ViewModels;

internal class SettingsViewModel : NotifyBase
{
    private string _appVersion = "0.1.0";

    public string AppVersion 
    { 
        get => _appVersion;
        set
        {
            if(_appVersion != value)
            {
                _appVersion = value;
                OnPropertyChanged(nameof(AppVersion));
            }
        }
       
    }
}
