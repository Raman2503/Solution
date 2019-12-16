using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examples.BusinessLogic;

namespace Examples
{
	class Program
	{
		static void Main(string[] args)
		{
			// Composition ROOT

			var loggers = new List<ILogger>()
			{
				new ConsoleLogger(),
				new DebugOutputLogger()
			};

			ILogger logger = new CompositeLogger(loggers);

			var calculator = new SimpleCalculator(logger);


			//------------------
			//Run your logic


			calculator.Add(1, 2);
			calculator.Add(4, 5);
			calculator.Add(8, 9);

			logger.Log("The END");
		}
	}
}
