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
                        //case 4:
                        //    Index_4();
                        //    break;
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
                            CartAndChequeSystem.AddSweetsToCartList(index-1);
                        break;
                        case 2:
                            DataPrinting.PrintProductData_Meats_Mini();
                            if (!int.TryParse(Console.ReadLine(), out int index2)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                            CartAndChequeSystem.AddMeatsToCartList(index2-1);
                        break;
                        case 3:
                            DataPrinting.PrintProductData_Greens_Mini();
                            if (!int.TryParse(Console.ReadLine(), out int index3)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                            CartAndChequeSystem.AddGreensToCartList(index3-1);
                        break;
                        case 4:
                            DataPrinting.PrintProductData_Drinkables_Mini();
                        if (!int.TryParse(Console.ReadLine(), out int index4)) { Console.WriteLine("(!) Neteisinga įvestis"); }
                        CartAndChequeSystem.AddGreensToCartList(index4-1);
                        break;
                        case 5:
                            DataPrinting.PrintAllCVS_dir();
                            break;
                        case 6:
                            Menu();
                            break;
                    }
            }
            //public static List<int> CreateTicket10()
            //{
            //    Console.WriteLine("[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] ");
            //    Console.WriteLine("                      [2] Po €20");
            //    Console.WriteLine("                      [3] Po €30");
            //    int input = int.Parse(Console.ReadLine());
            //    Console.Clear();

            //    for (int i = 0; i < input; i++)
            //    {
            //        tickets10.Add(i);
            //    }
            //    Console.WriteLine($"[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets10.Count}");
            //    Console.WriteLine("                      [2] Po €20");
            //    Console.WriteLine("                      [3] Po €30");

            //    transactions.Add($" sukurta €10 x {input.ToString()} vnt.");

            //    return tickets10;
            //}

            //public static List<int> CreateTicket20()
            //{
            //    Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            //    Console.WriteLine("                      [2] Po €20 -> [Skaičius] ");
            //    Console.WriteLine("                      [3] Po €30");
            //    int input = int.Parse(Console.ReadLine());
            //    Console.Clear();
            //    for (int i = 0; i < input; i++)
            //    {
            //        tickets20.Add(i);
            //    }
            //    Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            //    Console.WriteLine($"                      [2] Po €20 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets20.Count}");
            //    Console.WriteLine("                      [3] Po €30");

            //    transactions.Add($" sukurta €20 x {input.ToString()} vnt.");

            //    return tickets20;
            //}

            //public static List<int> CreateTicket30()
            //{
            //    Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            //    Console.WriteLine("                      [2] Po €20");
            //    Console.WriteLine("                      [3] Po €30 -> [Skaičius] ");
            //    int input = int.Parse(Console.ReadLine());
            //    Console.Clear();
            //    for (int i = 0; i < input; i++)
            //    {
            //        tickets30.Add(i);
            //    }
            //    Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            //    Console.WriteLine("                      [2] Po €20");
            //    Console.WriteLine($"                      [3] Po €30 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets30.Count}");

            //    transactions.Add($" sukurta €30 x {input.ToString()} vnt.");

            //    return tickets30;

            //}

            //public static void Sell()
            //{

            //    Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            //    Console.WriteLine("                         [2] Po €20");
            //    Console.WriteLine("                         [3] Po €30");
            //    int input = int.Parse(Console.ReadLine());
            //    Console.Clear();
            //    switch (input)
            //    {
            //        case 1:
            //            SellTickets10();
            //            break;
            //        case 2:
            //            SellTickets20();
            //            break;
            //        case 3:
            //            SellTickets30();
            //            break;
            //    }
            //}

            //public static List<int> SellTickets10()
            //{
            //    Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10 -> [Skaičius] ");
            //    Console.WriteLine("                         [2] Po €20");
            //    Console.WriteLine("                         [3] Po €30");
            //    int input = int.Parse(Console.ReadLine());
            //    Console.Clear();

            //    for (int i = 0; i < input; i++)
            //    {
            //        sold10.Add(i);
            //    }
            //    Console.WriteLine($"[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] -> parduota {input} vnt., esamas {TicketBalance()}: {tickets10.Count - sold10.Count} vnt.");
            //    Console.WriteLine("                      [2] Po €20");
            //    Console.WriteLine("                      [3] Po €30");

            //    transactions.Add($"parduota €10 x {input.ToString()} vnt.");

            //    return sold10;
            //}

            //public static List<int> SellTickets20()
            //{
            //    Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            //    Console.WriteLine("                         [2] Po €20 -> [Skaičius] ");
            //    Console.WriteLine("                         [3] Po €30");
            //    int input = int.Parse(Console.ReadLine());
            //    Console.Clear();

            //    for (int i = 0; i < input; i++)
            //    {
            //        sold20.Add(i);
            //    }
            //    Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            //    Console.WriteLine($"                      [2] Po €20 -> [Skaičius] -> parduota {input} vnt., esamas likutis: {tickets20.Count - sold20.Count} vnt.");
            //    Console.WriteLine("                      [3] Po €30");

            //    transactions.Add($"parduota €20 x {input.ToString()} vnt.");

            //    return sold20;
            //}

            //public static List<int> SellTickets30()
            //{
            //    Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            //    Console.WriteLine("                         [2] Po €20");
            //    Console.WriteLine("                         [3] Po €30 -> [Skaičius] ");
            //    int input = int.Parse(Console.ReadLine());
            //    Console.Clear();

            //    for (int i = 0; i < input; i++)
            //    {
            //        sold30.Add(i);
            //    }
            //    Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            //    Console.WriteLine("                      [2] Po €20");
            //    Console.WriteLine($"                      [3] Po €30 -> [Skaičius] -> parduota {input} vnt., esamas likutis: {tickets30.Count - sold30.Count} vnt.");

            //    transactions.Add($"parduota €30 x {input.ToString()} vnt.");

            //    return sold30;
            //}

            //public static void Statystics()
            //{
            //    Console.WriteLine($"Bilietų po €10 sukurta: {tickets10.Count} vnt.;");
            //    Console.WriteLine($"              parduota: {sold10.Count} vnt.;");
            //    Console.WriteLine($"               likutis: {tickets10.Count - sold10.Count} vnt.;");
            //    Console.WriteLine("");
            //    Console.WriteLine($"Bilietų po €20 sukurta: {tickets20.Count} vnt.;");
            //    Console.WriteLine($"              parduota: {sold20.Count} vnt.;");
            //    Console.WriteLine($"               likutis: {tickets20.Count - sold20.Count} vnt.;");
            //    Console.WriteLine("");
            //    Console.WriteLine($"Bilietų po €30 sukurta: {tickets30.Count} vnt.;");
            //    Console.WriteLine($"              parduota: {sold30.Count} vnt.;");
            //    Console.WriteLine($"               likutis: {tickets30.Count - sold30.Count} vnt.;");
            //}

            //public static void Operations()
            //{
            //    Console.WriteLine("Paskutinės konsolės operacijos: ");
            //    foreach (var unit in transactions)
            //    {
            //        Console.WriteLine(unit);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
