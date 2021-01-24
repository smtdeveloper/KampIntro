using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazlım uzmanı yetiştirme";
            string kurs2 = "Programcı başlangıc kursu";
            string kurs3 = "java";

            // array - dizi 

            string[] kurslar = new string[]
            {
                "Yazlım uzmanı yetiştirme",
                "Programcı başlangıc kursu",
                "java",
                "Python",
                "C++"
            };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            
            Console.WriteLine("for bitti");

            // foreach dizilerde daha cok kullanılır
            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
