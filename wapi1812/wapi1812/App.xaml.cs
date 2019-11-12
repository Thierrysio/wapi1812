using System;
using wapi1812.Vues;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wapi1812
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AuthentificationPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
