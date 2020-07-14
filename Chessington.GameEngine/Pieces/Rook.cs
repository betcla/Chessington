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

            for (var i = 0; i < 8; i++)
                availablemoves.Add(Square.At(rook.Row, i));

            for (var i = 0; i < 8; i++)
                availablemoves.Add(Square.At(i, rook.Col));

            //Get rid of our starting location.
            availablemoves.RemoveAll(s => s == Square.At(rook.Row, rook.Col));

            return availablemoves;
        }
    }
}