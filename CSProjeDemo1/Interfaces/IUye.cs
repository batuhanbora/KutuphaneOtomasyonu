using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Interfaces
{
    public interface IUye
    {
        int UyeNo { get; }
        string Ad { get; }
        string Soyad { get; }
        List<Kitap> OduncAlinanKitaplar { get; }
        void KitapOduncAl(Kitap kitap);
        void KitapIadeEt(Kitap kitap);
    }
}
