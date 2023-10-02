using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class TokenOptions//helper class token bilgilerini nesne vasıtasıyla gerçekleştirdik.nesne üzerinden map yapıp çalışacağız.
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }//dk.
        public string SecurityKey { get; set; }
    }
}
