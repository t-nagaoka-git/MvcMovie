using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("タイトル")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "3文字以上、60文字以内で入力してください。")]
        [Required(ErrorMessage = "入力必須です。")]
        public string Title { get; set; }

        [DisplayName("ジャンル")]
        [StringLength(30)]
        [Required(ErrorMessage = "入力必須です。")]
        public string Genre { get; set; }

        [DisplayName("興行収入（億円）")]
        [DataType(DataType.Currency)]
        [Range(1, 1000)]
        public decimal Revenue { get; set; }

        [DisplayName("公開日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DisplayName("レイティング")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required(ErrorMessage = "入力必須です。")]
        public string Rating { get; set; }
    }
}
