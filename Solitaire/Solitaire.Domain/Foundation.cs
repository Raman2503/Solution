﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Solitaire.Domain
{
	public class Foundation
	{
		public List<Card> FoundationPileClubs { get; set; } = new List<Card>();
		public List<Card> FoundationPileDiamonds { get; set; } = new List<Card>();
		public List<Card> FoundationPileHearts { get; set; } = new List<Card>();
		public List<Card> FoundationPileSpades { get; set; } = new List<Card>();


		/// <summary>
		/// This property checks that all foundation piles are initially empty.
		/// </summary>
		public bool IsEmpty
		{
			get
			{
				if (FoundationPileClubs.Any())
					return false;
				if (FoundationPileHearts.Any())
					return false;
				if (FoundationPileDiamonds.Any())
					return false;
				if (FoundationPileSpades.Any())
					return false;
				return true;
			}
		}

		// Initialize foundation
		public void Initialize(List<Card> initialFoundationCards)
		{
			if (initialFoundationCards.Any())
			{
				foreach (var card in initialFoundationCards)
				{
					MoveCardToFoundation(card);
				}
			}
		}

		// Moving cards to foundation and checking rank and suit beforehand
		public void CheckRank(Card newCard)
		{
			switch (newCard.Suit)
			{
				case Suit.Clubs:
					if (newCard.Rank - FoundationPileClubs.First().Rank == 1)
						MoveCardToFoundation(newCard);
					break;
				case Suit.Diamonds:
					if (newCard.Rank - FoundationPileDiamonds.First().Rank == 1)
						MoveCardToFoundation(newCard);
					break;
				case Suit.Hearts:
					if (newCard.Rank - FoundationPileHearts.First().Rank == 1)
						MoveCardToFoundation(newCard);
					break;
				case Suit.Spades:
					if (newCard.Rank - FoundationPileSpades.First().Rank == 1)
						MoveCardToFoundation(newCard);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

		}

		public void MoveCardToFoundation(Card card)
		{
			switch (card.Suit)
			{
				case Suit.Clubs:
					FoundationPileClubs.Add(card);
					break;
				case Suit.Diamonds:
					FoundationPileDiamonds.Add(card);
					break;
				case Suit.Hearts:
					FoundationPileHearts.Add(card);
					break;
				case Suit.Spades:
					FoundationPileSpades.Add(card);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

		}
	}
}
