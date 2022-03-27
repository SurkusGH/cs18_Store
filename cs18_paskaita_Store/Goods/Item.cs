namespace cs18_paskaita_Store
{
    public class Item
    {
        // - Tėvinė klasė prekė (kaina, barkodas, svoris)
        public decimal Price { get; set; }
        public float Barcode { get; set; }
        public float Weight { get; set; }

        public Item(decimal price = 0m, float barcode = 0f, float weight = 0f)
        {
            Price = price;
            Barcode = barcode;
            Weight = weight;
        }
    }
}
