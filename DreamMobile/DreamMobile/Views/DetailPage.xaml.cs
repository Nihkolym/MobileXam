﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DreamMobile.Helpers;

namespace DreamMobile.Views
{
	public partial class DetailPage : MasterDetailPage
	{
		public DetailPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TipsPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TemperaturePage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SettingsPage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Settings.AccessToken = "";
            Navigation.PushAsync(new LoginPage());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new UserInfoPage());
        }
    }
}