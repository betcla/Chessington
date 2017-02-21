using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var rookLocation = board.FindPiece(this);

            return AddingMovements.AddRooksLateralMoves(board, rookLocation);
        }
    }
}