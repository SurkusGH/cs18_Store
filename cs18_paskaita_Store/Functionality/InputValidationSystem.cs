using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Functionality
{
    internal class InputValidationSystem
    {
        public static void ConsoleDelay() // <-- planavau naudoti plačiau, bet be to, kad atidėtų console clean'ą, kad spėtų errorą parodyti, nelabai yra kur
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

        public static int InputValidation(int selectorSize)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue > 0 && inputValue <= selectorSize;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue > 0 && inputValue <= selectorSize;
            }
            Console.Clear();
            return inputValue;
        }
        public static int InputValidation() // Overload'as be argumentų
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue > 0;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue > 0;
            }
            Console.Clear();
            return inputValue;
        }
    }
}
