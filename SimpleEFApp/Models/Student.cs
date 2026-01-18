using System.ComponentModel.DataAnnotations;

namespace SimpleEFApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(1, 100)]
        public int Age { get; set; }
    }
}
