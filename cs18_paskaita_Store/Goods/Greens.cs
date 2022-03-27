namespace cs18_paskaita_Store
{
    public class Greens : Item
    {
        // - Vaikinės prekės klasės:
        //		                	- Daržovės(skaidulinės medžiagos)
        public float Fibers { get; set; }

        public Greens(float fibers = 0f, decimal price = 0m, float barcode = 0f, float weight = 0f) : base(price, barcode, weight)
        {
            Fibers = fibers;
        }
    }
}
