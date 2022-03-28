using System;

namespace cs18_paskaita_Store.Goods
{
    public class Meats : Item
    {
        // - Vaikinės prekės klasės:
        //			                - Mėsa(baltymai)
        public int Id { get; set; }
        public float Proteins { get; set; }

        public Meats(int id = 0, float proteins = 0f, decimal price = 0m, float barcode = 0f, float weight = 0f) : base(price, barcode, weight)
        {
            Id = id;
            Proteins = proteins;
        }
    }
}
