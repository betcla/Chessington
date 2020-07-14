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
                
                if (whitepiece.Row == 7)
                {
                    var firstavailablemove=availablemoves.Concat(new[] {Square.At(whitepiece.Row - 2, whitepiece.Col)});
                    return firstavailablemove;
                }
                else
                {
                    return availablemoves;
                }
            }

            if (this.Player == Player.Black)
            {
                var blackpiece = board.FindPiece(this);
                var availablemoves = new[] {Square.At(blackpiece.Row + 1, blackpiece.Col)};

                if (blackpiece.Row == 1)
                {
                    var firstavailablemove =
                        availablemoves.Concat(new[] {Square.At(blackpiece.Row + 2, blackpiece.Col)});
                    return firstavailablemove;
                }
                else 
                {
                    return availablemoves;
                }
            }
            else
            {
                return null;
            }
        }
    }
}