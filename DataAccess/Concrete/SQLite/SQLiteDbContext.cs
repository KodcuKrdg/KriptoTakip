using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.SQLite
{
    public class SQLiteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Hangi Veritabanı ile ilişkindirilecek onu seçiyoruz
        {
            //Trusted_Connection=true kullanıcı adı paralo istemeden
            optionsBuilder.UseSqlite(@"Data Source=SQLiteDb.db");
        }

        public DbSet<Coin> Coins { get; set; }
    }
}
