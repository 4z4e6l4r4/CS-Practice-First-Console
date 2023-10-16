using System.ComponentModel.Design;
using System.Threading.Channels;

namespace firstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello, World! \n");
            //Console.WriteLine(" Devam etmek için Bir Tuşa Basınız");
            //Console.Write("Deneme ");
            //WriteLine kullanırsan satır tutar, direkt Write kullanırsan diğr işleme geçtiğinde devam'ı silecek.
            //Console.ReadKey();
            //Console.WriteLine("Program Sonlandı");

            // DEĞİŞKENLER
            /*
             1. Sözel Değişkenler
             2. Sayısal Değişkenler
             3. Boolean Değişkenler (var - yok, 1 - 0, doğru-yanlış, true-false)
            */

               //1. Sözel Değişkenler

            //string "" tırnak kullanılır
            string kelime = "Merhaba C#";
            Console.WriteLine(kelime+5);
          
            //char '' tırnak kullanılır, tırnak içine yalnızca tek karakter girilir T ya da F, ASCII kodlarını okur,
            char karakter = 'A';
            //doğrudan sayıyı yazdıramadığı için bu formatta yazıları yazdır, işlem yükünü hafifletir, diğer API lerden gelenleri okumak için buna başvuracağız
            char karakterSayi = (char)99;
            Console.WriteLine(karakter);
            Console.WriteLine(karakterSayi);


            //2. Sayısal Değişkenler

            //int - Tamsayı değişkeni - yönde 2.147.483.648 + yönde 2.147.483.647
            int sayi1 = 10;
            Console.WriteLine(sayi1);

            // ------- tc tel vb. veriler int te yazılınca çok yer kaplar bu yüzden böyle sayıları sayısal değil sözel değişkenlerde/stringte tut. -------


            //uint - Tamsayı değişkeni + yönde tamsayı deeğişkeni 2*2.147.483.647 değer tutar. negatif değerli bir sayı yazamazsın.
            uint sayi2 = 4200200200;
            Console.WriteLine(sayi2);


            //double - Kesirli sayı değişken
            //eğer concole veya başka bir inputtan değer girilirse virgül ile değer girilir.
            //değişken değeri olarak tanımlandığında ise nokta olarak değer girilir.
            // double kesirliSayi1 = 10.5d (şeklinde de kullanılabilir d, double ın kısaltıması. bu sisteme yazdığımız yazının double old. hatırlatır)
            double kesirliSayi1 = 10.5;
            double kesirliSayi2 = 10.5d;
            Console.WriteLine(kesirliSayi1);
            Console.WriteLine(kesirliSayi2);


            //float - kesirli sayı değişkeni (makine diline dönüştürülmesini istiyorsan kullan)
            //floatın sonuna kesinlikle f eklemen gerek
            float kesirliSay3 = 10.5f;
            Console.WriteLine(kesirliSay3);


            //decimal - Bütün sayısal değerler -+1.5*10^28
            //decimal de sonuna m ekle

            decimal kesirliSayi4 = 10.46m;
            Console.WriteLine( kesirliSayi4);


            //byte -  0-255 arasında sayı değeri alır

            byte sayi4 = 255;

            //sbyte -128 +127 arası
            sbyte sayi5 = 0;

            //short -32768 +32767 arası
            short sayi6 = 123;

            //ushort +65535
            ushort sayi7 = 1212;

            //long -9223372036854775808 +9223372036854775807 arası
            long sayi8 = 1212121212121212;

            //ulong +9223372036854775807
            ulong sayi9 = 12222222222222222222;



            //3. Boolean Değişkeni
            bool durum = false; //true
            Console.WriteLine(durum);


            // Tür Değişimleri 

            int number1 = 5;

            //çevirmek için
            string number2 = "15";
            int newNumber = Convert.ToInt32(number2);

            //ondasını almak için float ya da double yap
            string number3 = "15.4";
            double newNumber1 = Convert.ToDouble(number3);

            //Çevirmek için 3 yöntem var
            string number = "15";
            string newNumber_1 = number.ToString();
            string newNumber_2 = Convert.ToString(number);
            string newNumber_3 = number + "";

            //Sabit Değişkenler
            const int number5 = 2;
            //sabit olduğu için number5 = 10; diyemiyorum
            //nerelerde kullanabiliriz?
            const double pi = 3.14;
            double r = 5;
            double islem = pi * (r * r);

            r = 6;
            islem = pi * (r * r);
            // pi sabit değişkenim r normal değişkenim

            //Değiştirilemez bir şey yazmak için const kullan, bütün değişkenler, diziler için const kullanabilirsin.
            const string sorgu = "select * from urunler where urunDurum = true";
            //kişilerin bu sorguyu farklı bir yerde yeniden yazıp admin ya da other user bilgilerini almaması için bu tip sorguları const içinde yazarız.


            // OPERATÖRLER

            //Aritmetik Operatörler

            /*
             +  sayısal değerlerde toplama sözel değerlerde birleştirme işlemi yapar
             -  çıkarma işlemi
             *  çarpma
             /  bölme
             %  mod alma (kalan bulma)
             ++ değeri bir arttırma (bu ifadeler eşittirin önünde ya da sonunda ise işlemin başında ya da sonunda bunu yap demektedir.)
             -- değeri bir azaltma 
             !  ünlem normal değişkenlerde (bool) kullanıldığında değilinini verir. Yani True ise False olur.
             */
            bool durum2 = false;
            Console.WriteLine(!durum2);
            //console da true yazdırır



            // Atama Operatörler

            /*
             =  soldaki değişkene sağdaki değeri aktarır
            +=  soldaki değer ile sağdaki değeri toplar soldaki değişkene aktarır
            -=  soldaki değerden sağdaki değeri çıkartır soldaki değişkene aktarır
            *=  soldaki değer ile sağdaki değeri çarpar ve soldaki değişkene aktarır
            /=  soldaki değeri sağdaki değer böler ve soldaki değişkene aktarır
            %=  soldaki değer sağdaki değer ile bölünür ve kalan soldaki değişkene aktarılır.
            */


            // Karşılaştırma Operatörleri
            /*
             ==  iki taraftaki değerin eşit olması
            ===  (equals) iki taraftaki değerin ve türün eşit olması
             !=  iki tarafın birbirinden farklı olması 
              <  küçüktür
             <=  küçük eşittir
              >  büyüktür
             >=  büyük eşittir
             */

            string isim = "Erhan Kaya";
            string ad = "Erhan Kaya";

            if (isim == ad) { }
            // ya da
            if (isim.Equals(ad)) { }


            // Mantıksal Operatörleri
            /*
             &&  and ve operatörü
             ||  or veya operatörü
             */

            // input değer alma (ReadLine())
            Console.Write("Değer Giriniz: ");
            string gelenDeger1 = Console.ReadLine();

            Console.WriteLine("Gelen Değer: " + gelenDeger1);

            //diğer örnek

            Console.WriteLine("Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı: " + (sayi*5));

//!!! string değer int e dönüştürülemez.
//Console string değer girme durumunda hata vermemesi için:
            basadon:
            Console.WriteLine("Sayı giriniz: ");

            int sayi11 = 0;
            try
            {
                sayi11 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(" Girdiğin sayı numerik değil");
                Console.ReadLine();
                Console.Clear();
                goto basadon;
                //goto çok tercih edilmiyor çünkü sorun çıktığında goto kaçıyor ve yoğun sistemlerde soruna sebep oluyor.
            }
            Console.WriteLine("Sayı: " + (sayi11 * 5));



            // IF - ELSE IF - ELSE

            string a = "Ahmet";
            string b = "Leyla";
            string c = "Hüseyin";

            if (a==b) //şart sağlanıyorsa
            {
                //scope kodları çalışacak
            }
            else if (a==c) //şart sağlanmıyorsa
            {
                // else scope kodları çalışacak

            }

            int durum1 = 2;

            switch (durum1)
            {
                case 3:
                    Console.WriteLine("Durum 2");
                    break;
                default:
                    Console.WriteLine("Şart sağlanmadı");
                    break;

            }

            string role = "user";

            switch (role)
            {
                case "User":
                    Console.WriteLine("Sisteme giriş başarılı");
                    break;

                case "Admin":
                    Console.WriteLine("Panele giriş yapıldı");
                    break;

                default:
                    Console.WriteLine("Kullanıcı Girişi Yetki Hatası");
                    break;

            }
















        }
    }
}