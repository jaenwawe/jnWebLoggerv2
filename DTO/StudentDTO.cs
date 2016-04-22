/*

This project contains only data classes. There should be very little to no functionality here

*/

using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class StudentDTO
    {
        [Display(Name = "Student Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Range(5,120)]
        [Required]
        public int Age { get; set; }
    }
}
