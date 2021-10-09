using System.ComponentModel.DataAnnotations;

namespace ResolveDigitalTest.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
