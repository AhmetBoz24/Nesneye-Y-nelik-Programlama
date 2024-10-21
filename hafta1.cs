/*iki sayının farkı*/
int a = 13;
int b= 14;
int fark= a - b;
Console.WriteLine("iki sayının farkı:"+fark);

/*5 sayısının karesi*/
int c = 5;
int kare = c * c;
Console.WriteLine("5 sayısının karesi:"+kare);

/*10 sayısının 3 e bölümünden kalan*/
double sayı= 10.0;
double b1 = 3.0;
double kalan = sayı % b1;
Console.WriteLine("10 un 3 bölümünden kalan:" + kalan);

/*klavyeden girilen 4 sayının toplamını ve çarpmasını bulan*/
Console.WriteLine("\nklavyeden girilen 4 sayıyının toplamını ve çarpmasını veren program\n");
Console.WriteLine("1. sayıyı girin:");
int s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. sayıyı girin:");
int s2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. sayıyı girin:");
int s3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("4. sayıyı girin:");
int s4 = Convert.ToInt32(Console.ReadLine());

int toplam=s1+s2+s3+s4;
int carpma=s1*s2*s3*s4;
Console.WriteLine("sayıların toplamı:"+toplam);
Console.WriteLine("sayıların çarpımı:"+carpma);

/*klavyeden girilen 2 sayının bölümü*/

Console.WriteLine("\n 2 sayının bölünmü ");
Console.WriteLine("bölünen sayıyı giriniz:");
double bolunen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("bölen sayıyı giriniz:");
double bolen= Convert.ToInt32(Console.ReadLine());
if (bolen == 0)
{
    Console.WriteLine("bir sayı 0 a bölünemez");
}
else
{
    double bolum = bolunen / bolen;
    Console.WriteLine("2 sayının bölümü:" + bolum);
}

/*klavyeden kenarları girilen dikdörtgenler prizmasını hacmini hesaplayan kod*/
Console.WriteLine("\nsırayla dikdörtgenler prizmasını kenarlarını giriniz");
Console.WriteLine("1.kenarı giriniz");
double k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.kenarı giriniz");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3.kenarı giriniz");
double k3 = Convert.ToInt32(Console.ReadLine());
double hacim= k1*k2*k3; 
Console.WriteLine("dikdörtgenler prizmasının hacmi:"+hacim);