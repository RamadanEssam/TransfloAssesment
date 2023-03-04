namespace TransfloAssesment.Dtos
{
    public class DriverDto
    {
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
         public string phoneNumber { get; set; }
    }
}
