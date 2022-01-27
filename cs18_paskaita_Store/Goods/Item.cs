using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class Item
    {
        // - Tėvinė klasė prekė (kaina, barkodas, svoris)
        public decimal Price { get; set; }
        public float Barcode { get; set; }
        public float Weight { get; set; }

        public Item(decimal price, float barcode, float weight)
        {
            Price = price;
            Barcode = barcode;
            Weight = weight;
        }
    }
}
