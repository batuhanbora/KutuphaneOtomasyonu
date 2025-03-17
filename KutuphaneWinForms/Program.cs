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
            // Uygulama baþlatýlmadan önce veritabanýný oluþtur ve seed iþlemini gerçekleþtir
            using (var context = new KutuphaneContext())
            {
                // Veritabanýný oluþtur (Eðer yoksa)
                context.Database.Migrate();  // Migration'larý uygulayarak veritabanýný oluþturur.

                // SeedData ekleme, ancak veriler zaten varsa tekrar eklenmesin
                if (!context.Uyeler.Any())  // Eðer Uyeler tablosunda hiç veri yoksa
                {
                    SeedData.VeriEkle(context);
                    context.SaveChanges();  // Veritabanýna kaydet
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GirisForm());
        }
    }
}