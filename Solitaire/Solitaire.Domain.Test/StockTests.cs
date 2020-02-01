using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solitaire.Domain.Test
{
    [TestClass]
    public class StockTests
    {
        [TestMethod]
        public void StockInitializeTest()
        {
            //Arrange
            Stock stock = new Stock();

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
            Assert.AreEqual(1, openCards.Count);
			Assert.AreEqual(4, closedCards.Count);
            Assert.AreEqual(initialCards.First(), openCards.First());
			Assert.AreEqual(initialCards[1], closedCards[0]);
			Assert.AreEqual(initialCards.Last() , closedCards[3]); // may be edited
            Assert.IsFalse(stock.IsEmpty);
        }

        [TestMethod]
        public void DrawNewCardTest()
        {
            //Arrange
            Stock stock = new Stock();

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

		[TestMethod]
		// This test checks if the stock pile contains 24 cards and outputs the cards on the console.
		public void CheckNumberOfCompleteCardsInStock()
		{
			//Arrange
			Stock stock = new Stock();

			CardDeck deck = CardDeckFactory.GenerateDeck();

			var completeStock = deck.Cards.Take(24).ToList();

			//Act
			var stockCards = stock.CreateCompleteStock(completeStock);

			//Assert
			Assert.AreEqual(24,stockCards.Count);

			foreach (Card card in stock.StockCards)
			{
				Console.WriteLine(card.ToString());
			}
		}
	}
}
