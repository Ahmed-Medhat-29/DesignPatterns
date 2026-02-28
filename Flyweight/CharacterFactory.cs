using Flyweight.Characters;
using Flyweight.Unshared;
using System;
using System.Collections.Generic;

namespace Flyweight;

class CharacterFactory
{
	private readonly Dictionary<char, ICharacter> _characters = [];

	public ICharacter GetCharacter(char character)
	{
		if(_characters.TryGetValue(character, out var charInstance))
		{
			Console.WriteLine("Character reuse");
			return charInstance;
		}

		Console.WriteLine("Character construction");
		switch (character)
		{
			case 'a':
				_characters[character] = new CharacterA();
				return _characters[character];
			case 'b':
				_characters[character] = new CharacterB();
				return _characters[character];
			default:
				return null;
		}
	}

	public ICharacter CreateParagraph(List<ICharacter> characters, int location)
	{
		return new Paragraph(characters, location);
	}
}
