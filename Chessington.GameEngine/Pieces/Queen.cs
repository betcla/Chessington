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

            return AddingMovements.AddDiagonalMoves(queen).Concat(AddingMovements.AddLateralMoves(queen));
        }
    }
}