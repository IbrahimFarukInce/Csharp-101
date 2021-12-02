using System;

namespace odev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle yazınız:");
            string cumle = Console.ReadLine();
            string[] dizi = cumle.Split(" ");
            Console.WriteLine("kelime sayısı="+dizi.Length+" Karakter Sayısı="+cumle.Length);
            
        }
    }
}
