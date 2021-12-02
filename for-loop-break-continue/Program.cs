using System;

namespace for_loop_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrana girilen sayıya kadar olan tek sayıları yazdıran döngü
            Console.WriteLine("Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if(i%2 ==1)
                    Console.WriteLine(i);
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların toplamını yazdıran döngü
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                if(i%2 ==1 )
                    tekToplam+=i;
                
                else
                    ciftToplam+=i;                
            }

            //döngüde belirli bir satırın çalışmamasını istiyoruz diyelim bu satırda 4. satır olsun
            
            for (int i = 1; i < 10; i++)
            {
                
                if (i==4)
                    break; // break döngüyü sonlandırır bundan sonraki döngüdeki hiç bir adım çalışmaz
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i==4)
                    continue; // continue döngüyü sonlandırmaz geçerli adım(continue altındaki) çalışmaz sonraki adımlar çalışır
                Console.WriteLine(i);
            }




        }
    }
}
