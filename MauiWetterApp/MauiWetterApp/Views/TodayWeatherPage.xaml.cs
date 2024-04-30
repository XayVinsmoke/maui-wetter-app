using MauiWetterApp.ViewModels;

namespace MauiWetterApp.Views;

public partial class TodayWeatherPage : ContentPage
{
    private readonly TodayWeatherViewModel _viewModel = new TodayWeatherViewModel();

    public TodayWeatherPage()
    {
        InitializeComponent();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.InitializeData();
    }


}
