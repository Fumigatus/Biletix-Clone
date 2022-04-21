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
    public partial class Tabbed_Page_Online : ContentPage
    {
        public Tabbed_Page_Online()
        {
            InitializeComponent();
        }

        private async void Ilelebet_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Online_Ilelebet());
        }

        private void Kulkedisi_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Kulkedisi());
        }

        private void Ofis_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Ofis());
        }

        private void Binbir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Binbir());
        }

        private void Zombili_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Zombili());
        }

        private void Bana_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Online_Bana());
        }
    }
}