using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri[] musteri)
        {
            foreach (var x in musteri)
            {
            Console.WriteLine("----------Müşteri----------");
            Console.WriteLine("Müşterinin Tc Kimlik nosu :  " + x.musteriTc);
            Console.WriteLine("Müşterinin adı soyadı :  " + x.musteriAdi + " " + x.musteriSoyadi);
            Console.WriteLine();
            }

        }

        public void Ekle()
        {
            
            Musteri b  = new Musteri();
            Console.WriteLine("++++++++++EKLEME+++++++++++");
            Console.WriteLine("Musteri ID giriniz:");
            b.musteriId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Musteri Adı:");
            b.musteriAdi = Console.ReadLine();
            Console.WriteLine("Musteri Soyadı:");
            b.musteriSoyadi = Console.ReadLine();
            Console.WriteLine("Müsteri Tc:");
            b.musteriTc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri Başarıyla eklenmiştir");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("************Silme İşlemi***********");
            Console.WriteLine("Adı : " + musteri.musteriAdi + "  Soyadı : " + musteri.musteriSoyadi + "  TC'si : " + musteri.musteriTc + " Olan Müşteri Sistemden Silindi.");
        }

    }
}
