using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Examples
{
	public interface ILogger
	{
		void Log(string message);
	}

	public class CompositeLogger : ILogger
	{
		readonly List<ILogger> m_loggers;

		public CompositeLogger(List<ILogger> loggers)
		{
			m_loggers = loggers;
		}


		public void Log(string message)
		{
			foreach (var logger in m_loggers)
			{
				logger.Log(message);
			}
		}
	}

	public class DebugOutputLogger : ILogger
	{
		public void Log(string message)
		{
			Debug.WriteLine(message);
		}
	}

	public class ConsoleLogger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}

	public class FileLogger : ILogger
	{
		public void Log(string message)
		{
			File.AppendAllText("C://log.txt", message);
		}
	}
}
