using System.ComponentModel.Composition;
using System.Dynamic;
using System.Windows;
using Caliburn.Micro;
using LoginAppMVVM_0._2.DataAccess;
using LoginAppMVVM_0._2.Models;
using LoginAppMVVM_0._2.Views;

namespace LoginAppMVVM_0._2.ViewModels
{
    [Export(typeof(LoginViewModel))]
    class LoginViewModel :PropertyChangedBase, IHaveDisplayName
    {
        //  See also the editted bootstrapper and the new AppWindowManager classes

        //  Each VM contains this, which allows another VM to call it
        //  see the button click event at the bottom of the screen for call.

        private string _displayName = "Login Page";

        private readonly IWindowManager _windowManager;

        [ImportingConstructor]
        public LoginViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        } 


        // private UserModel _newUser = UserModel.CreateUser();
        // Database to hold user info
        //readonly DBConnect _userDB = new DBConnect();
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyOfPropertyChange(()=> Username);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(()=> Password);
            }
        }

        public void Btn_login()
        {
            // If the username or password box are empty, print error
            if (Username == null || Password == null)
            {
                MessageBox.Show("Please enter a username and password before continuing!");
                return;
            }
            else
            {
                dynamic settings = new ExpandoObject();
                settings.WindowStartupLocation = WindowStartupLocation.Manual;

                _windowManager.ShowWindow(new MainViewModel(_windowManager), null, settings);
            }

        }
    }
}
