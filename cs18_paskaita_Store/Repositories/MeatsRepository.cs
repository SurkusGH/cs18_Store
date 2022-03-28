using cs18_paskaita_Store.Functionality;
using cs18_paskaita_Store.Goods;
using System.Collections.Generic;
using System.Linq;

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
        public List<Meats> LoadMeats_DbData()
        {
            using (var dbContext = new ItemContext())
            {
                var query = dbContext.Meats.OrderBy(b => b.Barcode);
                MeatsList.AddRange(query.ToList());
            };
            return MeatsList;
        }

        public void AddMeatsToCSV(Meats meat)
        {
            var handler = new CSV_Handler();
            handler.WriteMeatsDataToCSV("Meats", meat);
        }
    }
}
