using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Functionality
{
    public class CartAndChequeSystem
    {
        #region CLASS GLOBALS
        public static List<string> cartList = new List<string>();
        public static string Cheque;
        public static decimal cartTotal = 0m;
        public static decimal wallet = 0m;
        public static List<decimal> moneyOperations = new List<decimal>();
        #endregion

        #region ADD TO CART
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
            moneyOperations.Add(sweetsRepository.LoadSweetsCSVData()[index].Price);
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
            moneyOperations.Add(meatsRepository.LoadMeatsCSVData()[index].Price);
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
            moneyOperations.Add(greensRepository.LoadGreensCSVData()[index].Price);
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
            moneyOperations.Add(drinkablesRepository.LoadDrinkablesCSVData()[index].Price);
        }
        #endregion

        #region OTHER FUNCTIONS
        public static void ShowBalance()
        {
            Console.WriteLine();
            Console.WriteLine($"    Piniginė: {wallet} Eur");
            Console.WriteLine($"   Krepšelis: {cartTotal} Eur");
            Console.WriteLine();
            CheckBalance();
        }

        public static void CheckBalance()
        {
            if (wallet - cartTotal < 0)
            {
                Console.WriteLine($"(!) TRŪKSTA {(wallet-cartTotal)*-1} Eur");
            }
        }

        public static void RemoveFromCart()
        {
            int indexer = 1;

            foreach (var item in cartList)
            {
                Console.WriteLine($"Prekė #{indexer++}: {item}");
            }
            Console.WriteLine($"Pasirinkite šalinamos prekės indeksą");
            if (!int.TryParse(Console.ReadLine(), out int indexToRemove)) { Console.WriteLine("(!) Neteisinga įvestis"); }

            cartList.RemoveAt(indexToRemove-1);
            cartTotal -= moneyOperations[indexToRemove - 1];
            moneyOperations.RemoveAt(indexToRemove-1);
        }

        public static void CheckWallet()
        {
            if (wallet-cartTotal < 0)
            {
                Console.WriteLine($"(!) TRŪKSTA {(wallet - cartTotal) * -1} Eur");
                Console.WriteLine($"    GRĮŽTATE -> MENiU:  ");
                Console.WriteLine($"(?) padidinkite piniginę");
                Console.WriteLine($"(?) arba šalinkite prekes");
                StoreFrontMenu.Menu();
            }
        }

        public static void ConstructChequeString()
        {
            int index = 1;
            foreach (var item in cartList)
            {
                Cheque += $"\n Prekė #{index++}: {item}";
            }
            Cheque += "";
            Cheque += $"\nMokėtina suma: {cartTotal} Eur";
            Cheque += "";
            Cheque += $"\nPirkinio data: {DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}, " +
                                                             $"{DateTime.Now.Hour}:{DateTime.Now.Minute} ";
            Cheque += "";
        }
        #endregion
    }
}