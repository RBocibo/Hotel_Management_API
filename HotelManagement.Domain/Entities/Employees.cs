using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Domain
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string JobDepartment { get; set; } = null!;
        [Required]
        [MaxLength(500)]
        public string Address { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
