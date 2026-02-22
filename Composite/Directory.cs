using System.Collections.Generic;

namespace Composite;

class Directory : FileSystemItem
{
	private readonly List<FileSystemItem> _fileSystemItems = [];
	private readonly long _size;

	public Directory(string name, long size) : base(name)
	{
		_size = size;
	}

	public void Add(FileSystemItem itemToAdd)
	{
		_fileSystemItems.Add(itemToAdd);
	}

	public void Remove(FileSystemItem itemToRemove)
	{
		_fileSystemItems.Remove(itemToRemove);
	}

	public override long GetSize()
	{
		var treeSize = _size;
		foreach (var fileSystemItem in _fileSystemItems)
		{
			treeSize += fileSystemItem.GetSize();
		}

		return treeSize;
	}
}
