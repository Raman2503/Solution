using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
	public class Card : IEquatable<Card>
	{
		public Rank Rank { get; set; }
		public Suit Suit { get; set; }

		public Card(Rank pRank, Suit pSuit)
		{
			Rank = pRank;
			Suit = pSuit;
		}

		public override string ToString()
		{
			return string.Format("{0} {1}",Rank,Suit);
		}


		public bool Equals(Card other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Rank == other.Rank && Suit == other.Suit;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Card)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((int)Rank * 397) ^ (int)Suit;
			}
		}

		public static bool operator ==(Card left, Card right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Card left, Card right)
		{
			return !Equals(left, right);
		}
	}
}
