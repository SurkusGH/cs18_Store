using cs18_paskaita_Store.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class DrinkablesRepository
    {
        public List<Drinkables> DrinkablesList { get; set; }

        public DrinkablesRepository()
        {
            DrinkablesList = new List<Drinkables>();
        }
        public List<Drinkables> LoadDrinkablesCSVData()
        {
            var handler = new CSV_Handler();
            DrinkablesList = handler.ReadDrinkablesCSVData("Drinkables");
            return DrinkablesList;
        }
        public void AddDrinkablesToCSV(Drinkables drinkables)
        {
            var handler = new CSV_Handler();
            handler.WriteDrinkablesDataToCSV("Drinkables", drinkables);
        }
        public void PrintProductData()
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
