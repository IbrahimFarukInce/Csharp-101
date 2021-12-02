using System;

namespace odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif İki Sayı Giriniz(m,n = ?)");
            Console.WriteLine("n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("n={0} adet sayı giriceksiniz ve bunlardan m={1}'e bölünenleri yazdıracağız:",n,m);

            int sayi;
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1)+". Sayıyı Giriniz:");
                sayi = int.Parse(Console.ReadLine());
                dizi[i]=sayi;
            }
            
            Console.WriteLine("m={0}'e bölünen sayılar;",m);
            foreach (var item in dizi)
            {
                if (item%m == 0)
                Console.Write(item+" ");
            }
        }
    }
}
