using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 001;
            musteri1.musteriTc = 2121235469;
            musteri1.musteriAdi = "Onur";
            musteri1.musteriSoyadi = "Sağlam";

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 002;
            musteri2.musteriTc = 545123546;
            musteri2.musteriAdi = "Veli";
            musteri2.musteriSoyadi = "Sunal";

            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 003;
            musteri3.musteriTc = 444123541;
            musteri3.musteriAdi = "Tayfun";
            musteri3.musteriSoyadi = "Akkaya";

            Musteri[] musteriler ={ musteri1, musteri2, musteri3};
            MusteriManager manager = new MusteriManager();

            manager.Listele(musteriler);
            manager.Ekle();
            manager.Delete(musteri2);
            //manager.Ekle(4,484848484,"Tolga","Akkuş");
            //manager.Sil(musteri2);
        }
    }
}
