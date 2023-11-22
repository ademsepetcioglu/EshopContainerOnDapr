using EshopContainerOnDapr.Data;
using Order.Domain.AggregatesModel.OrderAggregate;
using Order.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Domain.AggregatesModel.OrderAggregate.Order>, IOrderRepository
    {
        public OrderRepository(OrderDbContext dbContext) : base(dbContext)
        {
        }
    }
}
