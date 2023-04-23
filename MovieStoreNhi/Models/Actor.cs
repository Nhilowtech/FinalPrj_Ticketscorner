using System;
using MovieStoreNhi.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreNhi.Models
{
	public class Actor:IEntityBase
	{
        [Key]
        public int Id { get; set; }

        [Display(Name = "Hình ảnh Diễn viên (Link ảnh)")]
        [Required(ErrorMessage = "Bắt buộc phải có ảnh")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Bắt buộc phải có họ tên")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Họ tên chứa từ 3 - 50 ký tự")]
        public string FullName { get; set; }

        [Display(Name = "Thông tin cơ bản")]
        [Required(ErrorMessage = "Bắt buộc phải có thông tin cơ bản")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

