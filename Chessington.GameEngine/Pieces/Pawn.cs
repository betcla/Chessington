using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            if (this.Player == Player.White)
            {
                var whitepiece = board.FindPiece(this);
                var availablemoves = new[] {Square.At(whitepiece.Row - 1, whitepiece.Col)};
                return availablemoves;
            }

            if (this.Player == Player.Black)
            {
                var blackpiece = board.FindPiece(this);
                var availablemoves = new[] {Square.At(blackpiece.Row + 1, blackpiece.Col)};
                return availablemoves;
            }
            else
            {
                return null;
            }
        }
    }
}