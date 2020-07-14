using System.Collections.Generic;
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
            var rook = board.FindPiece(this);
            var availablemoves = new List<Square>();

            return AddingMovements.AddLateralMoves(availablemoves, rook);
        }
    }
}