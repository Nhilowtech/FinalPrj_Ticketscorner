using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieStoreNhi.Data;
using MovieStoreNhi.Data.Base;

namespace MovieStoreNhi.Models
{
	public class Movie: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên sách")]
        [Required(ErrorMessage = "Bắt buộc phải có tên sách")]
        public string Name { get; set; }

        [Display(Name = "Mô tả sách")]
        [Required(ErrorMessage = "Bắt buộc phải có mô tả")]
        public string Description { get; set; }

        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Bắt buộc phải có giá"),
        DataType(DataType.Currency)]
        public double Price { get; set; }

        [Display(Name = "Hình ảnh (Link ảnh)")]
        [Required(ErrorMessage = "Bắt buộc phải có hình ảnh")]
        public string ImageURL { get; set; }

        [Display(Name = "Ngày công chiếu")]
        [Required(ErrorMessage = "Bắt buộc phải có ngày công chiếu")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Ngày kết thúc")]
        [Required(ErrorMessage = "Bắt buộc phải có ngày kết thúc")]
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}

