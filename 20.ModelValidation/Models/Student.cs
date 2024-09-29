using System.ComponentModel.DataAnnotations;

namespace _16.TagHelpersDemo.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name is must")]
        [StringLength(15,MinimumLength =3,ErrorMessage ="Name Must be within 3 to 15 characters")]
        //[MaxLength(15)]
        //[MinLength(3,ErrorMessage ="Minimum length must be 3 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is Must")]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage = "Uppercase,Lowercase,Numbers,Symbols,Min 8 Chars")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Age is must")]
        [Range(10,50)]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password is must")]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage ="Uppercase,Lowercase,Numbers,Symbols,Min 8 Chars")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is must")]
        [Compare("Password",ErrorMessage ="Both password must be Identical")]
        [Display(Name = "Enter Confirm Password ")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Website URL Is Must")]
        [Url(ErrorMessage ="invalid URL")]
        public string WebsiteURL {  get; set; }
    }
}
