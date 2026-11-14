using System.ComponentModel.DataAnnotations;

namespace UniversityDbApp.Models;

public class Teacher
{
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; } = string.Empty;

    public string Subject { get; set; } = string.Empty;

    public int DepartmentId { get; set; }

    public Department Department { get; set; } = null!;
}