using MobileDevpPractice2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDevpPractice2.ViewModels
{
    public class MainViewModel
    {
        public User user { get; set; } = new User();
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();

        public MainViewModel()
        {
            BarAndHotelsMenuOption.Title = "Bar And Hotels";
        }
    }
}
