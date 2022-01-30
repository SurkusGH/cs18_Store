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
            if (!decimal.TryParse(Console.ReadLine(), out decimal walletInput)) { Console.WriteLine("(!) Neteisinga įvestis"); }
            while (true)
            {
                Console.WriteLine("Meniu");
                Console.WriteLine("Galimos parinktys");
                Console.WriteLine("[1] Parodyti prekes");
                Console.WriteLine("[2] Rinktis prekes");
                Console.WriteLine("[3] Krepšelis");

                int menuInput = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menuInput)
                {
                    case 1:
                        Index_1();
                        break;
                    case 2:
                        Index_2();
                        break;
                    case 3:
                        Index_3();
                        break;
                    case 4:
                        Index_4();
                        break;
                }
            }
            public static void Meniu()
            {
                while (true)                                    // <-- MAIN MENU - nesibaigiantis loop'as
                {
                    Console.WriteLine("[1] Kurti bilietus");
                    Console.WriteLine("[2] Parduoti bilietus");
                    Console.WriteLine("[3] Statistika");
                    Console.WriteLine("[4] Operacijos");

                    int input = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (input)
                    {
                        case 1:
                            Create();
                            break;
                        case 2:
                            Sell();
                            break;
                        case 3:
                            Statystics();
                            break;
                        case 4:
                            Operations();
                            break;
                    }
                }
            }

            public static void Create()
            {
                Console.WriteLine("[1] Kurti bilietus -> [1] Po €10"); // <-- visur kur matomas simbolis "->" iš esmės yra
                Console.WriteLine("                      [2] Po €20"); //     sintaksinis cukrus. Galima way paprasčiau padaryti
                Console.WriteLine("                      [3] Po €30");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        CreateTicket10();
                        break;
                    case 2:
                        CreateTicket20();
                        break;
                    case 3:
                        CreateTicket30();
                        break;
                }
            }

            public static List<int> CreateTicket10()
            {
                Console.WriteLine("[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] ");
                Console.WriteLine("                      [2] Po €20");
                Console.WriteLine("                      [3] Po €30");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();

                for (int i = 0; i < input; i++)
                {
                    tickets10.Add(i);
                }
                Console.WriteLine($"[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets10.Count}");
                Console.WriteLine("                      [2] Po €20");
                Console.WriteLine("                      [3] Po €30");

                transactions.Add($" sukurta €10 x {input.ToString()} vnt.");

                return tickets10;
            }

            public static List<int> CreateTicket20()
            {
                Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
                Console.WriteLine("                      [2] Po €20 -> [Skaičius] ");
                Console.WriteLine("                      [3] Po €30");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                for (int i = 0; i < input; i++)
                {
                    tickets20.Add(i);
                }
                Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
                Console.WriteLine($"                      [2] Po €20 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets20.Count}");
                Console.WriteLine("                      [3] Po €30");

                transactions.Add($" sukurta €20 x {input.ToString()} vnt.");

                return tickets20;
            }

            public static List<int> CreateTicket30()
            {
                Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
                Console.WriteLine("                      [2] Po €20");
                Console.WriteLine("                      [3] Po €30 -> [Skaičius] ");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                for (int i = 0; i < input; i++)
                {
                    tickets30.Add(i);
                }
                Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
                Console.WriteLine("                      [2] Po €20");
                Console.WriteLine($"                      [3] Po €30 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets30.Count}");

                transactions.Add($" sukurta €30 x {input.ToString()} vnt.");

                return tickets30;

            }

            public static void Sell()
            {

                Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
                Console.WriteLine("                         [2] Po €20");
                Console.WriteLine("                         [3] Po €30");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (input)
                {
                    case 1:
                        SellTickets10();
                        break;
                    case 2:
                        SellTickets20();
                        break;
                    case 3:
                        SellTickets30();
                        break;
                }
            }

            public static List<int> SellTickets10()
            {
                Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10 -> [Skaičius] ");
                Console.WriteLine("                         [2] Po €20");
                Console.WriteLine("                         [3] Po €30");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();

                for (int i = 0; i < input; i++)
                {
                    sold10.Add(i);
                }
                Console.WriteLine($"[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] -> parduota {input} vnt., esamas {TicketBalance()}: {tickets10.Count - sold10.Count} vnt.");
                Console.WriteLine("                      [2] Po €20");
                Console.WriteLine("                      [3] Po €30");

                transactions.Add($"parduota €10 x {input.ToString()} vnt.");

                return sold10;
            }

            public static List<int> SellTickets20()
            {
                Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
                Console.WriteLine("                         [2] Po €20 -> [Skaičius] ");
                Console.WriteLine("                         [3] Po €30");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();

                for (int i = 0; i < input; i++)
                {
                    sold20.Add(i);
                }
                Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
                Console.WriteLine($"                      [2] Po €20 -> [Skaičius] -> parduota {input} vnt., esamas likutis: {tickets20.Count - sold20.Count} vnt.");
                Console.WriteLine("                      [3] Po €30");

                transactions.Add($"parduota €20 x {input.ToString()} vnt.");

                return sold20;
            }

            public static List<int> SellTickets30()
            {
                Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
                Console.WriteLine("                         [2] Po €20");
                Console.WriteLine("                         [3] Po €30 -> [Skaičius] ");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();

                for (int i = 0; i < input; i++)
                {
                    sold30.Add(i);
                }
                Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
                Console.WriteLine("                      [2] Po €20");
                Console.WriteLine($"                      [3] Po €30 -> [Skaičius] -> parduota {input} vnt., esamas likutis: {tickets30.Count - sold30.Count} vnt.");

                transactions.Add($"parduota €30 x {input.ToString()} vnt.");

                return sold30;
            }

            public static void Statystics()
            {
                Console.WriteLine($"Bilietų po €10 sukurta: {tickets10.Count} vnt.;");
                Console.WriteLine($"              parduota: {sold10.Count} vnt.;");
                Console.WriteLine($"               likutis: {tickets10.Count - sold10.Count} vnt.;");
                Console.WriteLine("");
                Console.WriteLine($"Bilietų po €20 sukurta: {tickets20.Count} vnt.;");
                Console.WriteLine($"              parduota: {sold20.Count} vnt.;");
                Console.WriteLine($"               likutis: {tickets20.Count - sold20.Count} vnt.;");
                Console.WriteLine("");
                Console.WriteLine($"Bilietų po €30 sukurta: {tickets30.Count} vnt.;");
                Console.WriteLine($"              parduota: {sold30.Count} vnt.;");
                Console.WriteLine($"               likutis: {tickets30.Count - sold30.Count} vnt.;");
            }

            public static void Operations()
            {
                Console.WriteLine("Paskutinės konsolės operacijos: ");
                foreach (var unit in transactions)
                {
                    Console.WriteLine(unit);
                }
                Console.WriteLine();
            }
        }
    }
}
