using cs18_paskaita_Store.Functionality;
using System.Collections.Generic;
using System.Linq;

namespace cs18_paskaita_Store
{
    public class GreensRepository
    {
        public List<Greens> GreensList { get; set; }

        public GreensRepository()
        {
            GreensList = new List<Greens>();
        }
        public List<Greens> LoadGreensCSVData()
        {
            //var handler = new CSV_Handler();
            //GreensList = handler.ReadGreensCSVData("Greens");
            //return GreensList;

            using (var dbContext = new ItemContext())
            {
                var query = dbContext.Vegetables.OrderBy(b => b.Barcode);
                GreensList.AddRange(query.ToList());
            };
            return GreensList;
        }
        public void AddGreensToCSV(Greens greens)
        {
            var handler = new CSV_Handler();
            handler.WriteGreensDataToCSV("Greens", greens);
        }
    }
}
