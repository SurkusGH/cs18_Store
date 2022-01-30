﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Functionality
{
    public class DataPrinting
    {

        public static void PrintProductData_Sweets()
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
        public static void PrintProductData_Meats()
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
        public static void PrintProductData_Greens()
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
        public static void PrintProductData_Drinkables()
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
        public static void PrintAllCVS_dir()
        {
            PrintProductData_Sweets();
            PrintProductData_Meats();
            PrintProductData_Greens();
            PrintProductData_Drinkables();
        }

        public static void PrintProductData_Sweets_Mini()
        {
            var sweetsRepository = new SweetsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            sweetsRepository.LoadSweetsCSVData();

            Console.WriteLine($"                       [1] Saldumynai                -> [1] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[0].Barcode)}");
            Console.WriteLine($"[2] Rinktis prekes  -> [2] Mėsos produktai              [2] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[1].Barcode)}");
            Console.WriteLine($"                       [3] Daržovės                     [3] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[2].Barcode)}");
            Console.WriteLine($"                       [4] Gėrimai                      [4] {itemIdentifier.ItemIdentifier(sweetsRepository.SweetsList[3].Barcode)}");
            Console.WriteLine($"                       [5] Visas katalogas");
            Console.WriteLine($"                       [6] Grįžti į pagrindinį meniu");
            //CartAndChequeSystem.AddSweetsToCartList(input);
        }
        public static void PrintProductData_Meats_Mini()
        {
            var meatsRepository = new MeatsRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            meatsRepository.LoadMeatsCSVData();

            Console.WriteLine($"                       [1] Saldumynai                   [1] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[0].Barcode)}");
            Console.WriteLine($"[2] Rinktis prekes  -> [2] Mėsos produktai           -> [2] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[1].Barcode)}");
            Console.WriteLine($"                       [3] Daržovės                     [3] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[2].Barcode)}");
            Console.WriteLine($"                       [4] Gėrimai                      [4] {itemIdentifier.ItemIdentifier(meatsRepository.MeatsList[3].Barcode)}");
            Console.WriteLine($"                       [5] Visas katalogas");
            Console.WriteLine($"                       [6] Grįžti į pagrindinį meniu");
            //CartAndChequeSystem.AddSweetsToCartList(input);
        }
        public static void PrintProductData_Greens_Mini()
        {
            var greensRepository = new GreensRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            greensRepository.LoadGreensCSVData();

            Console.WriteLine($"                       [1] Saldumynai                   [1] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[0].Barcode)}");
            Console.WriteLine($"[2] Rinktis prekes  -> [2] Mėsos produktai              [2] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[1].Barcode)}");
            Console.WriteLine($"                       [3] Daržovės                  -> [3] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[2].Barcode)}");
            Console.WriteLine($"                       [4] Gėrimai                      [4] {itemIdentifier.ItemIdentifier(greensRepository.GreensList[3].Barcode)}");
            Console.WriteLine($"                       [5] Visas katalogas");
            Console.WriteLine($"                       [6] Grįžti į pagrindinį meniu");
            //CartAndChequeSystem.AddSweetsToCartList(input);
        }
        public static void PrintProductData_Drinkables_Mini()
        {
            var drinkablessRepository = new DrinkablesRepository();
            var itemIdentifier = new BarcodeAuthenticator();
            drinkablessRepository.LoadDrinkablesCSVData();

            Console.WriteLine($"                       [1] Saldumynai                   [1] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[0].Barcode)}");
            Console.WriteLine($"[2] Rinktis prekes  -> [2] Mėsos produktai              [2] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[1].Barcode)}");
            Console.WriteLine($"                       [3] Daržovės                     [3] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[2].Barcode)}");
            Console.WriteLine($"                       [4] Gėrimai                   -> [4] {itemIdentifier.ItemIdentifier(drinkablessRepository.DrinkablesList[3].Barcode)}");
            Console.WriteLine($"                       [5] Visas katalogas");
            Console.WriteLine($"                       [6] Grįžti į pagrindinį meniu");
            //CartAndChequeSystem.AddSweetsToCartList(input);
        }
    }
}
