﻿using Dream.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamMobile.Helpers;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DreamMobile.ViewModels;
using System.Threading;

namespace DreamMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (Settings.AccessToken.Any())
            {
                await Navigation.PushAsync(new DetailPage());
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            if (Settings.AccessToken.Any())
            {
                await Navigation.PushAsync(new DetailPage());
            }
        }
    }
}