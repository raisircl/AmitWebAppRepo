using System.ComponentModel.DataAnnotations;

namespace AmitWebAppMVC.Models
{
    public class Employee
    {
       
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required]

        public string Email { get; set; }
        [Required(ErrorMessage ="Dept is required")]
        public Department? Department { get; set; }
    }
}
