using MauiWetterApp.Services;
namespace MauiWetterApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();

            SetTheme();
  
        }

        private void SetTheme()
        {
            Application.Current.UserAppTheme = PreferenceService.Instance.SelectedTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = base.CreateWindow(activationState);

            window.Created += (x, y) =>
            {
                window.Width = PreferenceService.Instance.WindowWidth;
                window.Height = PreferenceService.Instance.WindowHeight;
                window.X = PreferenceService.Instance.WindowXPosition;
                window.Y = PreferenceService.Instance.WindowYPosition;
            };

            window.Destroying += (x, y) =>
            {
                PreferenceService.Instance.WindowWidth = window.Width;
                PreferenceService.Instance.WindowHeight = window.Height;
                PreferenceService.Instance.WindowXPosition = window.X;
                PreferenceService.Instance.WindowYPosition = window.Y;
            };

            return window;
        }
    }
}
