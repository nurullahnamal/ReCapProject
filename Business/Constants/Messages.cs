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
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInValid = "Araç ismi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string BoyaRengiEklendi ="ColorAdd";
        public static string BoyalarListelendi ="ColorList";
        public static string BrandAdd="Araç Eklendi";

        public static string CarsListed = "Araç Listelendi";
        public static string CarCountOfBrandError = "sınır Aşıldı";
        public static string CarDescriptionAlReadyExists = " bu açıklama kullanılıyor ";

        public static string BrandLimitExceded = "sınır aşıldı yenisi eklenemiyor";

        public static string? AuthorizationDenied = "Yetkin Yok";

        public static string UserRegistered = "Kayıt Olundu";

        public static string UserNotFound = "kullanıcı bulunamadı";

        public static string PasswordError = "parola hatası";

        public static string SuccessfulLogin = "giriş başarılı";

        public static string UserAlreadyExists = "kullacı zaten var";

        public static string AccessTokenCreated = "Giriş Tokeni oluşturuldu";
    }
}
