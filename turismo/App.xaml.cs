using turismo.Views.Home;
using turismo.Views.Login;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using turismo.Views.Productos;

namespace turismo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VPPrincipal();
            //MainPage = new NavigationPage(new VHPrincipal());
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
