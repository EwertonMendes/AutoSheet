using Auto_Sheet_BackEnd.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Auto_Sheet_BackEnd.Data
{
    public class AutoSheetContext : DbContext
    {
        public AutoSheetContext(DbContextOptions<AutoSheetContext> options) : base(options)
        {

        }

        public DbSet<Ficha> Ficha { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Ficha>();
                //.Property(e => e.Gender)
                //.HasConversion(
                //    g => g.ToString(),
                //    g => (GenderEnum)Enum.Parse(typeof(GenderEnum), g));
        }
    }
}
