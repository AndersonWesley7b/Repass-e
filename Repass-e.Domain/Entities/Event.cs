using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repass_e.Domain.Entities
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage ="O nome do evento pode ter no máximo 60 caracteres")]
        [MinLength(15, ErrorMessage ="O nome do evento deve ter no mínimo 15 caracteres")]
        public string EventName { get; set; }
        [MaxLength(150, ErrorMessage = "O nome do evento pode ter no máximo 60 caracteres")]
        [MinLength(5, ErrorMessage = "O nome do evento deve ter no mínimo 15 caracteres")]
        public string ?EventDescription { get; set; }
        public DateTime InitTime { get; set; }
        public DateTime FinalTime { get; set; }
        [MaxLength(250, ErrorMessage = "O nome do evento pode ter no máximo 60 caracteres")]
        [MinLength(10, ErrorMessage = "O nome do evento deve ter no mínimo 15 caracteres")]
        public string ? Attactions { get; set; }
    }
}
