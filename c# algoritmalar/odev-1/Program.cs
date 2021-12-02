using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi;
            Console.WriteLine("Kaç Sayı Gireceksiniz:");
            int x = int.Parse(Console.ReadLine());

            int [] dizi = new int[x] ;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine((i+1)+". sayıyı girin:");
                sayi = int.Parse(Console.ReadLine());
                dizi[i] = sayi ;
            }
            
            Console.WriteLine("Yazılan Çift Sayılar;");
            foreach (var item in dizi)
            {

                if(item%2 ==0)
                Console.Write(item+" ");
            }
            

        }
    }
}
