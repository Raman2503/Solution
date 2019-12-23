using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using NUnit.Framework;

namespace ExampleTests
{
	class SomeData
	{
		public List<int> Numbers { get; set; }
		public List<SomeItem> Items { get; set; }
	}

	public class SomeItem
	{
		public string Name { get; set; }

		public int Count { get; set; }
	}


	[TestFixture]
	public class UnitJsonTests
	{
		[Test]
		public void JsonSaveTest()
		{
			var data = new SomeData();

			data.Numbers = new List<int>() { 3,4,5,6,7};
			data.Items = new List<SomeItem>()
			{
				new SomeItem() {Name = "dummy1", Count = 5},
				new SomeItem() {Name = "dummy2", Count = 6},
				new SomeItem() {Name = "dummy3", Count = 7},
				new SomeItem() {Name = "dummy4", Count = 8},
				new SomeItem() {Name = "dummy5", Count = 9},
				new SomeItem() {Name = "dummy6", Count = 0},
			};


			var serializedObject = JsonConvert.SerializeObject(data, Formatting.Indented);

			File.WriteAllText("C:\\Tests\\serializedData.txt", serializedObject);
		}



		[Test]
		public void JsonLoadTest()
		{
			var allText = File.ReadAllText("C:\\Tests\\serializedData.txt");

			SomeData data = JsonConvert.DeserializeObject<SomeData>(allText);


		}
	}
}
