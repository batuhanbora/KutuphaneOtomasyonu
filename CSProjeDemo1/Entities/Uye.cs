using CSProjeDemo1.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities
{
    public class Uye : IUye
    {
        [Key]
        public int UyeNo { get; private set; }

        [Required]
        [MaxLength(50)]
        public string Ad { get; private set; }

        [Required]
        [MaxLength(50)]
        public string Soyad { get; private set; }

        public virtual List<Kitap> OduncAlinanKitaplar { get; private set; }

        public Uye()
        {
            OduncAlinanKitaplar = new List<Kitap>();
        }
        public Uye(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            OduncAlinanKitaplar = new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.KitapDurumu == Durum.OduncAlabilir)
            {
                kitap.DurumGuncelle(Durum.OduncVerildi);
                kitap.UyeNo = this.UyeNo;
                OduncAlinanKitaplar.Add(kitap);
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncAlinanKitaplar.Contains(kitap))
            {
                kitap.DurumGuncelle(Durum.OduncAlabilir);
                kitap.UyeNo = null;
                kitap.Uye = null;
                OduncAlinanKitaplar.Remove(kitap);
            }
        }
    }
}
