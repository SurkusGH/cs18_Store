using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Goods
{
    public class Meats : Item
    {
        // - Vaikinės prekės klasės:
        //			                - Mėsa(baltymai)
        public float Proteins { get; set; }

        public Meats(float proteins, decimal price, float barcode, float weight) : base(price, barcode, weight)
        {
            Proteins = proteins;
        }
    }
}
