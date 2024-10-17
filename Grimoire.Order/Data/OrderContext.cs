using Grimoire.Order.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Grimoire.Order.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

        public DbSet<GmoOrder> Orders { get; set; }
    }
}
