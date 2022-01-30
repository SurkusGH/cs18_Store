using cs18_paskaita_Store.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class GreensRepository
    {
        public List<Greens> GreensList { get; set; }

        public GreensRepository()
        {
            GreensList = new List<Greens>();
        }
        public List<Greens> LoadGreensCSVData()
        {
            var handler = new CSV_Handler();
            GreensList = handler.ReadGreensCSVData("Greens");
            return GreensList;
        }
        public void AddGreensToCSV(Greens greens)
        {
            var handler = new CSV_Handler();
            handler.WriteGreensDataToCSV("Greens", greens);
        }
        public void PrintProductData()
        {
            var greensRepository = new GreensRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in greensRepository.LoadGreensCSVData())
            {
                Console.WriteLine($"Produktas: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     turi: {item.Fibers} skaidulinių medžiagų");
                Console.WriteLine($" kainuoja: {item.Price} Eur");
                Console.WriteLine($" barkodas: {item.Barcode}");
                Console.WriteLine($"   svoris: {item.Weight} g");
                Console.WriteLine();
            }
        }
    }
}
