using System.Linq;

namespace Solitaire.Domain
{
	// A deck consists of 52 cards.
	public class CardDeckFactory
	{
		CardDeck CardDeck { get;}

		public CardDeckFactory(CardDeck deck)
		{
			CardDeck = deck;
		}

	    public CardDeck GenerateDeck()
		{
			var cards = Enumerable
                .Range(1, 4)
                .SelectMany(suit => Enumerable.Range(1, 13)
                    .Select(rank => new Card((Rank)rank, (Suit)suit)).ToList());


			CardDeck.Cards.AddRange(cards);

			return CardDeck;
		}
	}
}
