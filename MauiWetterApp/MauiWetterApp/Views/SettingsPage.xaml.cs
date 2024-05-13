using MauiWetterApp.Services;
using MauiWetterApp.ViewModels;

namespace MauiWetterApp.Views;

public partial class SettingsPage : ContentPage
{
    private readonly SettingsViewModel _viewModel = new SettingsViewModel();
    public SettingsPage()
	{
		InitializeComponent();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        AppTheme currentTheme = PreferenceService.Instance.SelectedTheme;

        if (currentTheme == AppTheme.Dark)
        {
            themeSwitch.IsToggled = true;
        }
        
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value == true)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
            PreferenceService.Instance.SelectedTheme = AppTheme.Dark;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Light;
            PreferenceService.Instance.SelectedTheme = AppTheme.Light;
        }
    }

    
}