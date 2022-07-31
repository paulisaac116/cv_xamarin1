using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace deber
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void showNatalyCV(object sender, EventArgs e)
        {
            //Navigation.PopAsync();
            Navigation.PushAsync(new nataly());
        }
        private void showAlejandroCV(object sender, EventArgs e)
        {
            //Navigation.PopAsync();
            Navigation.PushAsync(new alejandro());
        }
        private void showLuisCV(object sender, EventArgs e)
        {
            //Navigation.PopAsync();
            Navigation.PushAsync(new luis());
        }

    }
}
