using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	public class Stock
	{
		public List<Card> StockCards { get; } = new List<Card>();
		public List<Card> OpenCards { get; set; } = new List<Card>();
		public List<Card> ClosedCards { get; set; } = new List<Card>();

		/// <summary>
		/// This property checks whether the stock pile is empty.
		/// </summary>
		public bool IsEmpty { get; set; } = false;

		public void Initialize(List<Card> initialCards)
		{
			StockCards.AddRange(initialCards);
		}

		public List<Card> GetOpenCards()
		{
			OpenCards.Add(StockCards.First());
			return OpenCards;
		}

		public List<Card> GetClosedCards()
		{
			ClosedCards.AddRange(StockCards);
			ClosedCards.RemoveRange(0,OpenCards.Count);
			return ClosedCards;
		}

		public void DrawFromStock()
		{
			OpenCards.Insert(0, (StockCards[1]));
			ClosedCards.Remove(StockCards[1]);
		}

		public List<Card> CreateCompleteStock(List<Card> completeStock)
		{
			StockCards.AddRange(completeStock);
			return StockCards;
		}
	}
}
