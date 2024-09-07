using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
    public class Registration
    {
        [Required]
        public string? Name { get; set; }
        public string? Surname { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Phone { get; set; }
        [Required]
        public string? Password { get; set; }
        public bool GetSms { get; set; }
        
    }
}
