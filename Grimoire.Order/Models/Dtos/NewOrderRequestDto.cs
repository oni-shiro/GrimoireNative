namespace Grimoire.Order.Models.Dtos
{
    public class NewOrderRequestDto
    {
        public string CustomerName { get; set; }
        public string CustomerPhoneNo { get; set; }
        public string CustomerEmail { get; set; }
        public string OrderDesc { get; set; }
        public long SquareFeet { get; set; }
        // public OrderStatus OrderStatus { get; set; } // Assuming OrderStatus is an enum
        public string OrderName { get; set; }
        public bool IsUrgent { get; set; }
        public string UniqueUserId { get; set; }
    }
}
