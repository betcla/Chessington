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
                var whitePiece = board.FindPiece(this);
                var availableMoves = new[] {Square.At(whitePiece.Row - 1, whitePiece.Col)};
                
                if (whitePiece.Row == 7)
                {
                    var firstAvailableMove=availableMoves.Concat(new[] {Square.At(whitePiece.Row - 2, whitePiece.Col)});
                    return firstAvailableMove;
                }
                else
                {
                    return availableMoves;
                }
            }

            if (this.Player == Player.Black)
            {
                var blackPiece = board.FindPiece(this);
                var availableMoves = new[] {Square.At(blackPiece.Row + 1, blackPiece.Col)};

                if (blackPiece.Row == 1)
                {
                    var firstAvailableMove =
                        availableMoves.Concat(new[] {Square.At(blackPiece.Row + 2, blackPiece.Col)});
                    return firstAvailableMove;
                }
                else 
                {
                    return availableMoves;
                }
            }
            else
            {
                return null;
            }
        }
    }
}