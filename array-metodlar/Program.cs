using System;

namespace array_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Sınıfı Metodlar

            // sort

            Console.WriteLine("****Sırasız Dizi****");
            int[] sayiDizisi = {11,24,1,65,32,12,54,31,17};
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("****Sort(sıralı dizi)****");

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("****Clear****");

            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("****Reverse(Ters Çevirilmiş)****");

            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("**** IndexOf ****");
            
            Console.WriteLine(Array.IndexOf(sayiDizisi,32));



            Console.WriteLine("**** Resize ****");

            Array.Resize<int>(ref sayiDizisi,10);
            sayiDizisi[9] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            

        }
    }
}
