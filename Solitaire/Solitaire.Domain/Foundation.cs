using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	public class Foundation
	{
		public List<Card> FoundationPileClubs { get; set; } = new List<Card>();
		public List<Card> FoundationPileDiamonds { get; set; } = new List<Card>();
		public List<Card> FoundationPileHearts { get; set; } = new List<Card>();
		public List<Card> FoundationPileSpades { get; set; } = new List<Card>();


		/// <summary>
		/// This property checks that all foundation piles are initially empty.
		/// </summary>
		public bool IsEmpty { get; set; } = true;

		public void Initialize(List<Card> initialFoundationCards)
		{
			if(initialFoundationCards[0].Rank==Rank.Ace)
			FoundationPileClubs.Add(initialFoundationCards[0]);

			if (initialFoundationCards[1].Rank == Rank.Ace)
			FoundationPileDiamonds.Add(initialFoundationCards[1]);

			if (initialFoundationCards[2].Rank == Rank.Ace)
			FoundationPileHearts.Add(initialFoundationCards[2]);

			if (initialFoundationCards[3].Rank == Rank.Ace)
			FoundationPileSpades.Add(initialFoundationCards[3]);

			IsEmpty = false;
		}

		public void MoveCardToFoundation(Card nextCard)
		{
			if (nextCard.Rank - FoundationPileClubs.Last().Rank == 1 && nextCard.Suit == Suit.Clubs)
				FoundationPileClubs.Add(nextCard);

			else if (nextCard.Rank - FoundationPileDiamonds.Last().Rank == 1 && nextCard.Suit == Suit.Diamonds)
				FoundationPileDiamonds.Add(nextCard);

			else if (nextCard.Rank - FoundationPileHearts.Last().Rank == 1 && nextCard.Suit == Suit.Hearts)
				FoundationPileHearts.Add(nextCard);

			else if (nextCard.Rank - FoundationPileSpades.Last().Rank == 1 && nextCard.Suit == Suit.Spades)
				FoundationPileSpades.Add(nextCard);
		}
	}
}
