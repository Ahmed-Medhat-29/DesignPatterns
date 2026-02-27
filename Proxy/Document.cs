using System;
using System.Threading;

namespace Proxy;

class Document : IDocument
{
	private readonly string _fileName;

	public string Title { get; private set; }
	public string Content { get; private set; }
	public int AuthorId { get; private set; }
	public DateTimeOffset LastAccessed { get; private set; }

	public Document(string fileName)
	{
		_fileName = fileName;
		LoadDocument(fileName);
	}

	public void DisplayDocument()
	{
		Console.WriteLine($"Title: {Title}, Content: {Content}");
	}

	private void LoadDocument(string filename)
	{
		Console.WriteLine("Executing expensive action: loading a file from disk");

		Thread.Sleep(1000);

		Title = "An expensive document";
		Content = "Lots and lots of content";
		AuthorId = 1;
		LastAccessed = DateTimeOffset.UtcNow;
	}
}
