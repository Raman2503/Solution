using System.Collections.Generic;

namespace Solitaire.Domain
{
	public class CardDeck
    {
        public List<Card> Cards { get; } = new List<Card>();
		
		public int Count
        {
            get { return Cards.Count; }
        }
	}
}
