using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.Input;

namespace UnfocusTest
{
    public partial class MainViewModel
    {
        public double? Price { get; set; }

        [RelayCommand]
        public async void MyBreakPoint()
        {
            var test = Price;
            test = test;
        }
            

    }
}
