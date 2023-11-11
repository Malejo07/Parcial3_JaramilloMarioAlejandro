namespace TicketingSystem.DAL.Entities
{
    public class Tickets : Entity
    {
        public DateTime? UseDate { get; set; }
        public bool IsUsed { get; set; }
        public string? EntranceGate { get; set; }

    }
}
