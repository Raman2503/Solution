using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	public class Board
	{
		public Tableau Tableau { get; set; }
		public bool CardCanBeMoved { get; set; }

		public void InitializeBoard(List<Card> pPile3, List<Card> pPile5)
		{
			
		}

		public bool MoveCardFromTableauToTableau(List<Card> pPile3, List<Card> pPile5)
		{
			return CardCanBeMoved;
		}
	}
}
