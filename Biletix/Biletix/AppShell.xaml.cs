using Biletix.ViewModels;
using Biletix.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Biletix
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            CurrentItem = Hot_Ticket_Page;
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        void Click_Login(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            Navigation.PushAsync(new Tabbed_Page_Login());
        }
    }
}
