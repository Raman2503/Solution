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
		public bool IsEmpty
		{
			get
			{
				if (FoundationPileClubs.Any())
					return false;
				if (FoundationPileHearts.Any())
					return false;
				if (FoundationPileDiamonds.Any())
					return false;
				if (FoundationPileSpades.Any())
					return false;
				return true;
			}
		}

		public void Initialize(List<Card> initialFoundationCards)
		{
			foreach (var card in initialFoundationCards)
			{
				MoveCardToFoundation(card);
			}
		}

		public void MoveCardToFoundation(Card card)
		{
			switch (card.Suit)
			{
				case Suit.Clubs:
					FoundationPileClubs.Add(card);
					break;
				case Suit.Diamonds:
					FoundationPileDiamonds.Add(card);
					break;
				case Suit.Hearts:
					FoundationPileHearts.Add(card);
					break;
				case Suit.Spades:
					FoundationPileSpades.Add(card);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

		}
	}
}
