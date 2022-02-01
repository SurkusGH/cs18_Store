using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cs18_paskaita_Store.Goods;

namespace cs18_paskaita_Store.Functionality
{
    public class CSV_Handler
    {
        #region SWEETS handling - HARDCODED
        public void WriteSweetsDataToCSV(string coordinates, Sweets sweets) // <-- Metodas nenaudojamas
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{sweets.Carbohydrates}, " +
                                                      $"{sweets.Price}, " +
                                                      $"{sweets.Barcode}, " +
                                                      $"{sweets.Weight}";
            File.AppendAllText(path, DataString);

            //string appendText = "This is text for Column 1" + comma + "This is text for Column 2" + comma + "This is text for Column 3" + comma + Environment.NewLine;
        }
        public List<Sweets> ReadSweetsCSVData(string CSVCoordinates)
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{CSVCoordinates}.csv";
            // Open the file to read from.
            var CSVLineReader = new StreamReader(path);

            //var sweetsParcel = new Sweets();
            var sweetsRepository = new List<Sweets>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(", ");

                sweetsRepository.Add(ItemParserSweets(valueCache));
            }
            return sweetsRepository;
        }
        public Sweets ItemParserSweets(string[] valueCache)
        {
            var sweetsParcel = new Sweets();
            sweetsParcel.Carbohydrates = float.Parse(valueCache[0].ToString());
            sweetsParcel.Price = decimal.Parse(valueCache[1].ToString());
            sweetsParcel.Barcode = float.Parse(valueCache[2].ToString());
            sweetsParcel.Weight = float.Parse(valueCache[3].ToString());
            
            return sweetsParcel;
        }
        #endregion


        #region MEATS handling - HARDCODED
        public void WriteMeatsDataToCSV(string coordinates, Meats meats) // <-- Metodas nenaudojamas
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{meats.Proteins}, " +
                                                      $"{meats.Price}, " +
                                                      $"{meats.Barcode}, " +
                                                      $"{meats.Weight}";
            File.AppendAllText(path, DataString);

            //string appendText = "This is text for Column 1" + comma + "This is text for Column 2" + comma + "This is text for Column 3" + comma + Environment.NewLine;
        }
        public List<Meats> ReadMeatsCSVData(string CSVCoordinates)
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{CSVCoordinates}.csv";
            // Open the file to read from.
            var CSVLineReader = new StreamReader(path);

            //var meatsParcel = new Meats();
            var meatsRepository = new List<Meats>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(", ");

                meatsRepository.Add(ItemParserMeats(valueCache));
            }
            return meatsRepository;
        }
        public Meats ItemParserMeats(string[] valueCache)
        {
            var meatsParcel = new Meats();
            meatsParcel.Proteins = float.Parse(valueCache[0].ToString());
            meatsParcel.Price = decimal.Parse(valueCache[1].ToString());
            meatsParcel.Barcode = float.Parse(valueCache[2].ToString());
            meatsParcel.Weight = float.Parse(valueCache[3].ToString());

            return meatsParcel;
        }
        #endregion


        #region GREENS handling - HARDCODED
        public void WriteGreensDataToCSV(string coordinates, Greens greens) // <-- Metodas nenaudojamas
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{greens.Fibers}, " +
                                                      $"{greens.Price}, " +
                                                      $"{greens.Barcode}, " +
                                                      $"{greens.Weight}";
            File.AppendAllText(path, DataString);

            //string appendText = "This is text for Column 1" + comma + "This is text for Column 2" + comma + "This is text for Column 3" + comma + Environment.NewLine;
        }
        public List<Greens> ReadGreensCSVData(string CSVCoordinates)
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{CSVCoordinates}.csv";
            // Open the file to read from.
            var CSVLineReader = new StreamReader(path);

            //var meatsParcel = new Meats();
            var greensRepository = new List<Greens>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(", ");

                greensRepository.Add(ItemParserGreens(valueCache));
            }
            return greensRepository;
        }
        public Greens ItemParserGreens(string[] valueCache)
        {
            var greensParcel = new Greens();
            greensParcel.Fibers = float.Parse(valueCache[0].ToString());
            greensParcel.Price = decimal.Parse(valueCache[1].ToString());
            greensParcel.Barcode = float.Parse(valueCache[2].ToString());
            greensParcel.Weight = float.Parse(valueCache[3].ToString());

            return greensParcel;
        }
        #endregion


        #region DRINKABLES handling - HARDCODED
        public void WriteDrinkablesDataToCSV(string coordinates, Drinkables drinkables)  // <-- Metodas nenaudojamas
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{drinkables.Volume}, " +
                                                      $"{drinkables.Price}, " +
                                                      $"{drinkables.Barcode}, " +
                                                      $"{drinkables.Weight}";
            File.AppendAllText(path, DataString);

            //string appendText = "This is text for Column 1" + comma + "This is text for Column 2" + comma + "This is text for Column 3" + comma + Environment.NewLine;
        }
        public List<Drinkables> ReadDrinkablesCSVData(string CSVCoordinates)
        {
            string path = $@"D:\GitHub\cs18_paskaita_Store\cs18_paskaita_Store\CSV_dir\{CSVCoordinates}.csv";
            // Open the file to read from.
            var CSVLineReader = new StreamReader(path);

            //var meatsParcel = new Meats();
            var drinkablesRepository = new List<Drinkables>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(", ");

                drinkablesRepository.Add(ItemParserDrinkables(valueCache));
            }
            return drinkablesRepository;
        }
        public Drinkables ItemParserDrinkables(string[] valueCache)
        {
            var drinkablesParcel = new Drinkables();
            drinkablesParcel.Volume = float.Parse(valueCache[0].ToString());
            drinkablesParcel.Price = decimal.Parse(valueCache[1].ToString());
            drinkablesParcel.Barcode = float.Parse(valueCache[2].ToString());
            drinkablesParcel.Weight = float.Parse(valueCache[3].ToString());

            return drinkablesParcel;
        }
        #endregion

    }
}
