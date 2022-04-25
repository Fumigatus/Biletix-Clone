using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Biletix.Views
{
    class CartSingelton
    {
        private static readonly CartSingelton instance = new CartSingelton();

        public class EventCart
        {
            public string Name { get; set; }
            public string Image { get; set; }
        }

        private readonly EventCart[] cartSource =
        {
            new EventCart{Name="",Image=""}
        };
        public EventCart newTicket = new EventCart();
        public ObservableCollection<EventCart> cartTickets = new ObservableCollection<EventCart>();
        
        static CartSingelton()
        {

        }

        public static CartSingelton Instance
        {
            get
            {
                return instance;
            }
        }

        public void AddCart(string name,string img)
        {
            newTicket.Name = name;
            newTicket.Image= img;
            if (cartTickets != null)
            {
                cartTickets.Add(newTicket);
                if (cartTickets[0].Name=="")
                {
                    cartTickets.RemoveAt(0);
                }
            }
        }
    }
}
