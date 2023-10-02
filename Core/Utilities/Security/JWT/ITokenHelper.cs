using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper//token üretimi gerçekleştirir.
    {
        AccessToken CreateToken(User user,List<OperationClaim> OperationClaims);  //token üretimi//user bilgisini göndericem ona göre bir token üretecek
    }                                                                              //kullanıcının rollerini de verip onu tokena ekledik
}
