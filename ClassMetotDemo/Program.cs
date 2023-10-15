// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

//Console.WriteLine("Hello, World!");

//string MusteriAdi = "Ahmet";
//string MusteriSoyad = "Kılıç";
//string Aciklama = "Deneme";


Musteri musteri1 = new Musteri();
musteri1.Adi = "Ali";
musteri1.Soyadi = "Yılmaz";
musteri1.aciklma = "Yeni müşteri";
musteri1.Bakiye = 1000;

Musteri musteri2 = new Musteri();
musteri2.Adi = "Ayşe";
musteri2.Soyadi = "Kara";
musteri2.aciklma = "emekli";
musteri2.Bakiye=5000;

Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

foreach (Musteri musteri in musteriler)
{
    Console.WriteLine("Adı:" + musteri.Adi);
    Console.WriteLine("Soyadı:" +musteri.Soyadi);
    Console.WriteLine("Bakiye:" +musteri.Bakiye);
    Console.WriteLine("------------------");

}
// instance - örnek
MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle();

musteriManager.Sil();

musteriManager.listele();
musteriManager.listele();
musteriManager.listele();
musteriManager.listele();

musteriManager.Ekle();