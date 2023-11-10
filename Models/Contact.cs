using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Models;
public class Contact
{

    [Key]
    public int Id { get; set; }
    [Required]
    public string? DoctorEnName { get; set; }
    public string? DoctorArName { get; set; }
    public string? DoctorGrade { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public string? Department { get; set; }
    [Phone]
    public string? Phone { get; set; }
}