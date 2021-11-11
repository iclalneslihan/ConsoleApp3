using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int intSayi = 256;
            //byte byteSayi = (byte)intSayi;
            //Console.WriteLine( $"byteSayi = {byteSayi");

            //int degisken1 = int.Parse("365");
            //double degisken2 = double.Parse("34");
            //short degisken3 = short.Parse("4321");
            //char degisken4 = char.Parse("B");

            //Console.WriteLine(degisken1);
            //Console.WriteLine(degisken2);
            //Console.WriteLine(degisken3);
            //Console.WriteLine(degisken4);


            //int limit = 120;
            //object kutu = (object)limit;

            //float ondalikliSayi = 94.23f;
            ////boxing 
            //object nesne = ondalikliSayi;
            ////unboxing
            //ondalikliSayi = (float)nesne;


            // ÖR: Klavyeden alınan iki sayının toplamının karesini ekrana yazdıran programı yazınız.

            //Console.WriteLine("S1: ");
            //string stringS1 = Console.ReadLine();
            //int intS1 = Convert.ToInt32 (stringS1);

            //Console.WriteLine("S2: ");
            //string stringS2 = Console.ReadLine();
            //int intS2 = Convert.ToInt32(stringS2);

            //int toplam = intS1 + intS2;
            //int carpım = (toplam )* (toplam);

            //Console.WriteLine($"carpım = {carpım}");



            //bool kosul = true;
            //if (kosul==true)
            //{
            //    Console.WriteLine("Koşul sağlanıyorsa bu kod çalışır!");

            //}
            //else
            //{
            //    Console.WriteLine("koşul sağlanmıyorsa bu blok çalışır!");
            //}


            //ÖR:Klavyeden girilen 2 sayıdan büyük olanı ekrana yazdıran p.y.

            //Console.Write( "sayi1: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("sayi2: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //bool kosul = sayi1 > sayi2 ;
            //if (kosul == true)
            //{
            //    Console.WriteLine($"sayi1 sayi2 den büyüktür. {sayi1}");

            //}
            //else
            //{
            //    Console.WriteLine($"sayi2 sayi1 den büyüktür. {sayi2}");
            //}



            //ÖR:Klavyeden girilen 3 sayıdan 100'den küçük olanları toplayıp ekrana yazdıran programı yazınız.


            Console.Write("sayi1: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("sayi2: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("sayi3: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            
            if (100 > sayi1)
            {
                toplam += sayi1;
            }            
                        
            if (100 > sayi2)
            {
                toplam += sayi2;
       
            }            
            if (100 > sayi3)
            {
                toplam += sayi3;
        
            }
            Console.WriteLine($"toplam: {toplam}");









        }
    }
}
