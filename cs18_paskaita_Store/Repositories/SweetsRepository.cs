using cs18_paskaita_Store.Functionality;
using cs18_paskaita_Store.Goods;
using System.Collections.Generic;
using System.Linq;

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
        public List<Sweets> LoadSweets_DbData()
        {
            using (var dbContext = new ItemContext())
            {
                var query = dbContext.Candies.OrderBy(b => b.Barcode);
                SweetsList.AddRange(query.ToList());
            };
            return SweetsList;
        }
        public void AddSweetToCSV(Sweets sweet)
        {
            var handler = new CSV_Handler();
            handler.WriteSweetsDataToCSV("Sweets", sweet);
        }
    }
}
