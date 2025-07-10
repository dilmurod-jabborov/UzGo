using UzGo.Domain.Enums;

namespace UzGo.Domain.Models
{
    internal class Order
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public int DriverId {  get; set; }
        public decimal Price { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public Status Status { get; set; }

    }
}
