using System.ComponentModel.DataAnnotations;

namespace PaymentApi.Models
{
    public class PaymentDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CardOwnerName { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string ExpirationDate { get; set; }
        [Required]
        public string SecurityNumber { get; set; }
    }
}