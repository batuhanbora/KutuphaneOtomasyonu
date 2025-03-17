using CSProjeDemo1.Data;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Uygulama ba�lat�lmadan �nce veritaban�n� olu�tur ve seed i�lemini ger�ekle�tir
            using (var context = new KutuphaneContext())
            {
                // Veritaban�n� olu�tur (E�er yoksa)
                context.Database.Migrate();  // Migration'lar� uygulayarak veritaban�n� olu�turur.

                // SeedData ekleme, ancak veriler zaten varsa tekrar eklenmesin
                if (!context.Uyeler.Any())  // E�er Uyeler tablosunda hi� veri yoksa
                {
                    SeedData.VeriEkle(context);
                    context.SaveChanges();  // Veritaban�na kaydet
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GirisForm());
        }
    }
}