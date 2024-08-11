using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductsListed = "Ürünler başarıyla listelendi";
        public static string MaintenanceTime = "Sistem bakımda, lütfen daha sonra tekrar deneyin";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün olabilir";
        public static string CategoryLimitedExceded = "Kategori limiti aşıldı";
        public static string ProductNameAlreadyExists = "Aynı isimde başka bir ürün mevcut";

        // Kullanıcı mesajları
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
