﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerun.Models
{
    internal class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginModel() { }

        public LoginModel(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
