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

            //Assert
            Assert.AreEqual(1, openCards.Count);
            Assert.AreEqual(initialCards.First(), openCards.First());
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

            stock.DrawFromStock();

            //Assert
            Assert.AreEqual(initialCards[1],openCards.First());
            Assert.AreEqual(2,openCards.Count);
        }

    }
}
