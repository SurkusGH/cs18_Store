using System;
using System.Collections.Generic;

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

            for (int i = 0; i < 4; i++)
            {
                if (i == index)
                {
                    cartList.Add($"{itemIdentifier.ItemIdentifier(sweetsRepository.LoadSweets_DbData()[index].Barcode)} už {sweetsRepository.LoadSweets_DbData()[index].Price} Eur");
                }
            }
            cartTotal += sweetsRepository.LoadSweets_DbData()[index].Price;
            moneyOperations.Add(sweetsRepository.LoadSweets_DbData()[index].Price);
        }
        static public void AddMeatsToCartList(int index)
        {
            var meatsRepository = new MeatsRepository();
            var itemIdentifier = new BarcodeAuthenticator();

            for (int i = 0; i < 4; i++)
            {
                if (i == index)
                {
                    cartList.Add($"{itemIdentifier.ItemIdentifier(meatsRepository.LoadMeats_DbData()[index].Barcode)} už {meatsRepository.LoadMeats_DbData()[index].Price} Eur");
                }
            }
            cartTotal += meatsRepository.LoadMeats_DbData()[index].Price;
            moneyOperations.Add(meatsRepository.LoadMeats_DbData()[index].Price);
        }
        static public void AddGreensToCartList(int index)
        {
            var greensRepository = new GreensRepository();
            var itemIdentifier = new BarcodeAuthenticator();

            for (int i = 0; i < 4; i++)
            {
                if (i == index)
                {
                    cartList.Add($"{itemIdentifier.ItemIdentifier(greensRepository.LoadGreens_DbData()[index].Barcode)} už {greensRepository.LoadGreens_DbData()[index].Price} Eur");
                }
            }
            cartTotal += greensRepository.LoadGreens_DbData()[index].Price;
            moneyOperations.Add(greensRepository.LoadGreens_DbData()[index].Price);
        }
        static public void AddDrinkablesToCartList(int index)
        {
            var drinkablesRepository = new DrinkablesRepository();
            var itemIdentifier = new BarcodeAuthenticator();

            for (int i = 0; i < 4; i++)
            {
                if (i == index)
                {
                    cartList.Add($"{itemIdentifier.ItemIdentifier(drinkablesRepository.LoadDrinkables_DbData()[index].Barcode)} už {drinkablesRepository.LoadDrinkables_DbData()[index].Price} Eur");
                }
            }
            cartTotal += drinkablesRepository.LoadDrinkables_DbData()[index].Price;
            moneyOperations.Add(drinkablesRepository.LoadDrinkables_DbData()[index].Price);
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


        public static void ShowCurrentCartWithIndexing()
        {
            int indexer = 1;

            foreach (var item in cartList)
            {
                Console.WriteLine($"Prekė #{indexer++}: {item}");
            }
        }
        public static void RemoveFromCart(int indexToRemove)
        {
            cartList.RemoveAt(indexToRemove - 1);
            cartTotal -= moneyOperations[indexToRemove - 1];
            moneyOperations.RemoveAt(indexToRemove - 1);
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