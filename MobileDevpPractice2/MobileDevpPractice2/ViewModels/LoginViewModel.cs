using MobileDevpPractice2.Models;
using MobileDevpPractice2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileDevpPractice2.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand NavigateCommand { get; }

        public User User { get; set; } = new User();

        public async void Login()
        {
            if (string.IsNullOrEmpty(User.Email))
            {
                await App.Current.MainPage.DisplayAlert("Error!", "Campo Email no puede estar vacio", "OK");
            }
            else if (string.IsNullOrEmpty(User.Password))
            {
                await App.Current.MainPage.DisplayAlert("Error!", "Campo Password no puede estar vacio", "OK");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido!", $"Hola {User.Email}", "OK");
                await App.Current.MainPage.Navigation.PushAsync(new MainTabbedPage());
            }
        }

        public async void NavigateToSignUp()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
            NavigateCommand = new Command(NavigateToSignUp);
        }
    }
}
