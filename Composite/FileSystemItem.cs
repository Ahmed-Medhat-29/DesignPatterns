namespace Composite;

abstract class FileSystemItem
{
	public FileSystemItem(string name)
	{
		Name = name;
	}

	public string Name { get; }

	public abstract long GetSize();
}
