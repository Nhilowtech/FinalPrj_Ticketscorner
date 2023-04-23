using MovieStoreNhi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreNhi.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Tên Phim")]
        [Required(ErrorMessage = "Bắt buộc phải nhập Tên")]
        public string Name { get; set; }

        [Display(Name = "Mô tả Phim")]
        [Required(ErrorMessage = "Bắt buộc phải nhập mô tả")]
        public string Description { get; set; }

        [Display(Name = "Giá (VNĐ)")]
        [Required(ErrorMessage = "Bắt buộc phải nhập giá")]
        public double Price { get; set; }

        [Display(Name = "URL poster")]
        [Required(ErrorMessage = "Bắt buộc phải nhập URL poster")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Ngày công chiếu")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Bắt buộc phải nhập Ngày công chiếu")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Diễn viên")]
        [Required(ErrorMessage = "Bắt buộc phải chọn Diễn viên")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Rạp phim")]
        [Required(ErrorMessage = "Bắt buộc phải chọn Rạp phim")]
        public int CinemaId { get; set; }

        [Display(Name = "Nhà sản xuất")]
        [Required(ErrorMessage = "Bắt buộc phải chọn Nhà sản xuất")]
        public int ProducerId { get; set; }
    }
}