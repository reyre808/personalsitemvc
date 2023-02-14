using System.ComponentModel.DataAnnotations;

namespace personal.Models
{
    public class ContactViewModel
    {
        //We can use DataAnnotations to add validation to our model.
        //This is useful when we have required fields or need certain types of info.
        [Required(ErrorMessage= "* Required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.EmailAddress, ErrorMessage= "Must be in correct @ format")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        public string Subject { get; set; } = null!;

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.MultilineText)]//gives us a larger textbox. (textarea)
        public string Message { get; set; } = null!;
    }
}
