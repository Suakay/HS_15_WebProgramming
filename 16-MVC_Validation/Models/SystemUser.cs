using _16_MVC_Validation.ValidationClasses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _16_MVC_Validation.Models
{
    public class SystemUser
    {
        [Required(ErrorMessage ="Kullanıcı Adı Boş Olamaz!")]
        [StringLength(10,ErrorMessage ="Kullanıcı adı en az 3 en fazla 10 karakter olmalıdır!")]
        public string UserName {  get; set; }
        [Required(ErrorMessage = "TCKNO Boş Olamaz!")]
        public long IdentificationNumber {  get; set; }

        [Required(ErrorMessage = "Puan Boş Olamaz!")]
        public int Score {  get; set; }

        [Required(ErrorMessage = "Email Boş Olamaz!")]
        [MailValidation(ErrorMessage ="E-posta adresi @bilgeadam.com ile sonlanmalıdır.ve boşluk içermemelidir.")]
        public string Email {  get; set; }

        [Required(ErrorMessage = "Şifre Boş Olamaz!")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Şifre tekrarı  Olamaz!")]
        public string PasswordConfiguration {  get; set; }
    }
}
