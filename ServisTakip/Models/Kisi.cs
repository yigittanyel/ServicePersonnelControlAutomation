using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServisTakip.Models
{
    public class Kisi
    {
        [Key]
        public int KisiId { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string KisiAd { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string KisiSoyad { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [MinLength(11, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır.")]
        public string KisiTelefon { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string BinilenLokasyon { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public int ServisId { get; set; }
        public virtual Servis Servis { get; set; }
    }
}