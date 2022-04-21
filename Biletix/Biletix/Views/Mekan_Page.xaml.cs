using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biletix.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mekan_Page : ContentPage
    {
        bool clicked = true;
        public Mekan_Page()
        {
            InitializeComponent();
        }
        
        void Mekan_Clicked(object sender, EventArgs args)
        {
            if (clicked == false)
            {
                mekanInfoLabel.MaxLines = 15;
                clicked = true;
            }
            else if (clicked == true)
            {
                mekanInfoLabel.MaxLines = 1;
                clicked = false;
            }
        }
        private void Oturma_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Oturma Planı", "Online Etkinliktir.", "Tamam");
        }

        private void Kulkedisi_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Kulkedisi());
        }

        private void Ofis_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Kulkedisi());
        }

        private void Binbir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Kulkedisi());
        }

        private void Zombili_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Kulkedisi());
        }

        private void Bana_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Kulkedisi());
        }
    }
}