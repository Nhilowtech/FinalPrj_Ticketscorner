using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreNhi.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Bắt buộc phải nhập Họ tên")]
        public string FullName { get; set; }

        [Display(Name = "Địa chỉ Email")]
        [Required(ErrorMessage = "Bắt buộc phải nhập địa chỉ Email")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Required(ErrorMessage = "Bắt buộc phải nhập mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận không khớp")]
        public string ConfirmPassword { get; set; }
    }
}