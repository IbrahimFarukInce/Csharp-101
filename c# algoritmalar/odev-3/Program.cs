using System;

namespace odev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz n:");
            int n = int.Parse(Console.ReadLine());
            

            Console.WriteLine(n+" adet kelime gireceksiniz ve bunlar ters sırayla yazdıralacak");

            string[] dizi = new string[n];
            string kelime;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1)+". Kelime:");
                kelime = Console.ReadLine();
                dizi[i] = kelime;
            }
            Array.Reverse(dizi);

            Console.WriteLine("Ters Sıralanmış Hali;");
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
            }
            

            
        }
    }
}
