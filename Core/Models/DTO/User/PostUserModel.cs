using System.ComponentModel.DataAnnotations;

namespace Core.Models.DTO.User
{
    public class PostUserModel
    {
        [Display(Name = "FirstName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is Required")]
        [MaxLength(50, ErrorMessage = "Maximum character {0} is 50 char")]
        public string FirstName { get; set; } = "";

        [Display(Name = "LastName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is Required")]
        [MaxLength(50, ErrorMessage = "Maximum character {0} is 50 char")]
        public string LastName { get; set; } = "";

        [Display(Name = "NationalCode")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is Required")]
        [MaxLength(10, ErrorMessage = "Maximum character {0} is 10 char")]
        public string NationalCode { get; set; } = "";

        [Display(Name = "UserName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is Required")]
        [MaxLength(100, ErrorMessage = "Maximum character {0} is 100 char")]
        public string UserName { get; set; } = "";

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is Required")]
        [MaxLength(200, ErrorMessage = "Maximum character {0} is 200 char")]
        public string Password { get; set; } = "";

        [Display(Name = "ComparePassword")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is Required")]
        [Compare(nameof(Password), ErrorMessage = "{0} Enter correctly")]
        public string ComparePassword { get; set; } = "";
    }
}
