using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        ////////////////////////////////////////////////////////////

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Title { get; set; }
        ////////////////////////////////////////////////////////////

        [RangeAttribute(typeof(DateOnly), "1888-10-14", "2032-12-31")]
        public DateOnly ReleaseDate { get; set; }
        ////////////////////////////////////////////////////////////

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z()\s-]*$")]
        public string? Genre { get; set; }
        ////////////////////////////////////////////////////////////

        [Range(0, 200)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}