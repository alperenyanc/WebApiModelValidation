using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiModelValidation.Models
{
    public class User
    {
        [Required]
        [StringLength(50,ErrorMessage ="adınız en fazla 50 en az 2 karakter olabilir",MinimumLength =2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Syoadınız en fazla 50 en az 2 karakter olabilir", MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Syoadınız en fazla 15 en az 6 karakter olabilir", MinimumLength = 2)]
        [RegularExpression(@"/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&.])[A-Za-z\d$@$!%*?&.]{6, 15}/",
            ErrorMessage = "En az 1 büyük, 1 küçük, 1 özel karakter ve en falza 15 karakter giriniz.")]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Şifre bilgilerinizi kontrol ediniz")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Range(18,100,ErrorMessage ="Yaş ralaığını 18-100 arası giriniz")]
        public string BirtYear { get; set; }
        [Required]
        [CreditCard]
        public string CreditCard { get; set; }
        [Required]
        [Url]
        public string FacebookProfilUrl { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}