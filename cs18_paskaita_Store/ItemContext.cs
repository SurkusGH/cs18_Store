using cs18_paskaita_Store.Goods;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store
{
    public class ItemContext : DbContext
    {
        public DbSet<Drinkables> Drinks { get; set; }
        public DbSet<Greens> Vegetables { get; set; }
        public DbSet<Meats> Meats { get; set; }
        public DbSet<Sweets> Candies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Server=localhost;Database=dvs05_lecture_Store;Trusted_Connection=True;");
    }
}
