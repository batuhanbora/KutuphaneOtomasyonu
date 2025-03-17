using CSProjeDemo1.Data;
using CSProjeDemo1.Entities;
using CSProjeDemo1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSProjeDemo1.Data
{
    public static class SeedData
    {
        public static void VeriEkle(KutuphaneContext context)
        {            
            var kitaplar = new List<Kitap>
            {
                new KitapBilim("9781234567891", "Bilim Kitabı 1", "Bilimci A", 2000),
                new KitapBilim("9781234567892", "Bilim Kitabı 2", "Bilimci B", 2001),
                new KitapBilim("9781234567893", "Bilim Kitabı 3", "Bilimci C", 2002),
                new KitapBilim("9784234567891", "Bilim Kitabı 4", "Bilimci D", 2003),
                new KitapRoman("9782234567891", "Roman Kitabı 1", "Yazar A", 1990),
                new KitapRoman("9782234567892", "Roman Kitabı 2", "Yazar B", 1991),
                new KitapRoman("9782234567893", "Roman Kitabı 3", "Yazar C", 1992),
                new KitapRoman("9788234567891", "Roman Kitabı 4", "Yazar D", 1993),
                new KitapTarih("9783234567891", "Tarih Kitabı 1", "Tarihçi A", 1980),
                new KitapTarih("9783234567892", "Tarih Kitabı 2", "Tarihçi B", 1981),
                new KitapTarih("9783234567893", "Tarih Kitabı 3", "Tarihçi C", 1982),
                new KitapTarih("9789234567891", "Tarih Kitabı 4", "Tarihçi D", 1983)
            };

            var uyeler = new List<Uye>
            {
                new Uye("Ahmet", "Yılmaz"),
                new Uye("Ayşe", "Kaya"),
                new Uye("Mehmet", "Demir")
            };

            context.AddRange(kitaplar);
            
            context.AddRange(uyeler);

            var rastgele = new Random();
            foreach (var uye in uyeler)
            {
                var oduncKitaplar = kitaplar.Where(k => k.KitapDurumu == Durum.OduncAlabilir)
                                            .OrderBy(k => rastgele.Next())
                                            .Take(3)
                                            .ToList();

                foreach (var kitap in oduncKitaplar)
                {
                    uye.KitapOduncAl(kitap);
                }
            }

            context.SaveChanges();
        }
    }
}
