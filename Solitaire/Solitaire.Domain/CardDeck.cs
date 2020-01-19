using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	public class CardDeck
	{
		public List<Card> Cards { get; set; }

		public CardDeck()
		{
			Cards = new List<Card>();
		}
	}
}
