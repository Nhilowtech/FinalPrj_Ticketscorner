using System;
using System.ComponentModel.DataAnnotations;
using MovieStoreNhi.Data.Base;

namespace MovieStoreNhi.Models
{
	public class Cinema: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo Phim (Link ảnh)")]
        [Required(ErrorMessage = "Bắt buộc phải có Logo")]
        public string Logo { get; set; }

        [Display(Name = "Tên Phim")]
        [Required(ErrorMessage = "Bắt buộc phải có tên phim")]
        public string Name { get; set; }

        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Bắt buộc phải có mô tả")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

