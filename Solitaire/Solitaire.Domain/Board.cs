﻿using System.Collections.Generic;


namespace Solitaire.Domain
{
	public class Board
	{
		 Tableau Tableau { get; }
		 Foundation Foundation { get; }
		 Stock Stock { get; }

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

			
	}
}

