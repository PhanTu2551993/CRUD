using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department Name is required")]
        [StringLength(100, ErrorMessage = "Department Name cannot be longer than 100 characters")]
        public string DepartmentName { get; set; }

        // Navigation Property
        public ICollection<Student>? Students { get; set; }

    }
}
