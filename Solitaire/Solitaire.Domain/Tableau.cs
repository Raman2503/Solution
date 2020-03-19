using System;
using System.Collections.Generic;
using System.Linq;

namespace Solitaire.Domain
{
	public class Tableau
	{
		public List<Card> TableauPile1 { get; private set; } = new List<Card>();
		public List<Card> TableauPile2 { get; private set; } = new List<Card>();
		public List<Card> TableauPile3 { get; private set; } = new List<Card>();
		public List<Card> TableauPile4 { get; private set; } = new List<Card>();
		public List<Card> TableauPile5 { get; private set; } = new List<Card>();
		public List<Card> TableauPile6 { get; private set; } = new List<Card>();
		public List<Card> TableauPile7 { get; private set; } = new List<Card>();

		public bool CardCanBeMoved { get; set; }

		public Card OpenCard { get; set; }


		/// <summary>
		/// This method initializes the respective pile on the tableau.
		/// </summary>
		/// <param name="tableauPiles"></param>
		public void Initialize(List<List<Card>> tableauPiles)
		{
			_ = tableauPiles ?? throw new ArgumentNullException(nameof(tableauPiles));

			if (tableauPiles.Any())
			{
				TableauPile1.AddRange(tableauPiles[0]);

				TableauPile2.AddRange(tableauPiles[1]);

				TableauPile3.AddRange(tableauPiles[2]);

				TableauPile4.AddRange(tableauPiles[3]);

				TableauPile5.AddRange(tableauPiles[4]);

				TableauPile6.AddRange(tableauPiles[5]);

				TableauPile7.AddRange(tableauPiles[6]);

			}
		}


		public void MoveCardFromTableauToTableau(List<Card> pPile3, List<Card> pPile5, Card pCardToBeMoved)
		{
			
				pPile5.Add(pCardToBeMoved);
				pPile3.Remove(pCardToBeMoved);

				TableauPile3 = pPile3;
				TableauPile5 = pPile5;

				CardCanBeMoved = true;

				OpenCard = TableauPile3.Last();		
		}

		public void CheckRankAndSuitInTableau(List<List<Card>> initialTableauPiles)
		{
			if (initialTableauPiles.Any())
			{
				var pile3 = initialTableauPiles[2];
				var pile5 = initialTableauPiles[4];

				if (pile5.Any() && pile3.Any())
				{
					var cardToBeMoved = pile3.Last();
					var openCardFromTargetPile = pile5.Last();

					if (openCardFromTargetPile.Rank - cardToBeMoved.Rank == 1)
					{

						if (cardToBeMoved.IsBlack && openCardFromTargetPile.IsRed ||
							cardToBeMoved.IsRed && openCardFromTargetPile.IsBlack)
						{

							MoveCardFromTableauToTableau(pile3, pile5, cardToBeMoved);
						}

						else
						OpenCard = pile3.Last();
					}

					else
						OpenCard = pile3.Last();
				}

				else if (pile5.Count == 0 && pile3.Last().Rank == Rank.King)
				{
					var cardToBeMoved = pile3.Last();

					MoveCardFromTableauToTableau(pile3, pile5, cardToBeMoved);
				}
				
				else if(pile5.Count == 0)
				{
					OpenCard = pile3.Last();
				}
			}
		}
	}
}
 		