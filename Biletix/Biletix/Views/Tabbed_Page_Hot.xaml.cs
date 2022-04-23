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
    public partial class Tabbed_Page_Hot : ContentPage
    {
        public Tabbed_Page_Hot()
        {
            InitializeComponent();
        }

        public void Yildiz_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hot_Yildiz());
        }
        public void BKM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hot_BKM());
        }
        public void Dada_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hot_Dada());
        }
        public void Sut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hot_Sut());
        }
        public void Aydinlik_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hot_Aydinlik());
        }
        public void Fisek_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hot_Fisek());
        }
    }
}