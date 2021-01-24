using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

           
           
            string kategoriEtiketi = "katogori";
            int nakitParam = 458960;
            double faizOrani = 3.75;
            bool sistemeGirisYapmisMi = true;


            // Do not repeat yourseft - kemdini tekrarlama

            double dolardun = 7.55;
            double dolarBugun = 7.55;

            if (dolarBugun > dolardun)
            {
                Console.WriteLine("Artıs img");

            }
            else if (dolardun > dolarBugun)
            {
                Console.WriteLine("Azalıs img");
            }
            else
            {
                Console.WriteLine("değişmedi img ");
            }
            
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(nakitParam);
            Console.WriteLine(faizOrani);
            Console.WriteLine(sistemeGirisYapmisMi);



        }
    }
}
