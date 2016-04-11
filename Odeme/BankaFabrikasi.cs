using Odeme.Bankalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odeme
{
    public class BankaFabrikasi
    {
        // istemci tarafından gelen ödeme tipine göre ödeme nesnesi döner.
        public IBank BankaNesnesiOlustur(string banka)
        {
            // Banka tipi XBANK ise
            if (banka == Cons.Bankalar.XBANK)
                return new XBank();
            // Banka tipi YBANK ise
            if (banka == Cons.Bankalar.YBANK)
                return new YBank();
            // Banka tipi FinansBank ise
            if (banka == Cons.Bankalar.FinansBank)
                return new FinansBank();

            // varsayılan banka 
            return new XBank();
        }
    }
}
