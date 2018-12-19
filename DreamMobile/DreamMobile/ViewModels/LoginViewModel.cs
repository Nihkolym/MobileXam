<<<<<<< HEAD
﻿using Dream.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DreamMobile.ViewModels
{
    public class LoginViewModel
    {
        private ApiServices _apiServices = new ApiServices();

        public string Username { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async() =>
                {
                    await _apiServices.LoginAsync(Username, Password);
                });
            }
=======
﻿using DreamMobile.Services;
using System.Windows.Input;
using Xamarin.Forms;
using DreamMobile.Helpers;
using System.Linq;

namespace DreamMobile.ViewModels
{
    public class LoginViewModel 
    {
        private ApiServices _apiServices = new ApiServices();
        
        public string Username { get; set; }
        
        
        public string Password { get; set; }
        
        public LoginViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
>>>>>>> origin/master
        }
    }
}
