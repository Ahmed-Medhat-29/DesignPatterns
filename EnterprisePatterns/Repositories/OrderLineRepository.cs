using EnterprisePatterns.DbContexts;
using EnterprisePatterns.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterprisePatterns.Repositories;

class OrderLineRepository : GenericEFCoreRepository<OrderLine>, IOrderLineRepository
{
    private readonly OrderDbContext _dbContext;

    public OrderLineRepository(OrderDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<OrderLine>> GetAllByOrderId(int orderId)
    {
        return await _dbContext.OrderLines.Where(o => o.OrderId == orderId).ToListAsync();
    }
}
