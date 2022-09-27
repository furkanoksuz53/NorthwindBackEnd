using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string Added = " Eklendi ";
        public static string NameInvalid = "Geçersiz İsim";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string Listed = "Listelendi";
        public static string DataNotFound = "Veri Bulunamadı";
        public static string Updated = " Güncellendi";
        public static string Deleted = "Silindi";

        public static string ProductCountOfCategoryError = "Kategorideki maksimum ürün miktarına ulaştınız";

        public static string ProductNameAlreadyExist = "aynı isimde ürün zaten mevcut";

        public static string CategoryLimitExceded = "kategori sınırı aşıldığı için ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kullanıcı oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "hatalı parola";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "accesstoken oluşturuldu";
    }
}