namespace EnterprisePatterns.UnitsOfWork;

interface IUnitOfWork
{
	Task CommitAsync();
	void Rollback();
}
