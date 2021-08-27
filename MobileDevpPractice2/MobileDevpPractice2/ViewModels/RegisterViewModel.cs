using MobileDevpPractice2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileDevpPractice2.ViewModels
{
    public class RegisterViewModel
    {
        public ICommand RegisterCommand { get; }
        public User User { get; set; } = new User();

        public async void SignUp()
        {
            if (string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.ConfirmPass))
            {
                await App.Current.MainPage.DisplayAlert("Error!", "Ningun campo puede estar vacio", "OK");
            }
            else if (User.Password != User.ConfirmPass)
            {
                await App.Current.MainPage.DisplayAlert("Error!", "La contraseña no coincide", "OK");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido!", $"Registrado {User.Name}", "OK");
            }
        }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(SignUp);
        }
    }
}
