using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BilgeBlog.Areas.Admin.Models.DTO
{
    public class LoginModel
    {
        [Required(ErrorMessage ="E-mail adresi girmeniz gerekli")]
        [EmailAddress(ErrorMessage = "Lütfen adam gibi e-mail girin")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Parola boş geçilemez")]
        public string Password { get; set; }
    }
}