using System;

namespace Singleton;

class Logger
{
	// Not thread-safe implementation
	//private static Logger _logger;

	//public static Logger Instance
	//{
	//	get
	//	{
	//		if (_logger is null)
	//		{
	//			_logger = new Logger();
	//		}

	//		return _logger;
	//	}
	//}

	// Thread-safe implementation
	private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

	public static Logger Instance
	{
		get
		{
			return _lazyLogger.Value;
		}
	}

	protected Logger()
	{

	}

	public void Log(string message)
	{
		Console.WriteLine($"Message to log: {message}");
	}
}
