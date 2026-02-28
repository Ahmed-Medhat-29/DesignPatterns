using System;

namespace Flyweight;

class Program
{
	static void Main()
	{
		Console.Title = "Flyweight";

		var someCharacters = "abba";

		var characterFactory = new CharacterFactory();

		var characterObject = characterFactory.GetCharacter(someCharacters[0]);

		characterObject?.Draw("Arial", 12);

		characterObject = characterFactory.GetCharacter(someCharacters[1]);
		characterObject?.Draw("Trebuchet MS", 14);

		characterObject = characterFactory.GetCharacter(someCharacters[2]);
		characterObject?.Draw("Times New Roman", 16);

		characterObject = characterFactory.GetCharacter(someCharacters[3]);
		characterObject?.Draw("Comic Sans", 18);

		var paragraph = characterFactory.CreateParagraph([characterObject], 1);
		paragraph.Draw("Lucinda", 12);
	}
}
