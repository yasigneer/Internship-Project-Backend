using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string PersonAdded = "Kişi eklendi";
        public static string PersonUpdated = "Kişi güncellendi";
        public static string PersonDeleted = "Kişi silindi";
        public static string DeleteWarning = "Emin misiniz?";
        public static string FirstNameMustExist = "'Ad' boş bırakılamaz, lütfen isim giriniz";
        public static string FirstNameTooLong = "Ad en fazla 20 karakter olabilir";
        public static string LastNameMustExist = "'Soyad' boş bırakılamaz, lütfen isim giriniz";
        public static string LastNameTooLong = "SOyad en fazla 20 karakter olabilir";
        public static string PhoneNumberInvalid = "Geçersiz numara, lütfen numara giriniz";
    }
}
