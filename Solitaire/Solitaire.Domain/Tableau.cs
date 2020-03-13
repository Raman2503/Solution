using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	public class Tableau
	{
		public List<Card> TableauPile1 { get; set; } = new List<Card>();
		public List<Card> TableauPile2 { get; set; } = new List<Card>();
		public List<Card> TableauPile3 { get; set; } = new List<Card>();
		public List<Card> TableauPile4 { get; set; } = new List<Card>();
		public List<Card> TableauPile5 { get; set; } = new List<Card>();
		public List<Card> TableauPile6 { get; set; } = new List<Card>();
		public List<Card> TableauPile7 { get; set; } = new List<Card>();

		public List<Card> ClosedCards { get; set; } = new List<Card>();


		/// <summary>
		/// This method initializes the respective pile on the tableau, if the associated number of cards
		/// is correct. E.g. The third pile on the tableau must have 3 cards. The first one only one card.
		/// </summary>
		/// <param name="tableauPile"></param>
		public void Initialize(List<Card> tableauPile)
		{
			_ = tableauPile ?? throw new ArgumentNullException(nameof(tableauPile));

			if (tableauPile.Count == 1)
			{
				TableauPile1.AddRange(tableauPile);
			}
			if (tableauPile.Count == 2)
			{
				TableauPile2.AddRange(tableauPile);
			}
			if (tableauPile.Count == 3)
			{
				TableauPile3.AddRange(tableauPile);
			}
			if (tableauPile.Count == 4)
			{
				TableauPile4.AddRange(tableauPile);
			}
			if (tableauPile.Count == 5)
			{
				TableauPile5.AddRange(tableauPile);
			}
			if (tableauPile.Count == 6)
			{
				TableauPile6.AddRange(tableauPile);
			}
			if (tableauPile.Count == 7)
			{
				TableauPile7.AddRange(tableauPile);
			}
			else
			{
				return;
			}

			DetermineOpenCardOfPile(tableauPile);

			DetermineClosedCardsOfPile(tableauPile);
		}


		/// <summary>
		/// This method shall determine the face up card (open card) of every pile on the tableau.
		/// </summary>
		public Card DetermineOpenCardOfPile(List<Card> pTableauPile)
		{
			var pOpenCard = pTableauPile.First();
			return pOpenCard; 
		}

		public List<Card> DetermineClosedCardsOfPile(List<Card> pTableauPile)
		{
			ClosedCards.AddRange(pTableauPile);
			ClosedCards.RemoveRange(0,1); 
			return ClosedCards;
		}
	}
}
