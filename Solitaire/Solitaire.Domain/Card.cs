using System;
using System.Collections.Generic;

namespace Solitaire.Domain
{
	public class Card : IEquatable<Card>
	{
		public Rank Rank { get; set; }
		public Suit Suit { get; set; }

		public bool IsBlack { get; set; }

		public bool IsRed { get; set; }

		public Card(Rank pRank, Suit pSuit)
		{
			Rank = pRank;
			Suit = pSuit;

			if (pSuit == Suit.Hearts || pSuit == Suit.Diamonds)
			{
				IsRed = true;
			}

			if (pSuit == Suit.Clubs || pSuit == Suit.Spades)
			{
				IsBlack = true;
			}
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
			if (obj.GetType() != GetType()) return false;
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

		public static implicit operator List<object>(Card v)
		{
			throw new NotImplementedException();
		}
	}
}
