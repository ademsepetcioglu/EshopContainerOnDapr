using EshopContainerOnDapr.Data;
using Order.Domain.AggregatesModel.AddressAggregate;
using Order.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(OrderDbContext dbContext) : base(dbContext)
        {
        }
    }
}
