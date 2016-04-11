using Odeme.Cons;
using Odeme.OdemeTipleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odeme
{
    public class OdemeFabrikasi
    {
        // istemci tarafından gelen ödeme tipine göre ödeme nesnesi döner.
        public IOdeme OdemeNesnesiOlustur(string odemeTipi)
        {
            // ödeme tipi kredi kartı ise.
            if (odemeTipi == OdemeTipi.KREDIKARTI)
                return new KrediKarti();
            // ödeme tipi havale ise.
            if (odemeTipi == OdemeTipi.BANKAHAVALESI)
                return new BankaHavalesi();

            // varsayılan ödeme tipi
            return new KrediKarti();
        }
    }
}
