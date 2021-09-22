using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("タイトル")]
        public string Title { get; set; }

        [DisplayName("ジャンル")]
        public string Genre { get; set; }

        [DisplayName("興行収入（億円）")]
        public decimal Revenue { get; set; }

        [DisplayName("公開日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DisplayName("レイティング")]
        public string Rating { get; set; }
    }
}
