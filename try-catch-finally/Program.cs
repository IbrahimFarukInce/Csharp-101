using System;

namespace try_catch_finally
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 Console.WriteLine("Bir Sayı Giriniz");
                int Sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz Sayı:"+ Sayi);
            }
            catch(Exception ex) {
                Console.WriteLine("Hata"+ex.Message);
                

            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı.");
                
            }


            try
            {
                 int a = int.Parse(null);
                 int b = int.Parse("test");
            }
            catch(ArgumentNullException ex) {
                Console.WriteLine("Boş bir değer girdiniz");
                Console.WriteLine(ex);
            
            }
            catch(FormatException ex) {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);
            
            }
            
            
        }
    }
}
