using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekranda girilen sayıya kadar olan tek sayıları ekrana yazdırma
            Console.WriteLine("Sayı gir ");
            int sayac=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayac; i+=2)
            {
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların toplamı
            int toplamTek=0;
            int toplamCift=0;
            for (int i = 1; i <=1000; i++)
            {
                if(i%2==0){
                    toplamCift+=i;
                }
                else{
                    toplamTek+=i;
                }
            }

            Console.WriteLine("Çift Toplam --> "+toplamCift);
            Console.WriteLine("Tek Toplam --> "+toplamTek);

            //break continue
            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    break;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    continue;
                }
            }
        }
    }
}