using System;

namespace Proxy;

class ProtectedDocumentProxy : IDocument
{
	private readonly string _fileName;
	private readonly string _userRole;
	private readonly DocumentProxy _documentProxy;

	public ProtectedDocumentProxy(string fileName, string userRole)
	{
		_fileName = fileName;
		_userRole = userRole;
		_documentProxy = new DocumentProxy(_fileName);

	}

	public void DisplayDocument()
	{
		Console.WriteLine($"Entering DisplayDocument in {nameof(ProtectedDocumentProxy)}.");

		if (_userRole != "Viewer") throw new UnauthorizedAccessException();

		_documentProxy.DisplayDocument();

		Console.WriteLine($"Exiting DisplayDocument in {nameof(ProtectedDocumentProxy)}.");
	}
}
