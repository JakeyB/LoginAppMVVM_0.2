using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace LoginAppMVVM_0._2.Models
{
    class UserModel : PropertyChangedBase
    {
        private string _username;
        private string _password;

        // Get and set username
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyOfPropertyChange(() => Username);
            }
        }

        // Get and set password
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }

        // Create a user with associated username + password
        public static UserModel CreateUser(string username, string password)
        {
            return new UserModel { Username = username, Password = password };
        }

    }
}
