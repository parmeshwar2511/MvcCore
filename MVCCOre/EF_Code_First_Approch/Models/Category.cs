using System.ComponentModel.DataAnnotations;

namespace EF_Code_First_Approch.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Only letters and spaces are allowed.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Number is required.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Only numbers are allowed.")]
        public string Number { get; set; }


        [Required(ErrorMessage = "Number is required.")]
        public string Email { get; set; }
    }
}
