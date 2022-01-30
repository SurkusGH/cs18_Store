using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Functionality
{
    public class DataPrinting
    {
        public static void PrintAllCVS_dir()
        {
            var sweetsRepository = new SweetsRepository();
            var meatsRepository = new MeatsRepository();
            var greensRepository = new GreensRepository();
            var drinkablesRepository = new DrinkablesRepository();

            sweetsRepository.PrintProductData();
            meatsRepository.PrintProductData();
            greensRepository.PrintProductData();
            drinkablesRepository.PrintProductData();
        }
        public void PrintProductData_Sweets()
        {
            var sweetsRepository = new SweetsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in sweetsRepository.LoadSweetsCSVData())
            {
                Console.WriteLine($"Produktas: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     turi: {item.Carbohydrates} angliavandeinių");
                Console.WriteLine($" kainuoja: {item.Price} Eur");
                Console.WriteLine($" barkodas: {item.Barcode}");
                Console.WriteLine($"   svoris: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public void PrintProductData_Meats()
        {
            var meatsRepository = new MeatsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in meatsRepository.LoadMeatsCSVData())
            {
                Console.WriteLine($"Produktas: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     turi: {item.Proteins} baltymų");
                Console.WriteLine($" kainuoja: {item.Price} Eur");
                Console.WriteLine($" barkodas: {item.Barcode}");
                Console.WriteLine($"   svoris: {item.Weight} g");
                Console.WriteLine();
            }
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
        public void PrintProductData_Drinkables()
        {
            var drinkablesRepository = new DrinkablesRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in drinkablesRepository.LoadDrinkablesCSVData())
            {
                Console.WriteLine($"Produktas: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"      yra: {item.Volume} ml taros");
                Console.WriteLine($" kainuoja: {item.Price} Eur");
                Console.WriteLine($" barkodas: {item.Barcode}");
                Console.WriteLine($"   svoris: {item.Weight} g");
                Console.WriteLine();
            }
        }
    }
}
