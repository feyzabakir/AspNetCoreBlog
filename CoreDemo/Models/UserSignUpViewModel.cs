using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Lütfen Ad Soyad Giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrarı")]
        [Compare("Password", ErrorMessage = "Şifreleriniz uyuşmuyor.")]
        public string ConfirimPassword { get; set; }

        [Display(Name = "E-Posta")]
        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz.")]
        public string Mail { get; set; }

    }
}
