﻿namespace WeatherApp.Ui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private string selectedRoute;

        public string SelectedRoute
        {
            get => selectedRoute;
            set
            {
                selectedRoute = value;
                OnPropertyChanged();
            }
        }

        private void OnMenuItemChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedRoute))
                Shell.Current.GoToAsync($"//{selectedRoute}");
        }
    }
}