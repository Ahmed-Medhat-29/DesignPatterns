using EnterprisePatterns.DbContexts;
using EnterprisePatterns.Entities;
using EnterprisePatterns.Repositories;

namespace EnterprisePatterns.UnitsOfWork;

class CreateOrderWithOrderLinesUnitOfWork : UnitOfWork
{
	public CreateOrderWithOrderLinesUnitOfWork(OrderDbContext dbContext,
		IRepository<Order> orderRepository,
		IOrderLineRepository orderLineRepository) : base(dbContext)
	{
		OrderRepository = orderRepository;
		OrderLineRepository = orderLineRepository;
	}

	public IRepository<Order> OrderRepository { get; }
	public IOrderLineRepository OrderLineRepository { get; }
}
