using System.Collections.Generic;

namespace Decorator.Decorators;

class MessageDatabaseDecorator : MailServiceDecoratorBase
{
	public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
	{
	}

	public List<string> SentMessages { get; private set; } = [];

	public override bool SendMail(string message)
	{
		if (base.SendMail(message))
		{
			SentMessages.Add(message);
			return true;
		}

		return false;
	}
}
