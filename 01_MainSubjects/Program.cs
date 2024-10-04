using System;                        //
using System.Collections.Generic;    //
using System.Linq;                   //    BAZI GEREKLİ KÜTÜPHANELERİN DAHİL EDİLDİĞİ KISIM 
using System.Text;                   //      GEREKLİ KÜTÜPHANELERİ DAHİL ETMEK İÇİN "using" kullanılır
using System.Threading.Tasks;        //

namespace _01_MainSubjects // "namespace" kısmı proje isminin hangi projede çalıştığımızı gösteren kısım
{
    internal class Program 
    {
        static void Main(string[] args) // kodlar main içinde yazılır ve çalıştırılır "main" ana metottur
        {
            #region Yazdırma Komutları

            //Console.Write("");// bir yazıyı yazdırdığı zaman imleci yazının en sağına atar
            // 2 write metodunu arka arkaya çalıştırırsak birleşik ve aynı satıra yazar


            //Console.WriteLine("");// bir yazıyı yazdırdıktan sonra imelci bir alt satıra indirir

            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine("1-ÇORBALAR");
            //Console.WriteLine("2-ANA YEMEKLER");
            //Console.WriteLine("3-SOĞUK BAŞLANGIÇLAR");
            //Console.WriteLine("4-SALATALAR");
            //Console.WriteLine("5-TATLILAR");
            //Console.WriteLine("6-İÇECEKLER");
            //Console.WriteLine();
            //Console.WriteLine("***** YEMEK KATEGORİLERİ BİTTİ *****");


            //Console.Read();
            #endregion

            #region String Değişkenler

            //veriler üzerinde işlem yapmayı sağlayan , geçici olarak ram de tutulan ifadeler

            //Değişken_türü Değişken_adı ; şeklinde değişken tanımlanır

            // 1*String Değişkenler : Alfabetik değişkenleri tutar (metinsel ifadeler)

            // değişkenler isimlerndirilirken
            // -> araya boşluk konulmaz
            // -> türkçe karakter kullanılmaz
            // -> camelCase isimlendirmeye göre isimlendirme yapılır


            //string name;
            //name = "Dogukan" ; // ram de tutuluyor şu an
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, distinct, city;

            // 56.satırda görüldüğü üzere aynı değişken tipinde tek satırda birden fazla değişken tanımlanabilir

            //customerName = "Galip";
            //customerSurname = "Öcalır";
            //customerEmail = "galip@hotmail.com";
            //customerPhone = "+90 5452371223";
            //distinct = "Ürgüp";
            //city = "Nevşehir";

            //Console.WriteLine("***  REZERVASYON KARTI  ***");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("MÜŞTERİ :" + customerName +" "+ customerSurname);
            //Console.WriteLine("TEL NO :" + customerPhone);
            //Console.WriteLine("E-POSTA:" + customerEmail);
            //Console.WriteLine("-------------------------------------------------");


            //customerName = "Ayşegül";
            //customerSurname = "Fartlı";
            //customerEmail = "aysegul@hotmail.com";
            //customerPhone = "+90 5321001223";
            //distinct = "Selçuklu";
            //city = "Konya";

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("MÜŞTERİ :" + customerName + " " + customerSurname);
            //Console.WriteLine("TEL NO :" + customerPhone);
            //Console.WriteLine("E-POSTA:" + customerEmail);
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();




            //Console.Read();

            #endregion

            #region İnt Değişkenler

            // tam sayı tutan sayısal değişkenlerdir

            //int smallPizzaPrice;
            //int mediumPizzaPrice;
            //int largePizzaPrice;
            //int hamburgerPrice;
            //int cheeseBurgerPrice;
            //int kolaPrice;
            //int fantaPrice;
            //int spritePrice;

            //smallPizzaPrice = 100;
            //mediumPizzaPrice = 150;
            //largePizzaPrice = 200;
            //hamburgerPrice = 180;
            //cheeseBurgerPrice = 220;
            //kolaPrice = 45;
            //fantaPrice = 45;
            //spritePrice = 45;


            //Console.WriteLine(" ***** MENU ***** ");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();
            //Console.WriteLine(" PİZZALAR ");
            //Console.WriteLine("Small Pizza -> " + smallPizzaPrice + " TL");
            //Console.WriteLine("Medium Pizza -> " + mediumPizzaPrice + " TL");
            //Console.WriteLine("Large Pizza -> " + largePizzaPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();
            //Console.WriteLine(" BURGERLER ");
            //Console.WriteLine("Hamburger -> " + hamburgerPrice + " TL");
            //Console.WriteLine("Cheeseburger -> " + cheeseBurgerPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();
            //Console.WriteLine(" İÇECEKLER ");
            //Console.WriteLine("Kola -> " + kolaPrice + " TL");
            //Console.WriteLine("Fanta -> " + fantaPrice + " TL");
            //Console.WriteLine("Sprite -> " + spritePrice + " TL");

            //Console.WriteLine(" ADİSYON ");

            //int smallPizzaCount;
            //int mediumPizzaCount;
            //int largePizzaCount;
            //int hamburgerCount;
            //int cheeseBurgerCount;
            //int kolaCount;
            //int fantaCount;
            //int spriteCount;

            //int totalPrice = 0;

            //smallPizzaCount = 0;
            //mediumPizzaCount = 0;
            //largePizzaCount = 1;
            //hamburgerCount = 0;
            //cheeseBurgerCount = 0;
            //kolaCount = 1;
            //fantaCount = 0;
            //spriteCount = 0;

            //Console.WriteLine(" TUTAR : " + (smallPizzaCount * smallPizzaPrice + mediumPizzaPrice * mediumPizzaCount + largePizzaPrice * largePizzaCount +
            //hamburgerPrice * hamburgerCount + cheeseBurgerCount * cheeseBurgerPrice + kolaCount * kolaPrice +
            //spriteCount * spritePrice + fantaCount * fantaPrice) + " TL");


            //Console.WriteLine("Cheeseburger");
            //Console.WriteLine("Kola");
            //Console.WriteLine();
            //Console.WriteLine("TOPLAM -> " + (cheeseBurgerPrice + kolaPrice));

            Console.Read();


            #endregion
        }
    }
}



