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
            var availablemoves = new List<Square>();

            //Adding diagonal movements
            var diagonalmoves = AddingMovements.AddDiagonalMoves(availablemoves, queen);
            //Adding lateral movements
            return AddingMovements.AddLateralMoves(diagonalmoves, queen);
        }
    }
}