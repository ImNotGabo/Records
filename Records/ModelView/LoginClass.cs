using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Records.ModelView
{
    class LoginClass
    {
        public ICommand back => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
    }
}
