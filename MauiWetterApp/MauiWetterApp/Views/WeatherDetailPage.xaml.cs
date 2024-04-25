using MauiWetterApp.ViewModels;

namespace MauiWetterApp.Views;

public partial class WeatherDetailPage : ContentPage
{
    private readonly WeatherDetailViewModel _viewModel = new WeatherDetailViewModel();

    public WeatherDetailPage()
	{
		InitializeComponent();
		BindingContext = _viewModel;
	}
}