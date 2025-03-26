using System.Text;
using System.IO;

namespace csharp_advanced_library
{
	public class Interfaces
	{
		public interface ILogger
		{
			void LogMessage(string message);
		}

		public class FileLogger : ILogger
		{
			private const string FilePath = @"Logs\log.txt";

			public void LogMessage(string message)
			{
				using StreamWriter sw = new(FilePath, true);
				sw.WriteLine($"Nieuwe log: {message}");
			}
		}

		public class ConsoleLogger : ILogger
		{
			public void LogMessage(string message)
			{
				Console.WriteLine(message);
			}
		}

		public class ConsoleFileLogger : ILogger
		{
			private const string FilePath = @"Logs\log.txt";

			public void LogMessage(string message)
			{
				using StreamWriter sw = new(FilePath, true);
				sw.WriteLine($"Nieuwe log: {message}");
				Console.WriteLine($"Nieuwe log: {message}");
			}
		}
	}
}
