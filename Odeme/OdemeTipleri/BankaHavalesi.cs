using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odeme.OdemeTipleri
{
    public class BankaHavalesi : IOdeme
    {

        public bool OdemeYap()
        {
            return this.BankaHavalesiKontrolEt();
        }

        private bool BankaHavalesiKontrolEt()
        {
            Console.WriteLine("Banka hesabı kontrol edildi, havale gelmiş.");
            return true;
        }
    }
}
