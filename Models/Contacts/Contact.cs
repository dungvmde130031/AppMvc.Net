using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Contacts
{
  public class Contact
  {
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar")]
    [Required(ErrorMessage = "{0} must not be null")]
    [StringLength(50)]
    [Display(Name = "Full name")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "{0} must not be null")]
    [EmailAddress(ErrorMessage = "Must be Email address!")]
    [StringLength(36)]
    [Display(Name = "Email address")]
    public String Email { get; set; }

    public DateTime? DateSent { get; set; }

    [Display(Name = "Content")]
    public string? Message { get; set; }

    [Phone(ErrorMessage = "Must be phone number!")]
    [StringLength(10)]
    [Display(Name = "Phone number")]
    public string? Phone { get; set; }
  }
}