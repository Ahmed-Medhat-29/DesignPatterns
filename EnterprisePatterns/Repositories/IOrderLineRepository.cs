using EnterprisePatterns.Entities;

namespace EnterprisePatterns.Repositories;

interface IOrderLineRepository : IRepository<OrderLine>
{
    Task<IEnumerable<OrderLine>> GetAllByOrderId(int orderId);
}
