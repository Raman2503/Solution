using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class CardTests
	{
		[Test]
		public void CreateCardWithRankAndSuite()
		{
			Card card1 = new Card(Rank.Jack,Suit.Clubs);

			Card card2 = new Card(Rank.King, Suit.Hearts);
		  
			Console.WriteLine(card1.ToString());
			Console.WriteLine(card2.ToString());
		}

		[Test]
		public void CreateCardWithInvalidValues()
		{
			Card card1 = new Card(Rank.King,Suit.Diamonds);

			Console.WriteLine(card1.ToString());
		}


		[Test]
		public void CardEqualityTest()
		{
			Card card1 = new Card(Rank.King, Suit.Diamonds);
			Card card2 = new Card(Rank.King, Suit.Diamonds);


			Assert.AreEqual(card1, card2);

			//uncomment next line to see that two cards are not same references
			//Assert.AreSame(card1, card2);
		}
	}
}
