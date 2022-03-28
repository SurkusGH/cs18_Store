using System;

namespace cs18_paskaita_Store.Goods
{
    public class Sweets : Item
    {
        // - Vaikinės prekės klasės:
        //			                - Saldainiai(cukrus)
        public int Id { get; set; }
        public float Carbohydrates { get; set; }

        public Sweets(int id = 0, float carbohydrates = 0f, decimal price = 0m, float barcode = 0f, float weight = 0f) : base(price, barcode, weight)
        {
            Id = id;
            Carbohydrates = carbohydrates;
        }
    }
}