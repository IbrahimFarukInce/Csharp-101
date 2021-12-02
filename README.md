# veri tipleri

````c#
byte a = 5 ; // 0-255 1 byte

sbyte b = 10 ;// -128 - +128 1 byte



short c = 20 ;// -32768 - +32768 2 byte

ushort d = 5 ;// 0-65365 2 byte



string yazi = " " ;//string sınırsız byte



int i = 5 ; // 4 byte;

Int16 i16 = 5 ; // 2 byte

Int32 i32 = 5 ; // 4 byte

Int64 i64 = 5 ; // 8 byte



uint u = 5 ; // +sayılar 4 byte

long l = 6 ; // 8 byte

ulong ul = 3 ; // +sayılar 8 byte
````



## reel sayılar

````c#
float f = 5 ; // 4 byte

double dbl = 6.5 ; // 8 byte

decimal dcml = 6 ; // 16 byte



char ch = 'a' ; // 2 byte

string str = "ibrahim" ;//sınırsız



bool b1 = true ; 

bool b2 = false ;



DateTime dt = DateTime.Now;



//object her tür veriyi tutabilir

object o = "x" ; 

object o2 = 12 ;

object o3 = 'w' ;

object o4 = 3.4 ; 
````



## string dönüşümü

````c#
int int10= 20 ;

string str10 = "20" ; 

string yeni = int10.ToString() + str10; //2020
````



## int dönüşümü

````c#
int int20= 20 ;

string str20 = "20" ; 

int yeni10 = int20 + Convert.ToInt32(str20);//40

int yeni30 = int20 + int.Parse(str20);//40



//datetime



string datetime = DateTime.Now.ToString("dd.MM.yyyy");

string hour = DateTime.Now.ToString("HH.mm");



Console.WriteLine(hour);


````



# Operatörler



````c#
int a = 5;

int b = 2;

Console.WriteLine(a+b);

7

Console.WriteLine(a-b);

3

Console.WriteLine(a*b);

10

Console.WriteLine(a/b);

2.5



if (a>b || a<b ) 

Console.WriteLine("Or");



if (a>b && a<b ) 

Console.WriteLine("And");
````



**// Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)**

**// Mantıksal Operatörler (||, &&, !)**

**// İlişkisel Operatörler (==,!=, <, >, >=,<=)**

**// Aritmetik (+, -, *, /, %, ++, --)**



# Tip Dönüşümleri



##  implict conversion (bilinçsiz dönüşüm)

````c#
  byte a = 5;

  sbyte b = 30;

  short c = 10;



  int d = a+b+c;

  long h = d;

  float i = h;

  Console.WriteLine("i:"+i);



  string e = "ibrahim";

  char k = 's';

  object f = e+k+i;

  Console.WriteLine("f:"+f);
````





## exlipct conversion (bilinçli dönüşüm)



````c#
  int x = 4;

  byte y = (byte)x;

  Console.WriteLine("y:"+y);



  int z = 4;

  byte t = (byte)z;

  Console.WriteLine("t:"+t);



  float w = 10.3f;

  byte v = (byte)w;

  Console.WriteLine("v:"+v);
````





### ToString Metodu

````c#
  int xx = 6;

  string yy = xx.ToString();

  Console.WriteLine("yy:"+yy);



  string zz = (12.5f).ToString();

  Console.WriteLine("zz:"+zz);

  Convert.ToByte("5");
````



### System.Convert Sınıfı

````c#
  string s1="10", s2="20";

  int sayi1,sayi2;

  int Toplam;

  sayi1 = Convert.ToInt32(s1);

  sayi2 = Convert.ToInt32(s2);

  Toplam = sayi1+sayi2;

  Console.WriteLine("Toplam: "+Toplam);`
````





### Parse

````c#
  ParseMethod();



public static void ParseMethod(){

  string metin1 = "10";

  string metin2 = "10.25";

  int rakam1 ;



  rakam1 = Int32.Parse(metin1);

  double double1 = Double.Parse(metin2);



  Console.WriteLine("rakam1: "+rakam1);

  Console.WriteLine("double1: "+double1);
````



## Karar  Yapıları

## if else if else

```c#
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
```

## Ternay if

```c#
Console.WriteLine(sonuc);

sonuc =  time >=6 && time<11 ? "Günaydın" : time <=18 ? "İyi günler" : "iyi geceler";// saat 6-11 arası günaydın 11-18 arası iyi günler 18-6 arası iyi geceler döndürür

Console.WriteLine(sonuc);
```

## Switch Case

````c#
int month = DateTime.Now.Month;// şu anki ayı döndürür

// aylara göre hangi mevsimde olduğumuzu söyleyen kod
switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Ayındasınız.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar Ayındasınız.");
        break;

    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz Ayındasınız.");
        break;                

    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar Ayındasınız.");
        break;    


    default:
        break;
}
````

# Döngüler

## For Döngüsü

````c#
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
````

### Break Continue

````c#

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
````

## While Döngüsü

````c#
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

````

````c#
// a'dan z'ye kadar olan tüm harfleri ekrana yazdıran döngü
char harf = 'a';
while ( harf<'z' )
{
    Console.WriteLine(harf);
    harf++;              
}
````

## Foreach Döngüsü

````c#
// bir dizideki elemanları yazdıran döngü
string[] arabalar = {"BMW","Mercedes","Ford","Toyata","Renault","Fiat"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
    
}
````

# Diziler

### Dizi Tanımlama

````c#
// Dizi Tanımlama
string [] renkler = new string[5];//5 boyutlu boş string dizi
string [] hayvanlar = {"kedi","köpek","at","koyun"};//4 boyutlu elemanları belirlenmiş string dizi

int[] dizi;
dizi = new int[6];// integer diziyi tanımlayıp sonradan boyutunu belirledik
````

### Dizilere değer atama ve erişim

````c#
renkler[0]="mavi";
dizi[3]=10;

Console.WriteLine(renkler[0]);
//çıktı: mavi
Console.WriteLine(dizi[3]);
//çıktı: 10
Console.WriteLine(hayvanlar[1]);
//çıktı: köpek
````

### Döngülerle dizi kullanımı

````c#
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
````



## Array Sınıfı Metodlar

### Sort

````c#
// Diziyi Sıralar
Console.WriteLine("****Sırasız Dizi****");
int[] sayiDizisi = {11,24,1,65,32,12,54,31,17};
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("****Sort(sıralı dizi)****");

Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
````

### Clear

````c#
// Diziden Belirtilen Elemanları Sıfırlar
Console.WriteLine("****Clear****");

Array.Clear(sayiDizisi,2,2);

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
````

### Reverse

````c#
// Diziyi Bulunduğu durumun tersine Sıralar
Console.WriteLine("****Reverse(Ters Çevirilmiş)****");

Array.Reverse(sayiDizisi);

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
````

### IndexOf

````c#
// Girilen Değerin İndexini Döndürür
Console.WriteLine("**** IndexOf ****");
            
Console.WriteLine(Array.IndexOf(sayiDizisi,32));
````

### Resize

````c#
// Dizinin Boyutunu Değiştirir
Console.WriteLine("**** Resize ****");

Array.Resize<int>(ref sayiDizisi,10);
sayiDizisi[9] = 99;
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
````

