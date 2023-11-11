using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.DAL.Entities
{
    public class Ticket : Entity
    {
        [Display(Name = "Ingrese su Ticket")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int TicketId { get; set; }

        public DateTime? UseDate { get; set; }

        public bool IsUsed { get; set; }

        public string? EntranceGate { get; set; }

    }
}
