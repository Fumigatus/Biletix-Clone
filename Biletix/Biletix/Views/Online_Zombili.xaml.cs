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
    public partial class Online_Zombili : ContentPage
    {
        bool notes_clicked = false;
        bool info_clicked = false;
        public Online_Zombili()
        {
            InitializeComponent();
        }
        public void Devam_Clicked(object sender, EventArgs e)
        {
            if (pickerBolum == null || pickerSatis == null || pickerTarih == null)
                DisplayAlert("", "Satış tipi, tarih veya bolüm boş olamaz.", "Tamam");
            else
                DisplayAlert("", "Bilet başarıyla alındı", "Tamam");
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