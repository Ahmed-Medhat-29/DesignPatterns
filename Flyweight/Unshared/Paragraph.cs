using System;
using System.Collections.Generic;

namespace Flyweight.Unshared;

class Paragraph : ICharacter
{
	private readonly List<ICharacter> _characters;
	private readonly int _location;

	public Paragraph(List<ICharacter> characters, int location)
	{
		_characters = characters;
		_location = location;
	}

	public void Draw(string fontFamily, int fontSize)
	{
		Console.WriteLine($"Drawing in paragraph at location {_location}");

		foreach (var character in _characters)
		{
			character.Draw(fontFamily, fontSize);
		}
	}
}
