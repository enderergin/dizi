using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<musteri> m1 = new GenericClass<musteri>();
            m1.yenikayit(null);
            List<musteri> musterilerim = m1.getir();
            GenericClass<urun> urun1 = new GenericClass<urun>();
            urun1.yenikayit(null);
            

        }
    }
}
