using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";

        public static string ProductListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductCategoryError="Ürün sayısı en fazla 10 olabilir";
        public static string ProductNameAlreadyError="bu isimde başka bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldı";
        public static string AuthorizationDenied="Yetkiniz yok";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}