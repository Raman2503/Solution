using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	// A deck consists of 52 cards.
	public class CardDeckGenerator
	{
		CardDeck deck = new CardDeck();

	public List<Card> GenerateDeck()
		{
			deck.Cards = Enumerable.Range(1, 4).SelectMany(suit => Enumerable.Range(1, 13).Select(rank => new Card()
			{
				Suit = (Suit)suit,
				Rank = (Rank)rank
			})).ToList();

			return deck.Cards;
		}
	}
}
