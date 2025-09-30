using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
    public class Human
    {
        [Required]
        [Display(Name = "Фамилия", Order = -9, Prompt = "Введите фамилию")]
        public string last_name { get; set; }
        [Required]
        [DisplayName("Имя")]
        public string first_name { get; set; }
        public string? middle_name { get; set; }
        [Required]
     
        public DateOnly birth_date { get; set; }
        public string birth_date_display => birth_date.ToString("yyyy.MM.dd");
        [EmailAddress]
        [Display(Name = "Мыло")]
        public string? email { get; set; }
        [Phone]
        public string? phone { get; set; }
        public byte[]? photo { get; set; }
        public string FullName { get => $"{last_name} {first_name} {middle_name}"; }
        public int Age { get => (int)((DateOnly.FromDateTime(DateTime.Now).DayNumber - birth_date.DayNumber) / 365.25); }
    }
}