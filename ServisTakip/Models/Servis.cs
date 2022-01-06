using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServisTakip.Models
{
    public class Servis
    {
        [Key]
        public int ServisId { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [MaxLength(10, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır.")]
        public string Plaka { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string SoforAdi { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string SoforSoyadi { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [MinLength(11, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır.")]
        public string SoforTelefon { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string GidilenGuzergah { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string GuzergahDetay { get; set; }

        public virtual ICollection<Kisi> Kisis { get; set; }
    }
}