using System.ComponentModel.DataAnnotations;

namespace CRM.Models;
public class Client
{
    [Key]
    public int Id { get; set; }

    public string? ArabicName { get; set; }
    [Required]
    public string? EnglishName { get; set; }
    [Url]
    public string? Website { get; set; }
    [Phone]
    public string? Phone { get; set; }
    public string? City { get; set; }
    public ICollection<Contact>? Contacts { get; set; }

    public override string ToString() => $"Id: {Id}, Arabic Name: {ArabicName}, English Name: {EnglishName}, Website: {Website}, Phone: {Phone}, City: {City}";
}
