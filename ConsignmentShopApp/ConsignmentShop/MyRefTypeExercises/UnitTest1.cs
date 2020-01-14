using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyRefTypeExercises
{
	[TestClass]
	public class RefTypeTests
	{
		public class IntegerValue
		{
			public int Val { get; set; } = 5;
		}

		[TestMethod]
		public void ValueTypeIntegersTest()
		{
			IntegerValue int1 = new IntegerValue();
			IntegerValue int2 = new IntegerValue();

			var res = int1.Val+int2.Val;
			// Here res is 10.
			Assert.AreEqual(res, 10);

			int1.Val = 100;
			res = int1.Val + int2.Val;
			//num1 is now changed to 100. However, int2.val remains 5, as both are local variables (value types).
			Assert.AreEqual(res, 105);
		}

		[TestMethod]
		public void RefTypeIntegersTest()
		{
			IntegerValue int1 = new IntegerValue();
			IntegerValue int2 = int1;

			var res = int1.Val + int2.Val;

			// Here res is 10.
			Assert.AreEqual(res, 10);

			int1.Val = 100;
			res = int1.Val + int2.Val;
			// Now res = 200 is expected, as int1.val has changed. 
			//Because int1 points to int2 it also changes int2.val.
			// Here Reference Types are used, so res = 105 is not expected this time.
			Assert.AreEqual(res, 200);
		}

	/*---------------------------------------------------------------------------------------
	 ----------------------------------------------------------------------------------------
	 ----------------------------------------------------------------------------------------*/

	public struct PersonDataStruct
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

	public class PersonDataClass
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

		[TestMethod]
		public void PersonDataStructTest()
		{
			var person1 = new PersonDataStruct() {Name = "John", Age = 25};
			var person2 = new PersonDataStruct() { Name = "Paul", Age = 36 };

			//person1 and person2 are obviously not equal
			Assert.AreNotEqual(person1.Age, person2.Age);

			person2 = person1;
			person2.Age = 30;

			//Both persons age still do not match.
			//Only age of person2 has been changed, because a value type is used here (struct).
			Assert.AreNotEqual(person1.Age, person2.Age);
		}

		[TestMethod]
		public void PersonDataClassTest()
		{
			var person1 = new PersonDataClass() { Name = "John", Age = 25 };
			var person2 = new PersonDataClass() { Name = "Paul", Age = 36 };

			person2 = person1;
			person2.Age = 30;

			/*Now both persons age have been changed by assigning a new value for age of person2, 
			as a RefType is used here (Objects)*/
			Assert.AreEqual(person1.Age, person2.Age);
		}
	}
}
