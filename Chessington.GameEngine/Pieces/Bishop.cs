using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var bishop = board.FindPiece(this);
            var availablemoves = new List<Square>();

            return AddingMovements.AddDiagonalMoves(availablemoves, bishop);
        }
    }
}