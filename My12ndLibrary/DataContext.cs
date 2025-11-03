using Microsoft.EntityFrameworkCore;
using My3rdLibrary.Entities;

namespace My2ndLibrary
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options)
        //{

        //}

        public DbSet<Contact> Contactes { get; set; }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PERSONLAPW11\\SQL2022;Database=ContactesDb2025C3Mondays;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder); 
        }


    }
}
