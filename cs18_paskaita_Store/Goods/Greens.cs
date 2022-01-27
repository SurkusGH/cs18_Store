using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class Greens : Item
    {
        // - Vaikinės prekės klasės:
        //		                	- Daržovės(skaidulinės medžiagos)
        public float Fibers { get; set; }

        public Greens(float fibers, decimal price, float barcode, float weight) : base(price, barcode, weight)
        {
            Fibers = fibers;
        }
    }
}
