using System;

namespace TemplateMethod.Parsers;

class ExchangeMailParser : MailParser
{
    public override void AuthenticateToServer()
    {
        Console.WriteLine("Connecting to Exchange");
    }
}
