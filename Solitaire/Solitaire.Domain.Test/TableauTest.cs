using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class TableauTests
	{
		public IEnumerable<TestCaseData> TableauInitializeTestCases
		{
			get
			{
				yield return new TestCaseData(
					null,
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
					new List<Card>() { }
				).SetName("Null case").Throws(typeof(ArgumentNullException));

				yield return new TestCaseData(
					new List<List<Card>>() { },
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
					new List<Card>() { }
				).SetName("Empty case");

				yield return new TestCaseData(
					new List<List<Card>>()
					{
						new List<Card>() {new Card(Rank.Ace, Suit.Diamonds)},
						new List<Card>() { },
						new List<Card>() { },                       
						new List<Card>() { },                       
						new List<Card>() { },
						new List<Card>() { },
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
					},
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
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Diamonds),
						new Card(Rank.Ace, Suit.Spades),
						new Card(Rank.King, Suit.Diamonds),
						new Card(Rank.Four, Suit.Diamonds),
						new Card(Rank.Nine, Suit.Clubs),
						new Card(Rank.Six, Suit.Hearts),
						new Card(Rank.Queen, Suit.Hearts)
					}).SetName("Pile 1 and 7 initialized");


				yield return new TestCaseData(
					new List<List<Card>>()
					{
						new List<Card>() {new Card(Rank.Ace, Suit.Diamonds)},
						new List<Card>() 
						{
							new Card(Rank.Eight, Suit.Diamonds),
							new Card(Rank.Ace, Suit.Spades)

						},
						new List<Card>()  
						{   new Card(Rank.King, Suit.Hearts),
							new Card(Rank.Queen, Suit.Spades),
							new Card(Rank.Four, Suit.Clubs)
						},
						new List<Card>()
						{   new Card(Rank.Three, Suit.Hearts),
							new Card(Rank.Queen, Suit.Diamonds),
							new Card(Rank.Seven, Suit.Clubs), 
							new Card(Rank.Nine, Suit.Hearts)
						},
						new List<Card>()
						{   new Card(Rank.Ace, Suit.Hearts),
							new Card(Rank.Five, Suit.Diamonds),
							new Card(Rank.Seven, Suit.Spades),
							new Card(Rank.Eight, Suit.Hearts),
							new Card(Rank.Eight, Suit.Clubs)
						},
						new List<Card>()
						{   new Card(Rank.Two, Suit.Diamonds),
							new Card(Rank.Ten, Suit.Diamonds),
							new Card(Rank.Queen, Suit.Clubs),
							new Card(Rank.Two, Suit.Hearts),
							new Card(Rank.Eight, Suit.Clubs),
							new Card(Rank.Four, Suit.Diamonds)
						},                      
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
					},
					// expected Pile 1
					new List<Card>() { new Card(Rank.Ace, Suit.Diamonds) },
					// expected Pile 2
					new List<Card>()
					{
						new Card(Rank.Eight, Suit.Diamonds),
						new Card(Rank.Ace, Suit.Spades)

					},
					// expected Pile 3
					new List<Card>()
					{   new Card(Rank.King, Suit.Hearts),
						new Card(Rank.Queen, Suit.Spades),
						new Card(Rank.Four, Suit.Clubs)
					},
					// expected Pile 4
						new List<Card>()
					{   new Card(Rank.Three, Suit.Hearts),
						new Card(Rank.Queen, Suit.Diamonds),
						new Card(Rank.Seven, Suit.Clubs),
						new Card(Rank.Nine, Suit.Hearts)
					},
						
					// expected Pile 5
						new List<Card>()
					{   new Card(Rank.Ace, Suit.Hearts),
						new Card(Rank.Five, Suit.Diamonds),
						new Card(Rank.Seven, Suit.Spades),
						new Card(Rank.Eight, Suit.Hearts),
						new Card(Rank.Eight, Suit.Clubs)
					},
						
					// expected Pile 6
						new List<Card>()
					{   new Card(Rank.Two, Suit.Diamonds),
						new Card(Rank.Ten, Suit.Diamonds),
						new Card(Rank.Queen, Suit.Clubs),
						new Card(Rank.Two, Suit.Hearts),
						new Card(Rank.Eight, Suit.Clubs),
						new Card(Rank.Four, Suit.Diamonds)
					},                  
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
					}).SetName("All Piles initialized");
			}
		}

		/// <summary>
		/// This test checks, whether the the tableau is correctly initialized.
		/// </summary>
		/// <param name="initialTableauPiles"></param>
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
			List <List<Card>> initialTableauPiles,
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
			tableau.Initialize(initialTableauPiles);


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
