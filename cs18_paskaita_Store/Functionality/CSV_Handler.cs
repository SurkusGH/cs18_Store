using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Functionality
{
    internal class CSV_Handler
    {
        public void TransferToCSV(string coordinates)
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{coordinates}.csv";

            // Set the variable "delimiter" to ", ".
            string comma = ", ";

            //// This text is added only once to the file.
            //if (!File.Exists(path))
            //{
            //    // Create a file to write to.
            //    string createText = "Column 1 Name" + comma + "Column 2 Name" + comma + "Column 3 Name" + comma + Environment.NewLine;
            //    File.WriteAllText(path, createText);
            //}

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is text for Column 1" + comma + "This is text for Column 2" + comma + "This is text for Column 3" + comma + Environment.NewLine;
            File.AppendAllText(path, appendText);
        }
        public void TransferFromCSV(string coordinates)
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{coordinates}.csv";
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
