using System.Collections.Generic;


namespace Solitaire.Domain
{
	public class Board
	{
		public Tableau Tableau { get; }
		public Foundation Foundation { get; }
		public Stock Stock { get; }

		public Board(Tableau tableau, Foundation foundation, Stock stock)
		{
			Tableau = tableau;
			Foundation = foundation;
			Stock = stock;
		}

		public void InitializeBoard(List<List<Card>> initialTableauPiles)
		{
			Tableau.Initialize(initialTableauPiles);
		}


		//
	}
}

