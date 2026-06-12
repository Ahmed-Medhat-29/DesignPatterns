using System;
using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibility.Handlers;

class DocumentLastModifiedHandler : IHandler<Document>
{
	private IHandler<Document> _successor;

	public void Handle(Document document)
	{
		if (document.LastModified < DateTime.UtcNow.AddDays(-30))
		{
			throw new ValidationException(
				new ValidationResult("Document must be modified in the last 30 days", ["LastModified"]),
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
