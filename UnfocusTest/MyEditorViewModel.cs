using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnfocusTest
{
    public class MyEditorViewModel
    {
        public bool _isFocused { get; set; }
        public bool IsUnFocused
        {
            get
            {
                return _isFocused;
            }
            set
            {
                if(_isFocused == true && value == false)
                {
                    //Element is currently focused, about to be unfocused so trigger unfocus
                   MyUnfocused();
                }
                _isFocused = value;
            }
        }
        public string MyTextValue { get; set; }
        public async void MyUnfocused()
        {
            await App.Current.MainPage.DisplayAlert("Your text", MyTextValue, "OK");
        }
    }
}
