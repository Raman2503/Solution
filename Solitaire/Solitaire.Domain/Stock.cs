using System;
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

		Foundation Foundation { get; set; }

		public Stock(Tableau tableau, Foundation foundation)
		{
			Tableau = tableau;
			Foundation = foundation;
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

		public void CheckRankAndSuitInStockAndFoundation(Card cardToBeMoved, List<Card> foundationPiles)
		{
			if (foundationPiles.Any())
			{
					switch (cardToBeMoved.Suit)
				{
					case Suit.Clubs:
						if (cardToBeMoved.Rank - Foundation.FoundationPileClubs.First().Rank == 1)
							MoveCardFromWasteToFoundation(cardToBeMoved);
							
						break;
					case Suit.Diamonds:
						if (cardToBeMoved.Rank - Foundation.FoundationPileDiamonds.First().Rank == 1)
							MoveCardFromWasteToFoundation(cardToBeMoved);
						break;
					case Suit.Hearts:
						if (cardToBeMoved.Rank - Foundation.FoundationPileHearts.First().Rank == 1)
							MoveCardFromWasteToFoundation(cardToBeMoved);
						break;
					case Suit.Spades:
						if (cardToBeMoved.Rank - Foundation.FoundationPileSpades.First().Rank == 1)
							MoveCardFromWasteToFoundation(cardToBeMoved);
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}

		private void MoveCardFromWasteToFoundation(Card cardToBeMoved)
		{
			Foundation.MoveCardToFoundation(cardToBeMoved);
			StockCards.Remove(cardToBeMoved);

			CardCanBeMoved = true;

			OpenCards.Remove(OpenCards.First());
		}
	}
}
