using CSProjeDemo1.Data;
using CSProjeDemo1.Entities;
using CSProjeDemo1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Services
{
    public class Kutuphane
    {
        private readonly KutuphaneContext _context;

        public Kutuphane()
        {
            _context = new KutuphaneContext();
        }

        public void KitapEkle(Kitap kitap)
        {
            
            if (kitap is KitapBilim kitapBilim)
            {
                _context.BilimselKitaplar.Add(kitapBilim);
            }
            else if (kitap is KitapRoman kitapRoman)
            {
                _context.RomanKitaplari.Add(kitapRoman);
            }
            else if (kitap is KitapTarih kitapTarih)
            {
                _context.TarihKitaplari.Add(kitapTarih);
            }
            else
            {
                throw new InvalidOperationException("Geçersiz kitap türü.");
            }
            _context.SaveChanges();
        }

        public void UyeEkle(Uye uye)
        {
            _context.Uyeler.Add(uye);
            _context.SaveChanges();
        }

        public List<Kitap> KitaplariListele()
        {
            
            var bilimKitaplari = _context.BilimselKitaplar                
                .ToList<Kitap>(); 

            var romanKitaplari = _context.RomanKitaplari
                .ToList<Kitap>(); 

            var tarihKitaplari = _context.TarihKitaplari
                .ToList<Kitap>(); 

            return bilimKitaplari.Concat(romanKitaplari).Concat(tarihKitaplari).ToList();
        }

        public List<Kitap> KitaplariDurumaGoreListele(Durum durum)
        {         
            var bilimKitaplari = _context.BilimselKitaplar
                .Where(k => k.KitapDurumu == durum)
                .ToList<Kitap>(); 

            var romanKitaplari = _context.RomanKitaplari
                .Where(k => k.KitapDurumu == durum)
                .ToList<Kitap>(); 


            var tarihKitaplari = _context.TarihKitaplari
                .Where(k => k.KitapDurumu == durum)
                .ToList<Kitap>(); 
                
                 

            return bilimKitaplari.Concat(romanKitaplari).Concat(tarihKitaplari).ToList();
        }

        public List<Uye> UyeleriListele()
        {
            return _context.Uyeler.ToList();
        }

        public List<Kitap> UyeyeAitKitaplar(int uyeNo)
        {
            var uye = _context.Uyeler
                .Include(u => u.OduncAlinanKitaplar) 
                .FirstOrDefault(u => u.UyeNo == uyeNo);

            return uye?.OduncAlinanKitaplar ?? new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap, Uye uye)
        {
            uye.KitapOduncAl(kitap);
            _context.SaveChanges();
        }

        public void KitapIadeEt(Kitap kitap, Uye uye)
        {           
            Kitap iadeKitap = KitaplariListele().FirstOrDefault(k => k.Id == kitap.Id);
            if (iadeKitap != null)
            {               
                iadeKitap.DurumGuncelle(Durum.OduncAlabilir);
                iadeKitap.UyeNo = null; 
                iadeKitap.Uye = null; 

                uye.OduncAlinanKitaplar.Remove(iadeKitap);
                _context.SaveChanges(); 
            }
            
        }

    }
}
