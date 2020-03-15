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



		/// <summary>
		/// This method initializes the respective pile on the tableau, if the associated number of cards
		/// is correct. E.g. The third pile on the tableau must have 3 cards. The first one only one card.
		/// </summary>
		/// <param name="tableauPiles"></param>
		public void Initialize(List <List<Card>> tableauPiles)
		{
			_ = tableauPiles ?? throw new ArgumentNullException(nameof(tableauPiles));

			if (tableauPiles.Any())
			{
				if (tableauPiles[0].Count == 1)
				{
					TableauPile1.AddRange(tableauPiles[0]);
				}

				if (tableauPiles[1].Count == 2)
				{
					TableauPile2.AddRange(tableauPiles[1]);
				}

				if (tableauPiles[2].Count == 3)
				{
					TableauPile3.AddRange(tableauPiles[2]);
				}

				if (tableauPiles[3].Count == 4)
				{
					TableauPile4.AddRange(tableauPiles[3]);
				}

				if (tableauPiles[4].Count == 5)
				{
					TableauPile5.AddRange(tableauPiles[4]);
				}

				if (tableauPiles[5].Count == 6)
				{
					TableauPile6.AddRange(tableauPiles[5]);
				}

				if (tableauPiles[6].Count == 7)
				{
					TableauPile7.AddRange(tableauPiles[6]);
				}
			}
		}
	}
}
 		