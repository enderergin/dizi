using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç indexli: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[sayi];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("{0} indexi girin ", i);
                dizi[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("Dizi içindeki elamanlar oluşturuldu.");
            int toplamı = 0;
            int ort = 0;
            foreach (int item in dizi)
            {
                toplamı += item;
            }
            Console.WriteLine("Toplamı: {0}", toplamı);
            ort = toplamı / dizi.Length;
            Console.WriteLine("Ortalaması: {0}", ort);
            Console.ReadKey();
        }
    }
}
