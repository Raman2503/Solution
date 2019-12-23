using System;

using NUnit.Framework;

namespace ExampleTests.Interfaces
{
	[TestFixture]
	public class InterfacesTests
	{
		[Test]
		public void InterfacesTest()
		{
			Implementation imp = new Implementation();

			IInterface1 i1 = imp;

			IInterface2 i2 = imp;

			Console.WriteLine("A call from implementation directly");
			imp.DoSmth();

			Console.WriteLine("A call from interface1 ");
			i1.DoSmth();

			Console.WriteLine("A call from interface2 ");
			i2.DoSmth();

		}
	}



	interface IInterface1
	{
		void DoSmth();
		void DoSmthElse();

	}

	class Implementation : IInterface1, IInterface2
	{
		public void DoSmth()
		{
			Console.WriteLine("DoSmth()");
		}


		void IInterface2.DoSmth()
		{
			Console.WriteLine("IInterface2.DoSmth()");
		}

		public void DoSmthElse()
		{
			Console.WriteLine("DoSmthElse()");
		}
	}


	interface IInterface2
	{
		void DoSmth();
	}


}
