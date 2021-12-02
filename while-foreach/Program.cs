using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak girilen sayıya kadar (sayı dahil) ortalama hesaplayıp yazıdran döngü
            Console.WriteLine("Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi ){
                toplam+=sayac;                 
            }
            int ortalama = toplam/sayi;
            Console.WriteLine(ortalama);


            // a'dan z'ye kadar olan tüm harfleri ekrana yazdıran döngü
            char harf = 'a';
            while ( harf<'z' )
            {
                Console.WriteLine(harf);
                harf++;              
            }
            

            // bir dizideki elemanları yazdıran döngü
            string[] arabalar = {"BMW","Mercedes","Ford","Toyata","Renault","Fiat"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
                
            }
        }
    }
}
