using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odeme.Bankalar
{
    public class FinansBank : IBank
    {
        public int TaksitYap()
        {
            return 5;
        }

        public string BankaAdi()
        {
            return "FinansBank";
        }

        public decimal Indirim()
        {
            // Burada WebServisleri, veritabanında okuma gibi işlemler yapılabilir. Biz örnek uygulama olduğu için direk değer dönüyoruz.
            return 10;
        }
    }
}
