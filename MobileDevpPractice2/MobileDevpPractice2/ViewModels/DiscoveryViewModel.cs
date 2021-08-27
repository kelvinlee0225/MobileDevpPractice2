using MobileDevpPractice2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDevpPractice2.ViewModels
{
    public class DiscoveryViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDining { get; set; }
        public MenuOption Cafes { get; set; }
        public MenuOption Nearby { get; set; }
        public MenuOption FastFoods { get; set; }
        public MenuOption FeaturedFoods { get; set; }


        public DiscoveryViewModel()
        {
            BarAndHotelsMenuOption = new MenuOption() { Title = "Bar And Hotels", TotalPlaces = "42 Places", Image = "BarsAndHotels.png" };
            FineDining = new MenuOption() { Title = "Fine Dining", TotalPlaces = "15 Places", Image = "FineDining.png" };
            Cafes = new MenuOption() { Title = "Cafes", TotalPlaces = "28 Places", Image = "Cafes.png" };
            Nearby = new MenuOption() { Title = "Nearby", TotalPlaces = "34 Places", Image = "Nearby.png" };
            FastFoods = new MenuOption() { Title = "Fast Foods", TotalPlaces = "29 Places", Image = "FastFoods.png" };
            FeaturedFoods = new MenuOption() { Title = "Featured Foods", TotalPlaces = "21 Places", Image = "FeaturedFoods.png" };
        }
    }
}
