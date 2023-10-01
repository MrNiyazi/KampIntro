using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
    {

        //naming convention 
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi " +  product.Name + " " + product.Stok);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadeti ) 
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi + stokadeti);

        }
    }
}
