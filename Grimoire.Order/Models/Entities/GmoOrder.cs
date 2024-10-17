using System.ComponentModel.DataAnnotations.Schema;

namespace Grimoire.Order.Models.Entities
{
    public class GmoOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public long SqaureFoot { get; set; }
        public int OrderStatus { get; set; }
        public bool IsUrgent { get; set; }
        public string CreatedBy { get; set; }
        public string AssignedTo { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set;} = DateTime.Now;


    }
}
