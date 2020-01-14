using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace ExampleTests
{
	[TestFixture]
	public class MyRefTypeExercises
	{
		public class SomeIntegers
		{
			int number1 = 4;
			int number2 = number1;

			int res = number1 + number2;
		}
		[Test]
		public bool Equals(SomeIntegers res)
		{
			if (ReferenceEquals(5, res)) 
			{
				Debug.WriteLine("Equal");
			}
			else
			{
				Debug.WriteLine("Not Equal");
			};
		}
	}
}