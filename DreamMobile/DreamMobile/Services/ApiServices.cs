﻿using Dream.Models;
using Newtonsoft.Json;
<<<<<<< HEAD
=======
using Newtonsoft.Json.Linq;
>>>>>>> origin/master
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace Dream.Services
{
    public class ApiServices
    {
        internal async Task<bool> RegisterAsynk(string email, string password, string confirmPassword)
=======
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DreamMobile.Services
{
    public class ApiServices
    {
        internal async Task<bool> RegisterAsynk(string password, string confirmPassword, string email)
>>>>>>> origin/master
        {
            var client = new HttpClient();
            var model = new RegisterBindingModel
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:2273/api/account/register", content);
            
            return response.IsSuccessStatusCode;
        }

<<<<<<< HEAD
        public async Task LoginAsync(string userName, string password) 
=======
        public async Task<string> LoginAsync(string userName, string password)
>>>>>>> origin/master
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", userName),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password")
            };

<<<<<<< HEAD
            var request = new HttpRequestMessage(HttpMethod.Post, 
                "http://localhost:2273/Token");

            request.Content = new FormUrlEncodedContent(keyValues);

            var client = new HttpClient();
            var response = await client.SendAsync(request);
            var content =await response.Content.ReadAsStringAsync();

            Debug.WriteLine(content); 
        }
=======
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,
                "http://localhost:2273/Token")
            {
                Content = new FormUrlEncodedContent(keyValues)
            };

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            string jwt = await response.Content.ReadAsStringAsync();

            JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(jwt);

            var accessToken = jwtDynamic.Value<string>("access_token");

            return accessToken;
            }
>>>>>>> origin/master
    }
}
