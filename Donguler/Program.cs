// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.Izlenmeorni = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "JAVA";
kurs2.Egitmen = "Engin Demiroğ";
kurs2.Izlenmeorni = 74;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "HTML";
kurs3.Egitmen = "BERAT";
kurs3.Izlenmeorni = 12;

Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);

}

//string[] kurslar = new string[] {"deneme","test","kurs1","kurs2"};


//for (int i = 0; i <kurslar.Length; i++)
//{
//    Console.WriteLine(kurslar[i]);

//}

//foreach (string kurs in kurslar)
//{
//    Console.WriteLine(kurs);

//}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int Izlenmeorni { get; set; }
}

