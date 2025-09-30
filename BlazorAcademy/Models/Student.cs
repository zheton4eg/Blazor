using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
    public class Student : Human
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stud_id { get; set; }
        [Required]
        public int group { get; set; }
    }
}