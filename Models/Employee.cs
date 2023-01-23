using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmitWebAppMVC.Models
{
    public class Employee
    {

        [Column(Order =1)]
        public int Id { get; set; }
        [Column(Order = 2)]
        [Required]
        public string Name { get; set; }
        [Column(Order = 3)]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required]

        public string Email { get; set; }
        [Required(ErrorMessage ="Dept is required")]

        [Column(TypeName ="date", Order =4)]
        public DateTime HireDate { get; set; }
        [Column(TypeName ="nvarchar(50)", Order =5)]
        public string Job { get; set; }

        [Column(TypeName ="decimal(18,2)",Order =6)]
        public decimal Salary { get; set; }
        [Column( Order = 7)]
        public Department? Department { get; set; }
        [Column(Order = 8)]
        public DateTime AddOn { get; set; } = DateTime.Now;
        [Column(Order = 9)]
        public DateTime UpdateOn { get; set; } = DateTime.Now;
        [Column(Order = 10)]
        public Status RecStatus { get; set; } = Status.Active;
    }
}
