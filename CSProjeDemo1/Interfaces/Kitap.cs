using CSProjeDemo1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Interfaces
{
    public abstract class Kitap
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(13)]
        public string ISBN { get; private set; }

        [Required]
        [MaxLength(255)]
        public string Baslik { get; private set; }

        [Required]
        [MaxLength(100)]
        public string Yazar { get; private set; }

        [Required]
        public int YayinYili { get; private set; }

        [Required]
        public Durum KitapDurumu { get; private set; }

        public int? UyeNo { get; set; } 
        public virtual Uye Uye { get; set; } 

        protected Kitap() { }
        protected Kitap(string isbn, string baslik, string yazar, int yayinYili)
        {
            ISBN = isbn;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
            KitapDurumu = Durum.OduncAlabilir;
        }

        public void DurumGuncelle(Durum yeniDurum)
        {
            KitapDurumu = yeniDurum;
        }
    }
}
