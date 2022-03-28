using System;

namespace cs18_paskaita_Store
{
    public class Drinkables : Item
    {
        // - Vaikinės prekės klasės:
        //		                	- Gėrimai(litrai)
        public int Id { get; set; }
        public float Volume { get; set; }

        public Drinkables(int id = 0, float volume = 0f, decimal price = 0m, float barcode = 0f, float weight = 0f) : base(price, barcode, weight)
        {
            Id = id;
            Volume = volume;
        }
    }
}
