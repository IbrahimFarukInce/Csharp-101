using System;

namespace string_metotları
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken ="Csharp'a Hoş Geldiniz";
            string degisken2 ="Csharp";

            //Length (Stringin Uzunluğunu Verir)           
            Console.WriteLine("karakater sayısı="+degisken.Length);


            //ToUpper ToLower (Değişkenin tüm harflerini büyük,küçük yapar)
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());


            //Concat(stringleri birleştirir)
            Console.WriteLine(String.Concat(degisken," Merhaba!"));
            //Csharp'a Hoş Geldiniz Merhaba!

            //Compare CompareTo (stringleri karşılaştırır 0,1,-1)
            //1.değişken > 2.değişken =1 2.değişken > 1. değişken =-1 1.d=2.d =0)
            Console.WriteLine(degisken.CompareTo(degisken2));

            Console.WriteLine(String.Compare(degisken,degisken2,true));//büyük harf duyarlı

            Console.WriteLine(String.Compare(degisken,degisken2,false));//büyük harf duyarsız


            //Contains(değişkenin içinde istenilen karakter,değişken varsa True döner)
            Console.WriteLine(degisken.Contains(degisken2));
            

            //EndsWith StartsWith(istenilen değerler başlıyor ayda bitiyorsa True Döner)
            Console.WriteLine(degisken.EndsWith("Hoş Geldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf (girilen değerin indexini verir)
            Console.WriteLine(degisken.IndexOf("a"));

            //LastIndexOf (indexof ile aynı ama tersten aramaya başlar)
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert(İstenilen değeri istenilen indexe ekler)
            Console.WriteLine(degisken.Insert(0,"Merhaba"));

            //PadLeft Padright(stringin sağına veya soluna istenilen karakteri ekler(default=boşluk))
            Console.WriteLine(degisken.PadLeft(10));
            Console.WriteLine(degisken.PadLeft(30,'*').PadRight(39,'*'));


            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(2,3));

            //Replace
            Console.WriteLine(degisken.Replace(" ","*"));
            
            //Split(istenilen değere göre parçalar ve diziye atar)
            Console.WriteLine(degisken.Split(" ")[1]);

            //Substring 
            Console.WriteLine(degisken.Substring(3));
            Console.WriteLine(degisken.Substring(3,5));

            


        }
    }
}
