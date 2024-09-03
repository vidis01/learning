using System.ComponentModel.DataAnnotations;

namespace Database.Learning.DbModels
{
    public class Employee
    {    
        public int EmployeeID { get; set; }

        [MaxLength(50)]
        public required string LastName { get; set; } 

        [MaxLength(50)]
        public required string FirstName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [MaxLength(50)]
        public required string Photo { get; set; }

        [MaxLength(1000)]
        public string? Notes { get; set; }
    }
}
