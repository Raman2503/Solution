using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	// A deck consists of 52 cards.
	public static class CardDeckFactory
	{

	    public static CardDeck GenerateDeck()
		{
            CardDeck deck = new CardDeck();

			var cards = Enumerable
                .Range(1, 4)
                .SelectMany(suit => Enumerable.Range(1, 13)
                    .Select(rank => new Card((Rank)rank, (Suit)suit)).ToList());

            deck.Cards.AddRange(cards);

			return deck;
		}
	}
}
