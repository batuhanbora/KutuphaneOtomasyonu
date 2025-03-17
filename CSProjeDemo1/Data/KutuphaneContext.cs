using CSProjeDemo1.Entities;
using CSProjeDemo1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Data
{
    public class KutuphaneContext : DbContext
    {
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<KitapBilim> BilimselKitaplar { get; set; }
        public DbSet<KitapRoman> RomanKitaplari { get; set; }
        public DbSet<KitapTarih> TarihKitaplari { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=server_adi;Database=KutuphaneDB;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Kitap>()
                .HasOne(k => k.Uye)  
                .WithMany(u => u.OduncAlinanKitaplar)  
                .HasForeignKey(k => k.UyeNo)  
                .IsRequired(false);  

        }

        // Burada SeedData'yı çağırıyoruz.
        public static void SeedDatabase(KutuphaneContext context)
        {
            if (!context.Uyeler.Any())
            {
                SeedData.VeriEkle(context);
            }
        }
    }
}
