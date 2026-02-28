using System;

namespace Flyweight.Characters;

class CharacterA : ICharacter
{
	private const char _character = 'a';
	private string _fontFamily = string.Empty;
	private int _fontSize;

	public void Draw(string fontFamily, int fontSize)
	{
		_fontFamily = fontFamily;
		_fontSize = fontSize;

		Console.WriteLine($"Drawing {_character}, {_fontFamily} {_fontSize}");
	}
}
