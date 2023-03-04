using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TransfloAssesment.Models
{
    public class Driver
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "You must provide a Firt Name")]
        [MaxLength(100)]
        public string firstName { get; set; }
        [Required(ErrorMessage = "You must provide Last Name")]
        [MaxLength(100)]
        public string lastName { get; set; }
        [Required(ErrorMessage = "You must provide a Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string phoneNumber { get; set; }
        public bool? isDeleted { get; set; }
        public DateTime? deletedDate { get; set; }
        public DateTime? creationDate { get; set; }
        public DateTime? modificationDate { get; set; }




    }
}
