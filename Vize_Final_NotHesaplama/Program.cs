using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Final_NotHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize Notunuzu Giriniz : ");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Giriniz : ");
            double final = Convert.ToDouble(Console.ReadLine());
            double ortalama = (vize * 0.4) + (final * 0.6) / 2;

            {
                if (ortalama >= 0 && ortalama <= 24)
                    Console.WriteLine("FF");
                else if (ortalama >= 25 && ortalama <= 44)
                    Console.WriteLine("DD");
                else if (ortalama >= 45 && ortalama <= 54)
                    Console.WriteLine("CC");
                else if (ortalama >= 55 && ortalama <= 69)
                    Console.WriteLine("BB");
                else if (ortalama >= 70 && ortalama <= 84)
                    Console.WriteLine("BA");
                else if (ortalama >= 85 && ortalama <= 100)
                    Console.WriteLine("AA");
                else
                    Console.WriteLine("Hatalı Giriş Yaptınız !!!");
            }
            Console.ReadLine();
        }
    }
}
