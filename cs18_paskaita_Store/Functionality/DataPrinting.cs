﻿using System;

namespace cs18_paskaita_Store.Functionality
{
    public class DataPrinting
    {
        #region DETAILED-CONSOLE-UI
        public static void PrintProductData_Sweets()
        {
            var sweetsRepository = new SweetsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in sweetsRepository.LoadSweets_DbData())
            {
                Console.WriteLine($"Produktas: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     turi: {item.Carbohydrates} angliavandeinių");
                Console.WriteLine($" kainuoja: {item.Price} Eur");
                Console.WriteLine($" barkodas: {item.Barcode}");
                Console.WriteLine($"   svoris: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public static void PrintProductData_Meats()
        {
            var meatsRepository = new MeatsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in meatsRepository.LoadMeats_DbData())
            {
                Console.WriteLine($"Produktas: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     turi: {item.Proteins} baltymų");
                Console.WriteLine($" kainuoja: {item.Price} Eur");
                Console.WriteLine($" barkodas: {item.Barcode}");
                Console.WriteLine($"   svoris: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public static void PrintProductData_Greens()
        {
            var greensRepository = new GreensRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in greensRepository.LoadGreens_DbData())
            {
                Console.WriteLine($"Produktas: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"     turi: {item.Fibers} skaidulinių medžiagų");
                Console.WriteLine($" kainuoja: {item.Price} Eur");
                Console.WriteLine($" barkodas: {item.Barcode}");
                Console.WriteLine($"   svoris: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public static void PrintProductData_Drinkables()
        {
            var drinkablesRepository = new DrinkablesRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            foreach (var item in drinkablesRepository.LoadDrinkables_DbData())
            {
                Console.WriteLine($"Produktas: {itemIdentifier.ItemIdentifier(item.Barcode)}");
                Console.WriteLine($"      yra: {item.Volume} ml taros");
                Console.WriteLine($" kainuoja: {item.Price} Eur");
                Console.WriteLine($" barkodas: {item.Barcode}");
                Console.WriteLine($"   svoris: {item.Weight} g");
                Console.WriteLine();
            }
        }
        public static void PrintAllCVS_dir()
        {
            PrintProductData_Sweets();
            PrintProductData_Meats();
            PrintProductData_Greens();
            PrintProductData_Drinkables();
        }
        #endregion

        #region MINI-CONSOLE-UI
        public static void ProductSelectorSubMenu_Sweets()
        {
            var sweetsRepository = new SweetsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            sweetsRepository.LoadSweets_DbData();

            Console.WriteLine($"                    -> [1] Saldumynai -> [1] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[0].Barcode)}");
            Console.WriteLine($"[2] Rinktis prekes                    -> [2] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[1].Barcode)}");
            Console.WriteLine($"                                      -> [3] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[2].Barcode)}");
            Console.WriteLine($"                                      -> [4] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[3].Barcode)}");
            Console.WriteLine($"                                                        ");
        }
        public static void ProductSelectorSubMenu_Meats()
        {
            var meatsRepository = new MeatsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            meatsRepository.LoadMeats_DbData();

            Console.WriteLine($"                                                        ");
            Console.WriteLine($"[2] Rinktis prekes  -> [2] Mėsos produktai -> [1] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[0].Barcode)}");
            Console.WriteLine($"                                           -> [2] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[1].Barcode)}");
            Console.WriteLine($"                                           -> [3] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[2].Barcode)}");
            Console.WriteLine($"                                           -> [4] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[3].Barcode)} ");
        }
        public static void ProductSelectorSubMenu_Greens()
        {
            var greensRepository = new GreensRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            greensRepository.LoadGreens_DbData();

            Console.WriteLine($"                                                        ");
            Console.WriteLine($"[2] Rinktis prekes                                      ");
            Console.WriteLine($"                    -> [3] Daržovės -> [1] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[0].Barcode)}");
            Console.WriteLine($"                                    -> [2] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[1].Barcode)}");
            Console.WriteLine($"                                    -> [3] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[2].Barcode)}");
            Console.WriteLine($"                                    -> [4] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[3].Barcode)}");
            //CartAndChequeSystem.AddSweetsToCartList(input);
        }
        public static void ProductSelectorSubMenu_Drinkables()
        {
            var drinkablessRepository = new DrinkablesRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            drinkablessRepository.LoadDrinkables_DbData();

            Console.WriteLine($"                                                        ");
            Console.WriteLine($"[2] Rinktis prekes                                      ");
            Console.WriteLine($"                                                        ");
            Console.WriteLine($"                    -> [4] Gėrimai -> [1] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[0].Barcode)}");
            Console.WriteLine($"                                   -> [2] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[1].Barcode)}");
            Console.WriteLine($"                                   -> [3] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[2].Barcode)}");
            Console.WriteLine($"                                   -> [4] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[3].Barcode)}");
        }
        #endregion

        #region OTHER PRINTING
        public static void PrintCart()
        {
            if (CartAndChequeSystem.cartList.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Krepšelis:");
                int index = 1;
                foreach (var item in CartAndChequeSystem.cartList)
                {
                    Console.WriteLine($"   Prekė #{index++}: {item}");
                }
            }
        }

        public static void PrintCartAndWallet()
        {
            int index = 1;
            foreach (var item in CartAndChequeSystem.cartList)
            {
                Console.WriteLine($"Prekė #{index++}: {item}");
            }
            Console.WriteLine();
            Console.WriteLine($"Mokėtina suma: {CartAndChequeSystem.cartTotal} Eur");
            Console.WriteLine();
            Console.WriteLine($"     Piniginė: {CartAndChequeSystem.wallet} Eur");
            Console.WriteLine();
            CartAndChequeSystem.CheckBalance();
        }
        public static void PrintCheque() // <-- Šita funkcija niekur nenaudojama. Laiško teksto konstrukciją atlieka 
        {                                //     CartAndChequeSystem.ConstructChequeString()
            int index = 1;
            foreach (var item in CartAndChequeSystem.cartList)
            {
                Console.WriteLine($"Prekė #{index++}: {item}");
            }
            Console.WriteLine();
            Console.WriteLine($"Mokėtina suma: {CartAndChequeSystem.cartTotal} Eur");
            Console.WriteLine();
            Console.WriteLine($"Pirkinio data: {DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}, " +
                                                         $"{DateTime.Now.Hour}:{DateTime.Now.Minute} ");
            Console.WriteLine();
        }

        public static void ThankYouForShopping()
        {
            Console.WriteLine($"Čekis išsiųstas elektroniniu paštu");
            Console.WriteLine($"Ačiū, kad pirkote C# parduotuvėje!");
            InputValidationSystem.ConsoleDelay(3000);
            Console.Clear(); 
            Environment.Exit(0);
        }

        #endregion
    }
}
