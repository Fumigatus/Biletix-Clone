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
    public partial class TabbedPage_Main : TabbedPage
    {
        public TabbedPage_Main()
        {
            InitializeComponent();
        }

        private async void Search_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Search());
        }
    }
}