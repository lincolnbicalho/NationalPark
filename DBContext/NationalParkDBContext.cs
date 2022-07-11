using Microsoft.EntityFrameworkCore;
using NationalPark.Models;

namespace NationalPark
{
    public class NationalParkDBContext: DbContext
    {

        public DbSet<Park> Parks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\MSSQLSERVER2016;Initial Catalog=NationalParkDB;Persist Security Info=True;User ID=sa;Password=123456");
        }
    }
}
