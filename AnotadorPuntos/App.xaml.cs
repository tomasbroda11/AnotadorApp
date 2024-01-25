using AnotadorPuntos.Services;
using AnotadorPuntos.ViewModels;
using AnotadorPuntos.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnotadorPuntos
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            PartidasViewModel viewModel = new PartidasViewModel();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
