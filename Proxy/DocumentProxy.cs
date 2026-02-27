using System;

namespace Proxy;

class DocumentProxy : IDocument
{
	private readonly Lazy<Document> _document;
	private readonly string _fileName;

	public DocumentProxy(string fileName)
	{
		_fileName = fileName;
		_document = new Lazy<Document>(() => new Document(_fileName));
	}

	public void DisplayDocument()
	{
		_document.Value.DisplayDocument();
	}
}
