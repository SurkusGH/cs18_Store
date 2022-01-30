using cs18_paskaita_Store.Functionality;
using cs18_paskaita_Store.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class SweetsRepository
    {
        public List<Sweets> SweetsList { get; set; }

        public SweetsRepository()
        {
            SweetsList = new List <Sweets>();
        }
        public List<Sweets> LoadSweetsCSVData()
        {
            var handler = new CSV_Handler();
            SweetsList = handler.ReadSweetsCSVData("Sweets");
            return SweetsList;
        }
        public void AddSweetToCSV(Sweets sweet)
        {
            var handler = new CSV_Handler();
            handler.WriteSweetsDataToCSV("Sweets", sweet);
        }
    }
}
