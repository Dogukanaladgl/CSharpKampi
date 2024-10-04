using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //ondalıklı sayıları tutmak için kullanılan değişken tipidir.

            //double number;
            //number = 9.42;  //ondalıklı sayı değeri verirken virgül yerinde nokta kullanılır.
            //Console.WriteLine(number);



            //double applePrice, bananaPrice, strawberryPrice, tomatoPrice, patatoPrice, lemonPrice;

            //applePrice = 14.85;
            //bananaPrice = 27.95;
            //strawberryPrice = 50.95;
            //tomatoPrice = 18.75;
            //patatoPrice = 40.50;
            //lemonPrice = 32.25;



            //double totalPrice;
            //double appleKg =2;
            //double bananaKg=2;
            //double strawberryKg = 1;
            //double tomatoKg = 1;
            //double patatoKg = 0;
            //double lemonKg = 1;


            //totalPrice = applePrice*appleKg + bananaKg*bananaPrice + strawberryPrice*strawberryKg + tomatoPrice*tomatoKg + patatoPrice*patatoKg+ lemonKg*lemonPrice ;

            //Console.WriteLine(" ****  ALIŞVERİŞ FİŞİ  **** ");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine(" -----> ELMA KG FİYATI : " + applePrice);
            //Console.WriteLine(" -----> MUZ KG FİYATI : " + bananaPrice);
            //Console.WriteLine(" -----> ÇİLEK KG FİYATI : " + strawberryPrice);
            //Console.WriteLine(" -----> DOMATES KG FİYATI : " + tomatoPrice);
            //Console.WriteLine(" -----> PATATES KG FİYATI : " + patatoPrice);
            //Console.WriteLine(" -----> LİMON KG FİYATI : " + lemonPrice);

            //Console.WriteLine("              TOPLAM TUTAR : " + totalPrice);
            //Console.WriteLine("------------------------------------------");

            //Console.Read();
            #endregion

            #region Char Değişkenler 

            // char değişkenler tek karakter tutarlar
            // tanımlanırken çift tırnak değil tek tırnak ile tanımlanırlar

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);

            //Console.Read();


            #endregion

            #region Klavyeden String Veri Girişleri

            //Console.WriteLine(" ***** KNGL HAVAYOLLARI ***** ");
            //Console.WriteLine();
            //// CTRL+F İLE KELİME ARAYABİLİRİZ VE ARADIĞIMIZ KELİMELERİN HEPSİNİN ADINI DEĞİŞTİREBİLİRİZ ++++++++

            //// console.ReadLine(); komutu ile kullanıcının klavyeden string değer girmesi sağlanır.

            //string passengerName, passengerSurname, passengerIdentityNumber, passengerCity, passengerDistrict, passengerAge;

            //Console.Write(" Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write(" Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write(" Yolcu TC : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write(" Yolcunun Şehri : ");
            //passengerCity = Console.ReadLine();

            //Console.Write(" Yolcunun İlçesi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write(" Yolcu Yaşı : ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------- YOLCU BİLGİLERİ ---------- ");
            //Console.WriteLine();
            //Console.WriteLine(" Yolcu  " + passengerName + " " + passengerSurname);
            //Console.WriteLine(" Yolcu TC : " + passengerIdentityNumber);
            //Console.WriteLine(" Yolcunun Şehri : " + passengerCity);
            //Console.WriteLine(" Yolcunun İlçesi : " + passengerDistrict);
            //Console.WriteLine(" Yolcu Yaşı : " + passengerAge);

            //Console.Read();



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int keyboardPrice, mousePrice, mousePadPrice, earphonesPrice, screenPrice;

            //keyboardPrice = 1500;
            //mousePrice = 2300;
            //mousePadPrice = 400;
            //earphonesPrice = 8000;
            //screenPrice = 5000;

            //int screenCount, mouseCount, mousePadCount, earphonesCount, keyboardCount;

            //// c# dili klavyeden girilen her veriyi string olarak kabul ettiğinden girilen veriyi integer a dönüştürmek için "int.Parse()" kullanılır .

            //Console.Write(" Kaç adet klavye alacaksınız : ");
            //keyboardCount = int.Parse(Console.ReadLine());

            //Console.Write(" Kaç adet mouse alacaksınız : ");
            //mouseCount = int.Parse(Console.ReadLine());

            //Console.Write(" Kaç adet mousepad alacaksınız : ");
            //mousePadCount = int.Parse(Console.ReadLine());

            //Console.Write(" Kaç adet kulaklık alacaksınız : ");
            //earphonesCount = int.Parse(Console.ReadLine());

            //Console.Write(" Kaç adet monitör alacaksınız : ");
            //screenCount = int.Parse(Console.ReadLine());

            //int totalPrice;
            //totalPrice = (earphonesCount * earphonesPrice + screenCount * screenPrice + keyboardCount * keyboardPrice + mouseCount * mousePrice + mousePadCount * mousePadPrice);

            //Console.WriteLine();
            //Console.WriteLine("--------------- FATURA -----------------");
            //Console.WriteLine();
            //Console.WriteLine(" TOPLAM TUTAR : " + totalPrice );


            //Console.Read();

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri 

            //double exam1, exam2, exam3 , result;
            //// c# dili klavyeden girilen her veriyi string olarak kabul ettiğinden girilen veriyi DOUBLE a dönüştürmek için "double.Parse()" kullanılır .

            //Console.Write(" Lütfen 1. sınav notunuzu giriniz : "); // konsoldan ondalıklı sayı girerken "," (virgül) kullanılır.
            //exam1=double.Parse (Console.ReadLine());

            //Console.Write(" Lütfen 2. sınav notunuzu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write(" Lütfen 3. sınav notunuzu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) /3;

            //Console.WriteLine(" Ortalamanız : " + result);

            //Console.Read();
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyetinizi seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine(" Seçtiğiniz cinsiyet : " + gender);
            
            //Console.Read();

            #endregion
        }
    }
}
