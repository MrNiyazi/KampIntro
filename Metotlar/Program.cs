// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");

string urunAdi = "Elma";
double fiyatı = 15;
string aciklama = "Amasya Elması";

string[] meyveler = new string[] { };


Product urun1 = new Product();
urun1.Name = "Elma";
urun1.Description = "Amasya ela";
urun1.Price = 15;

Product urun2 = new Product();
urun2.Name = "Karpuz";
urun2.Description = "Diyarbakır karpuzu";
urun2.Price = 80;
urun2.Stok = 25;

Product[] urunler = new Product[] {urun1,urun2 };
foreach (var Product in urunler)
{
    Console.WriteLine(Product.Name);
    Console.WriteLine(Product.Description);
    Console.WriteLine(Product.Price);
    Console.WriteLine("------------------------------");
    
}

Console.WriteLine("-------------Metotlat-----------------");
//encapsulation


//instance-örnek

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
sepetManager.Ekle2("Armut","elma",12,10);
