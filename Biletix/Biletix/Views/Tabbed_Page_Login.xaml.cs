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
    public partial class Tabbed_Page_Login : TabbedPage
    {
        public Tabbed_Page_Login()
        {
            InitializeComponent();
        }
        public void Login_Clicked(object sender, EventArgs e)
        {
            if (emailEntry.Text == null || passEntry.Text == null)
                DisplayAlert("Hata!", "Email ve şifre boş bırakılamaz!", "Tamam");
            else
                DisplayAlert("", "Giriş başarılı!", "Tamam");
        }
    }
}