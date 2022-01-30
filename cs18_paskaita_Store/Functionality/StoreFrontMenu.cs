using cs18_paskaita_Store.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class StoreFrontMenu
    {

        public static void Menu()
        {
            Console.WriteLine("Piniginė: __ Eur");
            if (!decimal.TryParse(Console.ReadLine(), out decimal walletInput)) { Console.WriteLine("(!) Neteisinga įvestis"); }
            while (true)
            {
                Console.WriteLine("Meniu");
                Console.WriteLine("Galimos parinktys");
                Console.WriteLine("[1] Katalogas");
                Console.WriteLine("[2] Rinktis prekes");
                Console.WriteLine("[3] Krepšelis");

                if (!int.TryParse(Console.ReadLine(), out int menuInput)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                Console.Clear();

                switch (menuInput)
                {
                    case 1:
                        Catalogue();
                        break;
                    case 2:
                        AddToCart();
                        break;
                    case 3:
                        CartAndChequeSystem.PrintCart();
                        break;
                    case 4:
                        MailingSystem.SendEmail();
                        break;
                }
            }

            static void Catalogue()
            {
                Console.WriteLine("[1] Parodyti prekes -> [1] Saldumynai");
                Console.WriteLine("                       [2] Mėsos produktai");
                Console.WriteLine("                       [3] Daržovės");
                Console.WriteLine("                       [4] Gėrimai");
                Console.WriteLine("                       [5] Visas katalogas");
                if (!int.TryParse(Console.ReadLine(), out int input)) { Console.WriteLine("(!) Neteisinga įvestis"); }

                switch (input)
                {
                    case 1:
                        DataPrinting.PrintProductData_Sweets();
                        break;
                    case 2:
                        DataPrinting.PrintProductData_Meats();
                        break;
                    case 3:
                        DataPrinting.PrintProductData_Greens();
                        break;
                    case 4:
                        DataPrinting.PrintProductData_Drinkables();
                        break;
                    case 5:
                        DataPrinting.PrintAllCVS_dir();
                        break;
                }
            }
            static void AddToCart()
            {
                Console.WriteLine("                       [1] Saldumynai");
                Console.WriteLine("[2] Rinktis prekes  -> [2] Mėsos produktai");
                Console.WriteLine("                       [3] Daržovės");
                Console.WriteLine("                       [4] Gėrimai");
                Console.WriteLine("                       [5] Visas katalogas");
                Console.WriteLine("                       [6] Grįžti į pagrindinį meniu");
                if (!int.TryParse(Console.ReadLine(), out int input)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                Console.Clear();
                switch (input)
                {
                    case 1:
                        DataPrinting.PrintProductData_Sweets_Mini();
                        if (!int.TryParse(Console.ReadLine(), out int index)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                        CartAndChequeSystem.AddSweetsToCartList(index - 1);
                        break;
                    case 2:
                        DataPrinting.PrintProductData_Meats_Mini();
                        if (!int.TryParse(Console.ReadLine(), out int index2)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                        CartAndChequeSystem.AddMeatsToCartList(index2 - 1);
                        break;
                    case 3:
                        DataPrinting.PrintProductData_Greens_Mini();
                        if (!int.TryParse(Console.ReadLine(), out int index3)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                        CartAndChequeSystem.AddGreensToCartList(index3 - 1);
                        break;
                    case 4:
                        DataPrinting.PrintProductData_Drinkables_Mini();
                        if (!int.TryParse(Console.ReadLine(), out int index4)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                        CartAndChequeSystem.AddGreensToCartList(index4 - 1);
                        break;
                    case 5:
                        DataPrinting.PrintAllCVS_dir();
                        break;
                    case 6:
                        Menu();
                        break;
                }
            }
        }
    }
}
