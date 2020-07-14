using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var queen = board.FindPiece(this);
            var availableMoves = new List<Square>();

            //Adding diagonal movements
            var diagonalMoves = AddingMovements.AddDiagonalMoves(availableMoves, queen);
            //Adding lateral movements and returning
            return AddingMovements.AddLateralMoves(diagonalMoves, queen);
        }
    }
}