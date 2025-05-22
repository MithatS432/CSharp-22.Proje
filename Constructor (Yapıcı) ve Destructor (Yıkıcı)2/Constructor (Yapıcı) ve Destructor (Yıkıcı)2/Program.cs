using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Yapıcı__ve_Destructor__Yıkıcı_2
{
    internal class Program
    {
        class Araba
        {
            public string Marka;
            public int ModelYili;

            // Varsayılan constructor
            public Araba()
            {
                Marka = "Bilinmiyor";
                ModelYili = 0;
                Console.WriteLine("Boş yapıcı çalıştı.");
            }

            // Parametreli constructor
            public Araba(string marka)
            {
                Marka = marka;
                ModelYili = 2020;
                Console.WriteLine("Marka ile yapıcı çalıştı.");
            }

            // Parametreli constructor (overload)
            public Araba(string marka, int modelYili)
            {
                Marka = marka;
                ModelYili = modelYili;
                Console.WriteLine("Tam yapıcı çalıştı.");
            }

            // Destructor
            ~Araba()
            {
                Console.WriteLine($"{Marka} marka araba yıkıcı tarafından temizlendi.");
            }

            public void BilgiYazdir()
            {
                Console.WriteLine($"Marka: {Marka}, Model Yılı: {ModelYili}");
            }
        }
        static void Main(string[] args)
        {
            Araba a1 = new Araba();
            a1.BilgiYazdir();

            Araba a2 = new Araba("Toyota");
            a2.BilgiYazdir();

            Araba a3 = new Araba("BMW", 2023);
            a3.BilgiYazdir();

            // Destructor'lar çalışma zamanında nesneler bellekten silinirken çağrılır.
        }
    }
}
