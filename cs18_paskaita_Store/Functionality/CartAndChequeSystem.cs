using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Functionality
{
    public class CartAndChequeSystem
    {
        
        public static List<string> cartList = new List<string>();
        public static decimal cartTotal = 0m;
        static public void AddSweetsToCartList(int index)
        {
            var sweetsRepository = new SweetsRepository();
            var itemIdentifier = new BarcodeAuthenticator();

            for (int i = 0; i < sweetsRepository.LoadSweetsCSVData().Count; i++)
            {
                if (i == index)
                {
                    cartList.Add($"{itemIdentifier.ItemIdentifier(sweetsRepository.LoadSweetsCSVData()[index].Barcode)} už {sweetsRepository.LoadSweetsCSVData()[index].Price} Eur");
                }
            }
            cartTotal += sweetsRepository.LoadSweetsCSVData()[index].Price;
        }
        static public void AddMeatsToCartList(int index)
        {
            var meatsRepository = new MeatsRepository();
            var itemIdentifier = new BarcodeAuthenticator();

            for (int i = 0; i < meatsRepository.LoadMeatsCSVData().Count; i++)
            {
                if (i == index)
                {
                    cartList.Add($"{itemIdentifier.ItemIdentifier(meatsRepository.LoadMeatsCSVData()[index].Barcode)} už {meatsRepository.LoadMeatsCSVData()[index].Price} Eur");
                }
            }
            cartTotal += meatsRepository.LoadMeatsCSVData()[index].Price;
        }
        static public void AddGreensToCartList(int index)
        {
            var greensRepository = new GreensRepository();
            var itemIdentifier = new BarcodeAuthenticator();

            for (int i = 0; i < greensRepository.LoadGreensCSVData().Count; i++)
            {
                if (i == index)
                {
                    cartList.Add($"{itemIdentifier.ItemIdentifier(greensRepository.LoadGreensCSVData()[index].Barcode)} už {greensRepository.LoadGreensCSVData()[index].Price} Eur");
                }
            }
            cartTotal += greensRepository.LoadGreensCSVData()[index].Price;
        }
        static public void AddDrinkablesToCartList(int index)
        {
            var drinkablesRepository = new DrinkablesRepository();
            var itemIdentifier = new BarcodeAuthenticator();

            for (int i = 0; i < drinkablesRepository.LoadDrinkablesCSVData().Count; i++)
            {
                if (i == index)
                {
                    cartList.Add($"{itemIdentifier.ItemIdentifier(drinkablesRepository.LoadDrinkablesCSVData()[index].Barcode)} už {drinkablesRepository.LoadDrinkablesCSVData()[index].Price} Eur");
                }
            }
            cartTotal += drinkablesRepository.LoadDrinkablesCSVData()[index].Price;
        }

        public static void PrintCart()
        {
            foreach (var item in cartList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Mokėtina suma: {cartTotal}");
        }
    }
}
//public void RemoveTVShowByNameService(List<TV_Show> list, string input)
//{
//    foreach (var item in list)
//    {
//        if (item.Title == input)
//        {
//            list.Remove(item);
//            break;
//        }
//    }
//}