using Odeme.OdemeTipleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odeme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odeme.Cons.Bankalar Bankalar = new Odeme.Cons.Bankalar();
            //Odeme.Cons.OdemeTipi OdemeTipi = new Odeme.Cons.OdemeTipi(); 

            OdemeFabrikasi fabrika = new OdemeFabrikasi();
            IOdeme odeme = fabrika.OdemeNesnesiOlustur("KrediKarti");
            odeme.OdemeYap();

            Console.ReadLine();
        }
    }
}
