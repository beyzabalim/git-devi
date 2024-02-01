// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

/*nsole.WriteLine("Hello, World!");*/


/*Console.WriteLine("Hello World");
Console.ReadLine();*/

/*string isim = "beyza";
string soyisim = "camgoz";
Console.WriteLine(isim +  soyisim);
Console.ReadLine();*/

/*string isim = " beyza";
string soyisim = "camgoz";
Console.WriteLine("merhaba" + isim + soyisim);*/

/*int a = 15;
int b = 32;
float c = 34f;
float d = 23f;
Console.WriteLine(a + b);
Console.WriteLine(b - a);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(c / d);
Console.WriteLine(a % b);
Console.WriteLine(c % d);*/


/*int alisfiyatý = 120;
int karoraný = 60;
Console.WriteLine((alisfiyatý / karoraný)+ alisfiyatý);*/

//dikdörtgenin alaný ve çevresi hesaplama
/*int dikdörtgeninuzunkenari = 10;
int diktörgeninkýsakenari = 3;
//alan hesaplama
Console.WriteLine(dikdörtgeninuzunkenari * diktörgeninkýsakenari);
Console.WriteLine(2 * diktörgeninkýsakenari + 2 * dikdörtgeninuzunkenari); //çevre hesaplama*/

//dairenin alanýný ve çevresini hesaplama
/*int daireninyaricapi = 3;
decimal pisayisi = 3.45M;
Console.WriteLine(daireninyaricapi * pisayisi);*/

/*int birincinot = 92;
int ikincinot = 90;
int ortalama = (birincinot + ikincinot) / 2;
Console.WriteLine(ortalama);

if (ortalama <= 50)
{
    Console.WriteLine("kaldýnýz");
}

else
{
    Console.WriteLine("geçtiniz");
}*/

/*int yazilinot = 56;
int sözlünot = 78;
int geneldegerlendirme = 90;
int ortalama = (yazilinot + sözlünot) * 2 + geneldegerlendirme;
Console.WriteLine(ortalama);

if (ortalama <= 48)
{
    Console.WriteLine("tekrar denemelisin");
}
else
{
    Console.WriteLine("harikasýn, geçtin");
}*/

// hem decimal, hem float hemde int ayný anda iþlem yapamaz mym?

/*int sayi1 = 10;
int sayi2 = 8;

if (sayi1 < sayi2)
{
    Console.WriteLine("güzel");
}
else if (sayi1 > sayi2)
{
    Console.WriteLine("harika");
}
else 
{
    Console.WriteLine("mükemmel");
}*/


/*float bebek1 = 1.3f;
float bebek2 = 2.4f;
float bebek3 = 5.7f;
float ortalama = ((bebek1 + bebek2 + bebek3) / 3);
Console.WriteLine(ortalama);

if (ortalama < 2)
{
    Console.WriteLine("küçük");
}
else if (ortalama > 2 )
{
    Console.WriteLine("orta"); 
}*/

/*int sayi = 9;

if (sayi%2 == 0)
{
    Console.WriteLine("çift sayý");
}
else
{
    Console.WriteLine("tek sayý");
}*/

/*int sayi = 3;
if (sayi < 0)
{
    Console.WriteLine("negatif");
}
else if (sayi == 0)
{
    Console.WriteLine("nötr");
}
else
{
    Console.WriteLine("pozitif");
}*/

/*t sayi = 98;

if(sayi%4==0 && sayi % 7 == 0)
{
    Console.WriteLine("4 ve 7 sayýsýna tam bölünüyor");
}
else
{
    Console.WriteLine("4 ve 7 sayýsýna tam bölünmüyor");
}*/

/*t sayi = 190;
if (0 < sayi && sayi < 100)
{
    Console.WriteLine("0-100 arasýnda deðildir");
}
else
{
    Console.WriteLine("0-100 arasýnda deðildir");
}*/

/*t golsayisi = 23;
if (golsayisi < 20 && golsayisi==20)
{
    Console.WriteLine("güzel");
}
else if (golsayisi > 20)
{
    Console.WriteLine("harika");
}*/
/*nt golsayisi = 3;
string takimseviyesi = "";
Random sayi = new Random();
golsayisi = sayi.Next(0, 6);

switch (golsayisi)
{
    case 1:
        takimseviyesi = "ok";
        break;
    case 2:
        takimseviyesi = "good";
        break;
    case 3:
        takimseviyesi = "welldone";
        break;
    default:
        takimseviyesi = "kötü";
        break;

}
Console.WriteLine(takimseviyesi);*/

/*t bebeksayisi = 7;
string saðlýkseviyesi = "";
Random sayi = new Random();
bebeksayisi = sayi.Next(0, 8);

switch (bebeksayisi)
{
    case 1:
        Console.WriteLine("saðlýklý");
        break;
    case 2:
        Console.WriteLine("saðlýksýz");
        break;
    case 3:
        Console.WriteLine("saðlýðý orta");
        break;
    default:
        Console.WriteLine("saðlýk kontrolü gerekli");
        break;

}
Console.WriteLine(saðlýkseviyesi);*/


/*r (int i = 0; i < 10; i++) 
{
    Console.WriteLine(i);
}
Console.ReadLine();*/


/*ring[] siparino =
{
    "beyza1",
    "beyza2",
    "beyza3"
};
for(int i=siparino.Length-1; i>0;i--)
{
    Console.WriteLine(siparino[i]);
}
Console.ReadLine();*/

int sayi = 0;
do
{
    Console.WriteLine(sayi);
    sayi++;
} while (sayi < 10);