<<<<<<< HEAD
﻿using Dream.Services;
=======
﻿using DreamMobile.Services;
>>>>>>> origin/master
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
<<<<<<< HEAD
=======
using DreamMobile.Helpers;
>>>>>>> origin/master

namespace Dream.ViewModels
{
    public class RegisterViewModel
    {
        ApiServices apiServices = new ApiServices();
<<<<<<< HEAD

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Message { get; set; }

        public Command RegisterCommand
        {
            get
            {
                return new Command(async() =>
                {
                    await apiServices.RegisterAsynk(Email, Password, ConfirmPassword);
                    
                });
            }
        }
=======
        
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string ConfirmPassword { get; set; }
        
>>>>>>> origin/master
    }
}
