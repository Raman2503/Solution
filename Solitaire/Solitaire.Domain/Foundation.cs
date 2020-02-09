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
			FoundationPileClubs.Add(initialFoundationCards[0]);

			FoundationPileDiamonds.Add(initialFoundationCards[1]);

			FoundationPileHearts.Add(initialFoundationCards[2]);

			FoundationPileSpades.Add(initialFoundationCards[3]);

			IsEmpty = false;
		}

		public void MoveCardToFoundation(Card nextCardHearts, 
										 Card newCardSpades, 
										 Card newCardDiamonds, 
										 Card newCardClubs)
		{
			 if (newCardClubs.Rank - FoundationPileClubs.Last().Rank == 1 && newCardClubs.Suit == Suit.Clubs)
				FoundationPileClubs.Add(newCardClubs);

			 if (newCardDiamonds.Rank - FoundationPileDiamonds.Last().Rank == 1 && newCardDiamonds.Suit == Suit.Diamonds)
				FoundationPileDiamonds.Add(newCardDiamonds);

			 if (newCardSpades.Rank - FoundationPileSpades.Last().Rank == 1 && newCardSpades.Suit == Suit.Spades)
				FoundationPileSpades.Add(newCardSpades);

			 if (nextCardHearts.Rank - FoundationPileHearts.Last().Rank == 1 && nextCardHearts.Suit == Suit.Hearts)
				FoundationPileHearts.Add(nextCardHearts);

		}
	}
}
