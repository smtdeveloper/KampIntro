using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // namig convention
        // syntax - yazım
        public void Ekle(Produck urun)
        {
            Console.WriteLine("Başarılı, Sepete eklendi : " + urun.Adi + " = FİYATI: "+urun.Fiyati+ " /STOK ADEDİ "+ urun.StokAdedi );
         
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Başarılı, Sepete eklendi : " + urunAdi +  " =  FİYAT:" +fiyat  + "  /Stok Adedi " +stokAdedi);
        }
    }
}
