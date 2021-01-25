using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Produck urun1 = new Produck();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 156;

            Produck urun2 = new Produck();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 360;

            Produck[] urunler = new Produck[] { urun1, urun2, };

            // type-safe -- tip güvenli
            foreach (Produck TakmaName in urunler)
            {
                Console.WriteLine(TakmaName.Adi);
                Console.WriteLine(TakmaName.Fiyati);
                Console.WriteLine(TakmaName.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("------------Metotlar--------------");

            // instance - örnek
            // encapulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("------------------------------------");

            sepetManager.Ekle2("Armut", "sarı Armut", 12, 90);
            sepetManager.Ekle2("cilek", "kırmızı cilek", 14, 56);
            sepetManager.Ekle2("Muz", "sarı Muz", 22, 80);


            Console.WriteLine("SMTcoder");

        }
    }
}


// Dont repeat yourslf - DRY - Clean Code - Best Practice 
