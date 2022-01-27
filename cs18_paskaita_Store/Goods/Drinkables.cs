using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class Drinkables : Item
    {
        // - Vaikinės prekės klasės:
        //		                	- Gėrimai(litrai)
        public float Volume { get; set; }

        public Drinkables(float volume, decimal price, float barcode, float weight) : base(price, barcode, weight)
        {
            Volume = volume;
        }
    }
}
