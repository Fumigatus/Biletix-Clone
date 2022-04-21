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
    public partial class Online_Binbir : ContentPage
    {
        bool notes_clicked = true;
        bool info_clicked = true;
        public Online_Binbir()
        {
            InitializeComponent();
        }

        void Mekan_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Mekan_Page());
        }

        void Notes_Clicked(object sender, EventArgs args)
        {
            if (notes_clicked == false)
            {
                notesLabel.MaxLines = 15;
                notes_clicked = true;
            }
            else if (notes_clicked == true)
            {
                notesLabel.MaxLines = 1;
                notes_clicked = false;
            }
        }

        void Info_Clicked(object sender, EventArgs e)
        {
            if (info_clicked == false)
            {
                infoLabel.MaxLines = 15;
                info_clicked = true;
            }
            else if (notes_clicked == true)
            {
                infoLabel.MaxLines = 1;
                info_clicked = false;
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
