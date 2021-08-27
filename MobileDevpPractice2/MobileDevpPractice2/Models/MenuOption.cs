using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobileDevpPractice2.Models
{
    public class MenuOption : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public string TotalPlaces { get; set; }
        public string Image { get; set; }
    }
}
