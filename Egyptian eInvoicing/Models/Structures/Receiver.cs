using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Egyptian_eInvoicing.Models.Structures
{
    public class Receiver
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Receiver registration number is required")]
        public string RegistrationId { get; set; }
        public ICollection< Document> Documents { get; set; }

        [Required(ErrorMessage = "Receiver type is required.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Receiver name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Receiver address is required")]
        public ReceiverAddress Address { get; set; }
    
    }
}
