namespace ChainOfResponsibility;

interface IHandler<T> where T : class
{
	IHandler<T> SetSuccessor(IHandler<T> successor);
	void Handle(T request);
}
