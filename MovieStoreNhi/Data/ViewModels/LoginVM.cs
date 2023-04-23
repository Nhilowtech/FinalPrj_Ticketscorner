using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreNhi.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Địa chỉ Email")]
        [Required(ErrorMessage = "Bắt buộc phải nhập Email")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}