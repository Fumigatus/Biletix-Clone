using System;
using System.Collections.Generic;
using System.Text;

namespace Biletix.Views
{
    class Events_Search
    {
        public string name { get; set; }
        public string image { get; set; }
        public Group Category { get; set; }
        public enum Group { Online, Hot}
    }
}
