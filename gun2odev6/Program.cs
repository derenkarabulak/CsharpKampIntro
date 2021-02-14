using System;

namespace gun2odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            product urun1 = new product();
            urun1.urunAdi = "Tişört";
            urun1.fiyat = 50;

            product urun2 = new product();
            urun2.urunAdi = "Pantolon";
            urun2.fiyat = 60;

            product urun3 = new product();
            urun3.urunAdi = "Ayakkabı";
            urun3.fiyat = 70;

            product[] urunler = new product[] { urun1, urun2, urun3 };

            for (int i=0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün adı : " + urunler[i].urunAdi + " " + "\nÜrün fiyatı : " + urunler[i].fiyat + " ");
            }

            Console.WriteLine(" ");

            foreach(var urun in urunler)
            {
                Console.WriteLine("Ürün : " + urun.urunAdi + " " + "\nFiyatı : " + urun.fiyat + " ");
            }

            Console.WriteLine(" ");

            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine("Ürün adı : " + urunler[j].urunAdi + " " + "\nÜrün fiyatı : " + urunler[j].fiyat + " ");
                j++;

            }

            Console.WriteLine(" ");

            
        }
    }

    class product
    {
        public string urunAdi { get; set; }
        public int fiyat { get; set; }

    }
}
