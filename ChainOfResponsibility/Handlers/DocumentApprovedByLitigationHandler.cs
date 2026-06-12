using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibility.Handlers;

class DocumentApprovedByLitigationHandler : IHandler<Document>
{
	private IHandler<Document> _successor;

	public void Handle(Document document)
	{
		if (!document.ApprovedByLitigation)
		{
			throw new ValidationException(
				new ValidationResult("Document must be approved by litigation", ["ApprovedByLitigation"]),
				null,
				null);
		}

		_successor?.Handle(document);
	}

	public IHandler<Document> SetSuccessor(IHandler<Document> successor)
	{
		_successor = successor;
		return successor;
	}
}
