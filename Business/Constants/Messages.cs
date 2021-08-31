using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ColorAdded   = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";

        public static string BrandAdded   = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";

        public static string CategoryAdded   = "Kategori eklendi";
        public static string CategoryUpdated = "Kategori güncellendi";
        public static string CategoryDeleted = "Kategori silindi";

        public static string ClotheImageAdded   = "Kıyafet resmi eklendi";
        public static string ClotheImageDeleted = "Kıyafet resmi silindi";
        public static string ClotheImageUpdated = "Kıyafet resmi güncellendi";

        public static string ClotheAdded   = "Kıyafet eklendi";
        public static string ClotheUpdated = "Kıyafet güncellendi";
        public static string ClotheDeleted = "Kıyafet silindi";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Email bulunamadı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";

        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";


        public static string AccessTokenCreated = "JWT Created";
    }
}
