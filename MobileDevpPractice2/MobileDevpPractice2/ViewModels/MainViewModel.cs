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
        public MenuOption FineDiningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();

        public MainViewModel()
        {
            BarAndHotelsMenuOption = new MenuOption() { Title = "Bar And Hotels", TotalPlaces="42 Places", Image= "BarAndHotels.png" };
            FineDiningMenuOption = new MenuOption() { Title = "Fine Dining", TotalPlaces = "42 Places", Image = "FineDining.png" };
            CafesMenuOption = new MenuOption() { Title = "Cafes", TotalPlaces = "42 Places", Image = "Cafes.png" };
            NearbyMenuOption = new MenuOption() { Title = "Nearby", TotalPlaces = "42 Places", Image = "Nearby.png" };
            FastFoodsMenuOption = new MenuOption() { Title = "Fast Foods", TotalPlaces = "42 Places", Image = "FastFoods.png" };
            FeaturedFoodsMenuOption = new MenuOption() { Title = "Featured Foods", TotalPlaces = "42 Places", Image = "FeaturedFoods.png" };
        }
    }
}
