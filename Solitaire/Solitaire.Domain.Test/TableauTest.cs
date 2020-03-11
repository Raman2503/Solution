using NUnit.Framework;
using System.Collections.Generic;


namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class TableauTests
	{
		public System.Collections.Generic.IEnumerable<TestCaseData> TableauInitializeTestCases
		{
			get
			{
				yield return new TestCaseData(
					new List<Card>() {new Card(Rank.Ace, Suit.Diamonds)},
					// expected Pile 1
					new List<Card>() {new Card(Rank.Ace, Suit.Diamonds)},
					// expected Pile 2
					new List<Card>() { },
					// expected Pile 3
					new List<Card>() { },
					// expected Pile 4
					new List<Card>() { },
					// expected Pile 5
					new List<Card>() { },
					// expected Pile 6
					new List<Card>() { },
					// expected Pile 7
					new List<Card>() { }
				).SetName("Pile 1 initialized");

				yield return new TestCaseData(
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Diamonds),
						new Card(Rank.Ace, Suit.Spades),
						new Card(Rank.King, Suit.Diamonds),
						new Card(Rank.Four, Suit.Diamonds),
						new Card(Rank.Nine, Suit.Clubs),
						new Card(Rank.Six, Suit.Hearts),
						new Card(Rank.Queen, Suit.Hearts)
					},
					// expected Pile 1
					new List<Card>() { },
					// expected Pile 2
					new List<Card>() { },
					// expected Pile 3
					new List<Card>() { },
					// expected Pile 4
					new List<Card>() { },
					// expected Pile 5
					new List<Card>() { },
					// expected Pile 6
					new List<Card>() { },
					// expected Pile 7
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Diamonds),
						new Card(Rank.Ace, Suit.Spades),
						new Card(Rank.King, Suit.Diamonds),
						new Card(Rank.Four, Suit.Diamonds),
						new Card(Rank.Nine, Suit.Clubs),
						new Card(Rank.Six, Suit.Hearts),
						new Card(Rank.Queen, Suit.Hearts)
					}
				).SetName("Pile 7 initialized");

				yield return new TestCaseData(
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Diamonds),
						new Card(Rank.Queen, Suit.Spades),
						new Card(Rank.King, Suit.Diamonds),
						new Card(Rank.Four, Suit.Diamonds),
						new Card(Rank.Nine, Suit.Clubs),
						new Card(Rank.Six, Suit.Hearts),
					},
					// expected Pile 1
					new List<Card>() { },
					// expected Pile 2
					new List<Card>() { },
					// expected Pile 3
					new List<Card>() { },
					// expected Pile 4
					new List<Card>() { },
					// expected Pile 5
					new List<Card>() { },
					// expected Pile 6
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Diamonds),
						new Card(Rank.Queen, Suit.Spades),
						new Card(Rank.King, Suit.Diamonds),
						new Card(Rank.Four, Suit.Diamonds),
						new Card(Rank.Nine, Suit.Clubs),
						new Card(Rank.Six, Suit.Hearts),
					},
				// expected Pile 7
				new List<Card>() { }
					).SetName("Pile 6 initialized");
			}
		}

		/// <summary>
		/// This test checks, whether the the tableau is correctly initialized.
		/// </summary>
		/// <param name="initialTableauCards"></param>
		/// <param name="expectedPile1"></param>
		/// <param name="expectedPile2"></param>
		/// <param name="expectedPile3"></param>
		/// <param name="expectedPile4"></param>
		/// <param name="expectedPile5"></param>
		/// <param name="expectedPile6"></param>
		/// <param name="expectedPile7"></param>
		[Test]
		[TestCaseSource(nameof(TableauInitializeTestCases))]
		public void TableauInitializeTest(
			List<Card> initialTableauCards,
			List<Card> expectedPile1,
			List<Card> expectedPile2,
			List<Card> expectedPile3,
			List<Card> expectedPile4,
			List<Card> expectedPile5,
			List<Card> expectedPile6,
			List<Card> expectedPile7
		)
		{
			//Arrange
			Tableau tableau = new Tableau();

			//Act
			tableau.Initialize(initialTableauCards);


			//Assert
			CollectionAssert.AreEqual(expectedPile1, tableau.TableauPile1);
			CollectionAssert.AreEqual(expectedPile2, tableau.TableauPile2);
			CollectionAssert.AreEqual(expectedPile3, tableau.TableauPile3);
			CollectionAssert.AreEqual(expectedPile4, tableau.TableauPile4);
			CollectionAssert.AreEqual(expectedPile5, tableau.TableauPile5);
			CollectionAssert.AreEqual(expectedPile6, tableau.TableauPile6);
			CollectionAssert.AreEqual(expectedPile7, tableau.TableauPile7);
		}

	}
}
