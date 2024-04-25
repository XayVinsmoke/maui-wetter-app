using MauiWetterApp.ViewModels;

namespace MauiWetterApp.Views;

public partial class WeeklyForecastPage : ContentPage
{
	private readonly WeeklyForecastViewModel _viewModel = new WeeklyForecastViewModel();
    public WeeklyForecastPage()
	{
		InitializeComponent();
		BindingContext = _viewModel;
	}
}