using System;

using Examples;
using Examples.BusinessLogic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

namespace ExampleTests
{
	[TestClass]
	public class CalculatorTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			var loggerMock = new Mock<ILogger>();

			var calculator = new SimpleCalculator(loggerMock.Object);

			// Act 
			var result = calculator.Add(1, 2);

			// Assert
			Assert.AreEqual(result, 3);
		}
	}
}
