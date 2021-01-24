using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "samet";
            int yas = 21;

            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Samet Akca";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Burak DemirKıran";
            kurs2.IzlenmeOrani = 56;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Sinem Oktay";
            kurs3.IzlenmeOrani = 82;

           // Console.WriteLine( kurs1.KursAdi+ " : "+  kurs1.Egitmen );


            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3
            };

            foreach (var kurs in kurslar)
            {

             Console.WriteLine(kurs.KursAdi + " - " + kurs.Egitmen);
            }



        }

        class Kurs
        {
            public string KursAdi { get; set; }

            public string Egitmen { get; set; }

            public int IzlenmeOrani { get; set; }

        }
    }
}
