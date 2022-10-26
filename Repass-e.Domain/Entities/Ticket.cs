using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Repass_e.Domain.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "O nome do ticket pode ter no máximo 60 caracteres")]
        [MinLength(15, ErrorMessage = "O nome do ticket deve ter no mínimo 15 caracteres")]
        public string TicketName { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "O tipo do ticket pode ter no máximo 60 caracteres")]
        [MinLength(15, ErrorMessage = "O tipo do ticket deve ter no mínimo 15 caracteres")]
        public string TicketType { get; set; }
        [Required]
        public int EventId { get; set; }
        [Required]
        public decimal Price{ get; set; }

    }
}
