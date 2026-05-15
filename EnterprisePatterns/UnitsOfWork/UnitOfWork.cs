using EnterprisePatterns.DbContexts;

namespace EnterprisePatterns.UnitsOfWork;

abstract class UnitOfWork : IUnitOfWork
{
	private readonly OrderDbContext _dbContext;

	public UnitOfWork(OrderDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task CommitAsync()
	{
		await _dbContext.SaveChangesAsync();
	}

	public void Rollback()
	{
		_dbContext.ChangeTracker.Clear();
	}
}
