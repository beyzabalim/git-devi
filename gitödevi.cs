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


/*int alisfiyat� = 120;
int karoran� = 60;
Console.WriteLine((alisfiyat� / karoran�)+ alisfiyat�);*/

//dikd�rtgenin alan� ve �evresi hesaplama
/*int dikd�rtgeninuzunkenari = 10;
int dikt�rgenink�sakenari = 3;
//alan hesaplama
Console.WriteLine(dikd�rtgeninuzunkenari * dikt�rgenink�sakenari);
Console.WriteLine(2 * dikt�rgenink�sakenari + 2 * dikd�rtgeninuzunkenari); //�evre hesaplama*/

//dairenin alan�n� ve �evresini hesaplama
/*int daireninyaricapi = 3;
decimal pisayisi = 3.45M;
Console.WriteLine(daireninyaricapi * pisayisi);*/

/*int birincinot = 92;
int ikincinot = 90;
int ortalama = (birincinot + ikincinot) / 2;
Console.WriteLine(ortalama);

if (ortalama <= 50)
{
    Console.WriteLine("kald�n�z");
}

else
{
    Console.WriteLine("ge�tiniz");
}*/

/*int yazilinot = 56;
int s�zl�not = 78;
int geneldegerlendirme = 90;
int ortalama = (yazilinot + s�zl�not) * 2 + geneldegerlendirme;
Console.WriteLine(ortalama);

if (ortalama <= 48)
{
    Console.WriteLine("tekrar denemelisin");
}
else
{
    Console.WriteLine("harikas�n, ge�tin");
}*/

// hem decimal, hem float hemde int ayn� anda i�lem yapamaz mym?

/*int sayi1 = 10;
int sayi2 = 8;

if (sayi1 < sayi2)
{
    Console.WriteLine("g�zel");
}
else if (sayi1 > sayi2)
{
    Console.WriteLine("harika");
}
else 
{
    Console.WriteLine("m�kemmel");
}*/


/*float bebek1 = 1.3f;
float bebek2 = 2.4f;
float bebek3 = 5.7f;
float ortalama = ((bebek1 + bebek2 + bebek3) / 3);
Console.WriteLine(ortalama);

if (ortalama < 2)
{
    Console.WriteLine("k���k");
}
else if (ortalama > 2 )
{
    Console.WriteLine("orta"); 
}*/

/*int sayi = 9;

if (sayi%2 == 0)
{
    Console.WriteLine("�ift say�");
}
else
{
    Console.WriteLine("tek say�");
}*/

/*int sayi = 3;
if (sayi < 0)
{
    Console.WriteLine("negatif");
}
else if (sayi == 0)
{
    Console.WriteLine("n�tr");
}
else
{
    Console.WriteLine("pozitif");
}*/

/*t sayi = 98;

if(sayi%4==0 && sayi % 7 == 0)
{
    Console.WriteLine("4 ve 7 say�s�na tam b�l�n�yor");
}
else
{
    Console.WriteLine("4 ve 7 say�s�na tam b�l�nm�yor");
}*/

/*t sayi = 190;
if (0 < sayi && sayi < 100)
{
    Console.WriteLine("0-100 aras�nda de�ildir");
}
else
{
    Console.WriteLine("0-100 aras�nda de�ildir");
}*/

/*t golsayisi = 23;
if (golsayisi < 20 && golsayisi==20)
{
    Console.WriteLine("g�zel");
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
        takimseviyesi = "k�t�";
        break;

}
Console.WriteLine(takimseviyesi);*/

/*t bebeksayisi = 7;
string sa�l�kseviyesi = "";
Random sayi = new Random();
bebeksayisi = sayi.Next(0, 8);

switch (bebeksayisi)
{
    case 1:
        Console.WriteLine("sa�l�kl�");
        break;
    case 2:
        Console.WriteLine("sa�l�ks�z");
        break;
    case 3:
        Console.WriteLine("sa�l��� orta");
        break;
    default:
        Console.WriteLine("sa�l�k kontrol� gerekli");
        break;

}
Console.WriteLine(sa�l�kseviyesi);*/


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