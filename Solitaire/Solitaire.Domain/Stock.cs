using System.Collections.Generic;
using System.Linq;

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

		public bool CardCanBeMoved { get; set; }

		Tableau Tableau { get; set; }

		public Stock(Tableau tableau)
		{
			Tableau = tableau;
		}

		public void Initialize(List<Card> initialCards)
		{
			_ = initialCards ?? throw new System.ArgumentNullException(nameof(initialCards));

				StockCards.AddRange(initialCards);
	
		}

		public List<Card> GetOpenCards()
		{
			if (StockCards.Any())
			{
				OpenCards.Add(StockCards.First());
			}

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
			if (OpenCards.Any())
			{
				OpenCards.Insert(0, (StockCards[1]));
				ClosedCards.Remove(StockCards[1]);
			}
		}

		public List<Card> CreateCompleteStock(List<Card> completeStock)
		{
			StockCards.AddRange(completeStock);
			return StockCards;
		}

		public void CheckRankAndSuitInStockAndTableau(Card cardToBeMoved, List <Card> tableauPile)
		{
			if (tableauPile.Any())
			{
				var openCardFromTargetPile = tableauPile.First();

				if (openCardFromTargetPile.Rank - cardToBeMoved.Rank == 1)
				{

					if (cardToBeMoved.IsBlack && openCardFromTargetPile.IsRed ||
						cardToBeMoved.IsRed && openCardFromTargetPile.IsBlack)
					{

						MoveCardFromWasteToTableau(cardToBeMoved, tableauPile);
					}

					else
						Tableau.TableauPile3 = tableauPile;
				}

					else
						Tableau.TableauPile3 = tableauPile;
			}
		}


		public void MoveCardFromWasteToTableau(Card openStockCard, List<Card> tableauPile)
		{
			tableauPile.Insert(0,openStockCard);
			StockCards.Remove(openStockCard);

			Tableau.TableauPile3 = tableauPile;

			CardCanBeMoved = true;

			OpenCards.Remove(OpenCards.First());
		}
	}
}
