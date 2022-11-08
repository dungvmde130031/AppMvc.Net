using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Todos
{
  public class Todo
  {
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar")]
    [Required(ErrorMessage = "{0} must not be null")]
    [StringLength(36)]
    [Display(Name = "Name")]
    public string TodoName { get; set; }

    [Column(TypeName = "nvarchar")]
    [StringLength(100)]
    [Display(Name = "Description")]
    public string TodoDescription { get; set; }

    [Display(Name = "Is Finish")]
    public bool IsFinish { get; set; }
  }
}