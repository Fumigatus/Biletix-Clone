using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biletix.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabbed_Page_Listem : ContentPage
    {
        public class Events
        {
            public string name { get; set; }
            public string image { get; set; }
        }

        ObservableCollection<Events> carousel;


        public Tabbed_Page_Listem()
        {
            InitializeComponent();

            carousel = new ObservableCollection<Events>
            {
                new Events{name="İlelebet... Bir Atatürk Hatırası",image="online_ilelebet.png" },
                new Events{name="Külkedisi",image="online_kulkedisi.png" },
                new Events{name="Bana Amy De",image="online_bana.png" },
                new Events{name="Binbir Gece Masalları",image="online_binbir.png" },
                new Events{name="Bir Ofis Gecesi Rüyası",image="online_ofis.png" },
                new Events{name="3+1 Zombili",image="online_zombili.png" },
                new Events{name="Yıldız Tilbe",image="hot_yildiz.png" },
                new Events{name="Dada Salon Kabarett",image="hot_dada.png" },
                new Events{name="BKM Etkinlikler - Maximum Uniq",image="hot_bkm.png" },
                new Events{name="Aydınlık Evler",image="hot_aydinlik.png" },
                new Events{name="Süt Kardeşler",image="hot_sut.png" },
                new Events{name="Fişekhane Sahne",image="hot_fisekhane.png" }
            };
            eventView.ItemsSource = carousel;
             
        }

    }
}