using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odeme.Bankalar
{
    public interface IBank
    {
        int TaksitYap();
        string BankaAdi();
    }
}
