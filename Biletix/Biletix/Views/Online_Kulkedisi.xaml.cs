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
    public partial class Online_Kulkedisi : ContentPage
    {
        bool clicked;
        public Online_Kulkedisi()
        {
            InitializeComponent();
        }

        void Mekan_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Mekan_Page());
        }
        void Notlar_Clicked(object sender, EventArgs args)
        {
            if (clicked == false)
            {
                notesLabel.MaxLines = 15;
                clicked = true;
            }
            else if (clicked == true)
            {
                notesLabel.MaxLines = 1;
                clicked = false;
            }
        }

        private void Website_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Resmi Site", "Site Bulunmamaktadır.", "Tamam");
        }

        private void Gallery_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Galeri ve Fotoğraflar", "Galeri ve Fotoğraflar Bulunmamaktadır.", "Tamam");
        }
    }
}