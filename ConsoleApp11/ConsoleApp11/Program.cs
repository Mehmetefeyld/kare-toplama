using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Hesapla
    {
        private int sayi1;
        private int sayi2;

        public void SayiGir(int sayi1, int sayi2)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
        }

        private int KareleriTopla()
        {
            int toplam = 0;

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i < 0)
                {
                    toplam += 0;
                }
                else
                {
                    toplam += i * i;
                }
            }

            return toplam;
        }

        public void Yaz()
        {
            int sonuc = KareleriTopla();
            Console.WriteLine("Karelerin Toplamı: " + sonuc);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Hesapla hesap = new Hesapla();
            hesap.SayiGir(sayi1, sayi2);
            hesap.Yaz();
        }
    }
}
