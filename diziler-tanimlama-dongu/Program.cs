using System;

namespace diziler_tanimlama_dongu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string [] renkler = new string[5];//5 boyutlu boş string dizi
            string [] hayvanlar = {"kedi","köpek","at","koyun"};//4 boyutlu elemanları belirlenmiş string dizi

            int[] dizi;
            dizi = new int[6];// diziyi tanımlayıp sonradan boyutunu belirledik

            //Dizilere değer atama ve erişim

            renkler[0]="mavi";
            dizi[3]=10;
            
            Console.WriteLine(renkler[0]);
            //çıktı: mavi
            Console.WriteLine(dizi[3]);
            //çıktı: 10
            Console.WriteLine(hayvanlar[1]);
            //çıktı: köpek

            //Döngülerle dizi kullanımı

            //Klavyeden girilen n tane sayının ortalamasını alan program
            Console.Write("Kaç Tane Sayı Girilecek: "); //dizinin boyutunu belirleyecek
            int dizi_uzunlugu = int.Parse(Console.ReadLine());
            int[] sayilar = new int[dizi_uzunlugu];
            

            for (int i = 0; i < dizi_uzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayilar[i]= int.Parse(Console.ReadLine());
            }

            int toplam=0;
            foreach (var sayi in sayilar)
            {
                toplam+=sayi;              
            }

            int ortalama = toplam/dizi_uzunlugu;
            Console.WriteLine("Girdiğiniz Sayıların Ortalaması: "+ortalama);






        }
    }
}
