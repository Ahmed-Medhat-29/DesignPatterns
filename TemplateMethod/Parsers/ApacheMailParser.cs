using System;

namespace TemplateMethod.Parsers;

class ApacheMailParser : MailParser
{
    public override void AuthenticateToServer()
    {
        Console.WriteLine("Connecting to Apache");
    }
}
