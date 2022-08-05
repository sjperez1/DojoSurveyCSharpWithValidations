// need the following using when adding validations
using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
// namespace ViewModelFun.Models
public class Form
{
    [Required(ErrorMessage = "Name is required")]
    [MinLength(2, ErrorMessage = "Name must be at least two characters")]
    [Display(Name = "Your name:")]
    // [NoName] is how you add your custom validation to here.
    public string name {get; set;}

    [Required(ErrorMessage = "Location is required")]
    [Display(Name = "Dojo Location:")]
    public string location {get; set;}

    [Required(ErrorMessage = "Language is required")]
    [Display(Name = "Favorite Language:")]
    public string language {get; set;}

    [MinLength(20, ErrorMessage = "If a comment is included, it must be at least 20 characters")]
    [Display(Name = "Comment (optional):")]
    public string? comment {get; set;}
}


// Example of how to add a custom validation
// public class NoNameAttribute : ValidationAttribute
// {
    // Need the question marks to account for any possible null values
//     protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
//     {
//         if(value != null && (string)value == "!!!")
//             return new ValidationResult("You must provide a valid name.");
//         return ValidationResult.Success;
//     }
// }