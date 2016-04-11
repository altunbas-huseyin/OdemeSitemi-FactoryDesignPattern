using Odeme.Cons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odeme
{
    // Singleton 
    public class SessionManager
    {
        private static SessionManager _utility;
        private SessionManager()
        {

        }
        public static SessionManager GetInstance()
        {
            if (_utility == null)
                _utility = new SessionManager();
            return _utility;
        }

        public KrediKartiOdemeTipi GetKrediKartiOdemeTipi()
        {
            // Burada kullanıcının seçimine göre geri dönüş yapılır. Biz simülasyon yaptığımız için direk taksit gönderdik.
            return KrediKartiOdemeTipi.Taksit;
        }
        public string GetBanka()
        {
            // Burada kullanıcının seçimine göre geri dönüş yapılır. Biz simülasyon yaptığımız için direk XBANK gönderdik.
            return Cons.Bankalar.FinansBank;

        }
    }
}
