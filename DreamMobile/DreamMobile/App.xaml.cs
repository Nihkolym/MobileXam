using Dream.Views;
<<<<<<< HEAD
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
=======
using DreamMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DreamMobile.Helpers;
>>>>>>> origin/master

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DreamMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

<<<<<<< HEAD
            MainPage = new NavigationPage(new RegisterPage());
=======
            if (Settings.AccessToken != "")
            {
                MainPage = new NavigationPage(new DetailPage());
            }
            else
            {
                MainPage = new NavigationPage(new RegisterPage());
            }
>>>>>>> origin/master
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
