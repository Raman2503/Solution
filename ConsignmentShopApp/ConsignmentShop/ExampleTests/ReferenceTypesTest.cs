using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using NUnit.Framework;

namespace ExampleTests
{
	public class Dummy : IEquatable<Dummy>
	{
		public string Name { get; set; }

		public int Number { get; set; }

		public override string ToString()
		{
			return $"{Name} {Number}";
		}

		public bool Equals(Dummy other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Name == other.Name && Number == other.Number;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Dummy)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ Number;
			}
		}
	}


	public struct Zuzu
	{
		public string Name { get; set; }

		public int Number { get; set; }

		public override string ToString()
		{
			return $"{Name} {Number}";
		}
	}



	[TestFixture]
	public class ReferenceTypesTest
	{
		[Test]
		public void TestMethod1()
		{
			var d1 = new Dummy() {Name = "dummy1", Number = 3};

			var d2 = d1;

			d2.Number = 5;



			var z1 = new Zuzu() {Name = "zuzu1", Number = 3};

			var z2 = z1;

			z2.Number = 5;


			//----------------
			int i1 = 4;

			int i2 = i1;


			List<int> list1 = new List<int>() { 1,2,3};
			List<int> list2 = list1.ToList();


			list2.Add(9);

			//-------------------------


			var t1 = new Dummy() { Name = "dummy1", Number = 3 };
			var t2 = new Dummy() { Name = "dummy1", Number = 3 };


			if (t1.Equals(t2)) 
			{
				Debug.WriteLine("Equal");
			}
			else
			{
				Debug.WriteLine("not Equal");
			};

			//-------------------------


			var y1 = new Zuzu() { Name = "zuzu1", Number = 3 };
			var y2 = new Zuzu() { Name = "zuzu1", Number = 3 };


			if (Equals(y1, y2))
			{
				Debug.WriteLine("Equal");
			}
			else
			{
				Debug.WriteLine("not Equal");
			};
		}
	}
}
