using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibility.Handlers;

class DocumentTitleHandler : IHandler<Document>
{
	private IHandler<Document> _successor;

	public void Handle(Document document)
	{
		if (!document.ApprovedByManagement)
		{
			throw new ValidationException(
				new ValidationResult( "Document must be approved by management", ["ApprovedByManagement"]),
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
