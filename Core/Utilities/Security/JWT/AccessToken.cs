using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    //Erişim anahtarı
    //AccessToken-->Anlamsız karakterlerden oluşan bir anahtar değeridir.
    public class AccessToken
    {
        public string Token { get; set; }

        public DateTime Expiration { get; set; } //Bitiş süresi/zamanı

    }
}
