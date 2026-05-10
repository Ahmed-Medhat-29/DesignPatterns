using EnterprisePatterns.Entities;
using EnterprisePatterns.Repositories;

namespace EnterprisePatterns.Services;

class RepositoryDemoService(IRepository<Order> genericOrderRepository,
    IOrderLineRepository orderLineRepository)
{
    private readonly IRepository<Order> _genericOrderRepository = genericOrderRepository;
    private readonly IOrderLineRepository _orderLineRepository = orderLineRepository;

    public async Task RunAsync()
    {
        var order = await _genericOrderRepository.Get(1);

        if(order != null)
        {
            order.Description = "Updated Description";
            await _genericOrderRepository.SaveChanges();

            var orderLine = new OrderLine("Skirt", 1) { OrderId = 1 };
            _orderLineRepository.Add(orderLine);

            await _orderLineRepository.SaveChanges();
        }
    }
}
