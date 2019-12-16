using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.BusinessLogic
{
	public class SimpleCalculator
	{
		readonly ILogger m_logger;

		public SimpleCalculator(ILogger logger)
		{
			m_logger = logger;
		}



		public int Add(int a, int b)
		{
			m_logger.Log($"Add method called with params: a={a} b={b}");


			return a + b;
		}
	}
}
