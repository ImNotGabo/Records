using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Records.ModelView
{


    internal class BaseModel : INotifyPropertyChanged
    {
        public ICommand Login => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new Login()));

        public ICommand Sign => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new SignUp()));
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

}