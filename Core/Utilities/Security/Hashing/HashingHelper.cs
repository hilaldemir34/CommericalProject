using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordsalt)//Passwordun hashini oluştur ve saltını oluştur bu ikisini dışarı ver.out boş bile olsa doldurup verir.
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())//cryptography yaptık
            {
                passwordsalt = hmac.Key;//her kullanıcı farklı key oluşturur.
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordsalt)//doğrulama yap
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordsalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < passwordHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;   
                    }
                }
                return true;
            }
        }
    }
}
