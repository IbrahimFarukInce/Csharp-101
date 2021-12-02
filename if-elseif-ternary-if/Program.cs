using System;

namespace if_elseif_ternary_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;//şu anki saati döndürür
            
            // aşağıdaki yapı 6-11 arası=günaydın 
            // 11-18 arası = iyi günler 
            // 18--22 arası iyi akşamlar 
            // geri kalan saatlerde de iyi geceler döndürür
            if (time>=6 && time<11)
            {
                Console.WriteLine("Günaydın");
                
            }

            else if(time>=11 && time<18){
                Console.WriteLine("İyi Günler");

            }
            else if(time>=18 && time<22){
                Console.WriteLine("İyi Akşamlar");

            }
            else{
                Console.WriteLine("İyi Geceler");
            }
            string sonuc = time<=18 ? "iyi günler" : "iyi geceler";//saat 18 den küçük ve eşitse iyi günler değilse iyi geceler döndürür
            Console.WriteLine(sonuc);
            sonuc =  time >=6 && time<11 ? "Günaydın" : time <=18 ? "İyi günler" : "iyi geceler";// saat 6-11 arası günaydın 11-18 arası iyi günler 18-6 arası iyi geceler döndürür
            Console.WriteLine(sonuc);
        }
    }
}
