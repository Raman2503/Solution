using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	public class Foundation
	{
		public List<Card> FoundationCards { get; set; } = new List<Card>();
		public List<Card> FoundationPileClubs { get; set; } = new List<Card>();
		public List<Card> FoundationPileDiamonds { get; set; } = new List<Card>();
		public List<Card> FoundationPileHearts { get; set; } = new List<Card>();
		public List<Card> FoundationPileSpades { get; set; } = new List<Card>();
		public List<Card> OpenCards { get; set; } = new List<Card>();
		public List<Card> ClosedCards { get; set; } = new List<Card>();

		/// <summary>
		/// This property checks that all foundation piles are initially empty.
		/// </summary>
		public bool IsEmpty { get; set; } = true;

		public void Initialize(List<Card> initialFoundationCards)
		{
			FoundationCards.AddRange(initialFoundationCards);


			FoundationPileClubs.Add(FoundationCards[0]);
			FoundationPileDiamonds.Add(FoundationCards[1]);
			FoundationPileHearts.Add(FoundationCards[2]);
			FoundationPileSpades.Add(FoundationCards[3]);

			IsEmpty = false;
		}

		public List<Card> GetOpenCards()
		{
			OpenCards.Add(FoundationPileClubs.Last());
			OpenCards.Add(FoundationPileDiamonds.Last());
			OpenCards.Add(FoundationPileHearts.Last());
			OpenCards.Add(FoundationPileSpades.Last());

			return OpenCards;
		}

		public List<Card> GetClosedCards()
		{
			return ClosedCards;
		}
	}
}
