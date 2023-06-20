using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        static string Login;
        static string Password;
        public Welcome()
        {
            InitializeComponent();
        }
        private bool CheckFields(string _login, string _password)
        {
            if (_login == null || _login.Length <= 2)
            {
                this.DisplayToastAsync("Длина логина должна быть больше 2 символов");
    
                return false;
            }
            if (_password == null || _password.Length <= 4)
            {
                this.DisplayToastAsync("Длина пароля должна быть больше 4 символов");
                return false;
            }
            Login = _login;
            Password = _password;
            return true;
        }
        private void singInButton_Clicked(object sender, EventArgs e)
        {
            if (CheckFields(login.Text, password.Text))
            {
                Navigation.PushAsync(new MainPage(Login, Password));
            }
        }
    }
}