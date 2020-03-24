using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Solitaire.Domain.Test
{
    [TestFixture]
    public class StockTests
    {
        [Test]
        public void StockInitializeTest()
        {
			//Arrange
			Tableau tableau = new Tableau();

			Foundation foundation = new Foundation();

            Stock stock = new Stock(tableau,foundation);

            List<Card> initialCards = new List<Card>()
            {
                new Card(Rank.Ace, Suit.Clubs),
                new Card(Rank.Four, Suit.Diamonds),
                new Card(Rank.Eight, Suit.Hearts),
                new Card(Rank.Ace, Suit.Spades),
                new Card(Rank.King, Suit.Clubs),
            };

            //Act
            stock.Initialize(initialCards);

            List<Card> openCards = stock.GetOpenCards();
			List<Card> closedCards = stock.GetClosedCards();

			//Assert
			Assert.IsFalse(stock.IsEmpty);

			Assert.AreEqual(1, openCards.Count);
			Assert.AreEqual(initialCards.First(), openCards.First());

			Assert.AreEqual(4, closedCards.Count);
			Assert.AreEqual(initialCards[1], closedCards[0]);
			Assert.AreEqual(initialCards.Last() , closedCards[3]); // may be edited
        }

        [Test]
        public void DrawNewCardTest()
        {
			//Arrange
			Tableau tableau = new Tableau();
			Foundation foundation = new Foundation();

            Stock stock = new Stock(tableau,foundation);

            List<Card> initialCards = new List<Card>()
            {
                new Card(Rank.Ace, Suit.Clubs),
                new Card(Rank.Four, Suit.Diamonds),
                new Card(Rank.Eight, Suit.Hearts),
                new Card(Rank.Ace, Suit.Spades),
                new Card(Rank.King, Suit.Clubs),
            };

            //Act
            stock.Initialize(initialCards);

            List<Card> openCards = stock.GetOpenCards();
			List<Card> closedCards = stock.GetClosedCards();

            stock.DrawFromStock();

            //Assert
            Assert.AreEqual(initialCards[1],openCards.First());
            Assert.AreEqual(2,openCards.Count);

			Assert.AreEqual(3, closedCards.Count);
			Assert.AreEqual(initialCards[2], closedCards[0]);
			Assert.AreEqual(initialCards.Last(), closedCards[2]);
        }
	}
}
