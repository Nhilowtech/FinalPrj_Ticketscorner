using System;
using System.ComponentModel.DataAnnotations;
using MovieStoreNhi.Data.Base;

namespace MovieStoreNhi.Models
{
	public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Đạo Diễn")]
        [Required(ErrorMessage = "Bắt buộc phải có ảnh")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Bắt buộc phải có tên")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Họ tên chưa từ 3 - 50 ký tự")]
        public string FullName { get; set; }

        [Display(Name = "Thông tin cơ bản")]
        [Required(ErrorMessage = "Bắt buộc phải có thông tin cơ bản")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

