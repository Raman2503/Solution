using NUnit.Framework;
using System.Collections.Generic;

namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class BoardTests
	{
		public IEnumerable<TestCaseData> MoveCardsTestCases
		{
			get
			{
				yield return new TestCaseData(
					new List<Card>(),
					new List<Card>(),
					true
				);

				// Empty Case: Moving Card from empty pile to empty pile
				// Move Card from normal pile to another pile
			}
		}

		[Test]
		[TestCaseSource(nameof(MoveCardsTestCases))]
		public void MoveCardsTest(List<Card> pPile3, List<Card> pPile5, bool CardCanBeMoved)
		{
			//Arrange
			Board board = new Board();

			//Act
			board.InitializeBoard(pPile3, pPile5);

			board.MoveCardFromTableauToTableau(pPile3, pPile5);

			//Assert
			// Can this Card be moved ?
			// If the Card can be moved, check if Card is correctly removed from pile and added to another pile
			// If Card cannot be moved, ensure that Card is not removed from pile it was taken from
			
		}
	}
}
