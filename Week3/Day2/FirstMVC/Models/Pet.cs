#pragma warning disable CS8618
namespace FirstMVC.Models;
using System.ComponentModel.DataAnnotations;

public class Pet 
{

    [Required(ErrorMessage ="Name is Required !!!!!!")]
    [MinLength(3)]

    public string Name {get;set;} 
    [Required]
    public string Species {get;set;}
    public bool IsFriendly {get;set;}
    [Required]
    [Range(0,int.MaxValue)]
    public int Age {get;set;}

}