

namespace MauiWetterApp.Services;

public class PreferenceService
{
    public double WindowWidth
    {
        get => Preferences.Default.Get(nameof(WindowWidth), 800d);
        set => Preferences.Default.Set(nameof(WindowWidth), value);
    }
    public double WindowHeight
    {
        get => Preferences.Default.Get(nameof(WindowHeight), 800d);
        set => Preferences.Default.Set(nameof(WindowHeight), value);
    }
    public double WindowXPosition
    {
        get => Preferences.Default.Get(nameof(WindowXPosition), 0d);
        set => Preferences.Default.Set(nameof(WindowXPosition), value);
    }
    public double WindowYPosition
    {
        get => Preferences.Default.Get(nameof(WindowYPosition), 0d);
        set => Preferences.Default.Set(nameof(WindowYPosition), value);
    }

    private static PreferenceService? _instance;

    public static PreferenceService Instance
    {
        get
        {
            if (_instance == null)
                _instance = new PreferenceService();

            return _instance;
        }
    }

    public AppTheme SelectedTheme
    {
        get => Preferences.Default.Get(nameof(AppTheme), AppTheme.Light);
        set => Preferences.Default.Set(nameof(AppTheme), (int)value);
    }


    private PreferenceService()
    {
        
    }


}
