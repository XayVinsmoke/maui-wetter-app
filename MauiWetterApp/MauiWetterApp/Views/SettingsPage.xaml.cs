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
}