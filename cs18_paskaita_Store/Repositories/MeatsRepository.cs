using cs18_paskaita_Store.Functionality;
using cs18_paskaita_Store.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class MeatsRepository
    {
        public List<Meats> MeatsList { get; set; }

        public MeatsRepository()
        {
            MeatsList = new List<Meats>();
        }
        public List<Meats> LoadMeatsCSVData()
        {
            var handler = new CSV_Handler();
            MeatsList = handler.ReadMeatsCSVData("Meats");
            return MeatsList;
        }
        public void AddMeatsToCSV(Meats meat)
        {
            var handler = new CSV_Handler();
            handler.WriteMeatsDataToCSV("Meats", meat);
        }
    }
}
