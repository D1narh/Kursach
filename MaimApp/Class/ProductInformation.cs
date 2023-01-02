using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaimApp.Class
{
    public class ProductInformation
    {
        public int ID { get; set; }
        public string ShortDiscription { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public bool IsFavorite { get; set; }
    }
}

