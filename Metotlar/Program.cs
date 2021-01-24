using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Produck urun1 = new Produck();
            urun1.Adi = "elma";
            urun1.fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Produck urun2 = new Produck();
            urun2.Adi = "Karpuz";
            urun2.fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Produck[] urunler = new Produck[] { urun1, urun2, };

            // type-safe -- tip güvenli
            foreach (Produck TakmaName in urunler)
            {
                Console.WriteLine(TakmaName.Adi);
                Console.WriteLine(TakmaName.fiyati);
                Console.WriteLine(TakmaName.Aciklama);
                Console.WriteLine("-------------------");
            }

           

            Console.WriteLine("Hello World!");

        }
    }
}


// Dont repeat yourslf - DRY - Clean Code - Best Practice 
