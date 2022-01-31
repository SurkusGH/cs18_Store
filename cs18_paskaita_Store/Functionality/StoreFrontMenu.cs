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
            Console.WriteLine($"Piniginė: __ Eur");
            decimal walletInput = InputValidationSystem.InputValidation();
            CartAndChequeSystem.wallet = walletInput; // <-- pasikviečiu klasės CartAndChequeSystem "Global'ą",
                                                      //     kuris laikys sumas, etc.
            #region MENU
            while (true)
            {
                Console.WriteLine($"MENIU");
                Console.WriteLine($"Galimos parinktys");
                Console.WriteLine($"[1] Katalogas");
                Console.WriteLine($"[2] Rinktis prekes");
                Console.WriteLine($"[3] Krepšelis");
                CartAndChequeSystem.ShowBalance();
                DataPrinting.PrintCart();

                int input = InputValidationSystem.InputValidation(3);
                Console.Clear();

                switch (input)
                {
                    case 1:
                        Catalogue();
                        break;
                    case 2:
                        AddToCart();
                        break;
                    case 3:
                        PurchaseSubMenu();
                        break;
                    //case 4:
                    //    MailingSystem.SendEmail();
                    //    break;
                }
            }
            #endregion

            #region SUBMENU - Rodyti prekes
            static void Catalogue()
            {
                Console.WriteLine($"[1] Parodyti prekes -> [1] Saldumynai");
                Console.WriteLine($"                    -> [2] Mėsos produktai");
                Console.WriteLine($"                    -> [3] Daržovės");
                Console.WriteLine($"                    -> [4] Gėrimai");
                Console.WriteLine($"                    -> [5] Visas katalogas");
                CartAndChequeSystem.ShowBalance();
                DataPrinting.PrintCart();

                //if (!int.TryParse(Console.ReadLine(), out int input)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                int input = InputValidationSystem.InputValidation(5);
                Console.Clear();
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
            #endregion

            #region SUBMENU - Rintkis prekes
            static void AddToCart()
            {
                Console.WriteLine($"                    -> [1] Saldumynai");
                Console.WriteLine($"[2] Rinktis prekes  -> [2] Mėsos produktai");
                Console.WriteLine($"                    -> [3] Daržovės");
                Console.WriteLine($"                    -> [4] Gėrimai");
                CartAndChequeSystem.ShowBalance();
                DataPrinting.PrintCart();

                int input = InputValidationSystem.InputValidation(4);
                Console.Clear();
                switch (input)
                {
                    case 1:
                        DataPrinting.ProductSelectorSubMenu_Sweets();
                        CartAndChequeSystem.ShowBalance();
                        DataPrinting.PrintCart();
                        int index = InputValidationSystem.InputValidation(4);
                        Console.Clear();
                        CartAndChequeSystem.AddSweetsToCartList(index - 1);
                        break;
                    case 2:
                        DataPrinting.ProductSelectorSubMenu_Meats();
                        CartAndChequeSystem.ShowBalance();
                        DataPrinting.PrintCart();
                        int index2 = InputValidationSystem.InputValidation(4);
                        Console.Clear();
                        CartAndChequeSystem.AddMeatsToCartList(index2 - 1);
                        break;
                    case 3:
                        DataPrinting.ProductSelectorSubMenu_Greens();
                        CartAndChequeSystem.ShowBalance();
                        DataPrinting.PrintCart();
                        int index3 = InputValidationSystem.InputValidation(4);
                        Console.Clear();
                        CartAndChequeSystem.AddGreensToCartList(index3 - 1);
                        break;
                    case 4:
                        DataPrinting.ProductSelectorSubMenu_Drinkables();
                        CartAndChequeSystem.ShowBalance();
                        DataPrinting.PrintCart();
                        int index4 = InputValidationSystem.InputValidation(4);
                        Console.Clear();
                        CartAndChequeSystem.AddGreensToCartList(index4 - 1);
                        break;
                }
            }
            #endregion

            #region SUBMENU - Krepšelis
            static void PurchaseSubMenu()
            {
                Console.WriteLine($"Meniu");
                Console.WriteLine($"Galimos parinktys");
                Console.WriteLine($"[1] Katalogas");
                Console.WriteLine($"[2] Rinktis prekes");
                Console.WriteLine($"[3] Krepšelis        -> [1] Parodyti krepšelį");
                Console.WriteLine($"                     -> [2] Šalinti iš krepšelio");
                Console.WriteLine($"                     -> [3] Tvirtinti pirkimą");
                CartAndChequeSystem.ShowBalance();
                DataPrinting.PrintCart();

                int menuInput = InputValidationSystem.InputValidation(3);
                Console.Clear();

                switch (menuInput)
                {
                    case 1:
                        DataPrinting.PrintCartAndWallet();
                        break;
                    case 2:
                        CartAndChequeSystem.RemoveFromCart();
                        break;
                    case 3:
                        CartAndChequeSystem.CheckWallet();
                        MailingSystem.MIMEMessage();
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion
        }
    }
}
