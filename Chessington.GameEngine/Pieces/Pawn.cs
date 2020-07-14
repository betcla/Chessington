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
                if (board.GetPiece(Square.At(whitePiece.Row - 1, whitePiece.Col)) == null)
                {
                    var availableMoves = new[] {Square.At(whitePiece.Row - 1, whitePiece.Col)};

                    if (whitePiece.Row == 7)
                    {
                        //if (board[whitePiece.Row, whitePiece.Col] != null)
                        if (board.GetPiece(Square.At(whitePiece.Row - 2, whitePiece.Col)) == null)
                        {
                            var firstAvailableMove =
                                availableMoves.Concat(new[] {Square.At(whitePiece.Row - 2, whitePiece.Col)});
                            return firstAvailableMove;
                        }
                        else
                        {
                            return availableMoves;
                        }
                    }
                    else
                    {
                        return availableMoves;
                    }
                }
                else
                {
                    return Enumerable.Empty<Square>();
                }
            }

            if (this.Player == Player.Black)
            {
                var blackPiece = board.FindPiece(this);
                if (board.GetPiece(Square.At(blackPiece.Row+1, blackPiece.Col)) == null)
                {
                    var availableMoves = new[] {Square.At(blackPiece.Row + 1, blackPiece.Col)};

                    if (blackPiece.Row == 1)
                    {
                        if (board.GetPiece(Square.At(blackPiece.Row + 2, blackPiece.Col)) == null)
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
                        return availableMoves;
                    }
                }
                else
                {
                    return Enumerable.Empty<Square>();
                }
            }
            else
            {
                return Enumerable.Empty<Square>();
            }
        }
    }
}