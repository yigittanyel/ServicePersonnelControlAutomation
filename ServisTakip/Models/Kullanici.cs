using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServisTakip.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [MaxLength(11, ErrorMessage = "Tc kimlik numarası en fazla {1} karakter uzunluğunda olabilir.")]
        public string TcKimlikNo { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [MinLength(5, ErrorMessage = "Şifre en az {1} karakter uzunluğunda olmalıdır.")]
        public string Sifre { get; set; }
    }
}