using EshopContainerOnDapr.Data;
using Order.Domain.AggregatesModel.OrderItemAggregate;
using Order.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Repositories
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(OrderDbContext dbContext) : base(dbContext)
        {
        }
    }
}
