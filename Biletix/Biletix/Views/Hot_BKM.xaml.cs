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
    public partial class Hot_BKM : ContentPage
    {
        bool clicked = false;
        public Hot_BKM()
        {
            InitializeComponent();
        }
        public void Clicked_More_Info(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                infoLabel.MaxLines = 100;
                clicked = true;
            }
            else
            {
                infoLabel.MaxLines = 1;
                clicked = false;
            }
        }
    }
}