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
            var rook = board.FindPiece(this);

            var friendlyPiece = Square.At(4, 7);
            var lateralMoves = AddingMovements.AddLateralMoves(rook);

            if (board.GetPiece(Square.At(4, 6)) != null)
            {
                lateralMoves.RemoveAll(s => s == friendlyPiece);
                return lateralMoves;
            }
            else
            {
                return lateralMoves;
            }
        }
    }
}