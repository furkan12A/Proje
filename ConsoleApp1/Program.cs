using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int sayi = r.Next(1, 100);
            int i = 0;
            while (i < 5)
            {

                Console.WriteLine("tahmininiz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin < sayi)
                {
                    Console.WriteLine("tahmininizi büyültün");

                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("tahmininizi küçültün");
                }
                else if (tahmin == sayi)
                {
                    Console.WriteLine("Doğru tahmin");
                    break;
                }

                i++;


            }
            Console.WriteLine("hakkınız bitti.");

            Console.ReadLine();


        }
    }
}
