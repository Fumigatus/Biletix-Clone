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
    }
}