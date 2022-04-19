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
    public partial class Search : ContentPage
    {
        ObservableCollection<Events_Search> events;
        public Search()
        {
            InitializeComponent();
            events = new ObservableCollection<Events_Search>
            {
                new Events_Search{name="Ilelebet... Bir Atatürk Hikayesi",image="online_ilelebet.jpg", Category=Events_Search.Group.Online },
                new Events_Search{name="Külkedisi",image="online_kulkedisi.jpg", Category=Events_Search.Group.Online },
                new Events_Search{name="Bir Ofis Gecesi Rüyası",image="online_ofis.jpg", Category=Events_Search.Group.Online },
                new Events_Search{name="3+1 Zombili",image="online_zombili.jpg", Category=Events_Search.Group.Online },
                new Events_Search{name="Bana Amy De",image="online_bana.jpg", Category=Events_Search.Group.Online },
                new Events_Search{name="Binbir Gece Masalları",image="online_binbir.jpg", Category=Events_Search.Group.Online },
                new Events_Search{name="Yıldız Tilbe",image="hot_yildiz.jpg", Category=Events_Search.Group.Hot },
                new Events_Search{name="Dada Salon Kabarett",image="hot_dada.jpg", Category=Events_Search.Group.Hot },
                new Events_Search{name="BKM Etkinlikleri - Maximum Uniq",image="hot_bkm.jpg", Category=Events_Search.Group.Hot },
                new Events_Search{name="Aydınlıkevler",image="hot_aydinlik.jpg", Category=Events_Search.Group.Hot },
                new Events_Search{name="Fişekhane Sahne",image="hot_fisekhane.jpg", Category=Events_Search.Group.Hot },
            };

            myCollectionView.ItemsSource = events;

        }
        private void Sb_Text_Change(object sender, TextChangedEventArgs e)
        {
            //var searchTerm = e.NewTextValue;
            //searchTerm = searchTerm.ToLowerInvariant();
            var filteredItems = events.Where(a => a.name.ToLowerInvariant().StartsWith(e.NewTextValue));
            myCollectionView.ItemsSource = filteredItems;
        }
    }
}