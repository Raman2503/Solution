using System.Collections.Generic;


namespace Solitaire.Domain
{
	public class Board
	{
		public Tableau Tableau { get; }

		public Board(Tableau tableau)
		{
			Tableau = tableau;
		}

		public void InitializeBoard(List<List<Card>> initialTableauPiles)
		{
			Tableau.Initialize(initialTableauPiles);
		}


		//
	}
}

