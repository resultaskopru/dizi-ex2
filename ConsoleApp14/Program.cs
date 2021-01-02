using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[10];
            Random r = new Random();
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = r.Next(100);
            }
            int kucuksayi = d[0];
            int buyuksayi = d[0];
            for (int i = 1; i < d.Length; i++)
            {
                if (kucuksayi > d[i])
                    kucuksayi = d[i];
                if (buyuksayi < d[i])
                    buyuksayi = d[i];
            }
            Console.WriteLine("en kücük sayi"+kucuksayi);
            Console.WriteLine("büyük sayi"+buyuksayi);
        }
    }
}
