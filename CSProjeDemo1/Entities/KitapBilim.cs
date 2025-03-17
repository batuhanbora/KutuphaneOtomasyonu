using CSProjeDemo1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities
{
    public class KitapBilim : Kitap
    {
        public KitapBilim() { }
        public KitapBilim(string isbn, string baslik, string yazar, int yayinYili)
            : base(isbn, baslik, yazar, yayinYili) { }
    }
        
}
