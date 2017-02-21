using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class AddingPawnMovements
    {
        private Pawn pawn;

        public AddingPawnMovements(Pawn pawn)
        {
            this.pawn = pawn;
        }

        public IEnumerable<Square> AddPawnMovements(Board board, Pawn piece)
        {
            if (piece.Player == Player.White)
            {
                return AddPawnMovements(board, piece, -1);
            }

            else
            {
                return AddPawnMovements(board, piece, 1);
            }
        }

        private IEnumerable<Square> AddPawnMovements(Board board, Piece piece, int a)
        {
            var pieceLocation = board.FindPiece(piece);

            if (board.GetPiece(Square.At(pieceLocation.Row + a, pieceLocation.Col)) == null)
            {
                var availableMoves = new[] {Square.At(pieceLocation.Row + a, pieceLocation.Col)};

                if (piece.hasMoved == false &&
                    (board.GetPiece(Square.At(pieceLocation.Row +2*a, pieceLocation.Col)) == null))
                {
                    var firstAvailableMove =
                        availableMoves.Concat(new[] {Square.At(pieceLocation.Row +2*a, pieceLocation.Col)});
                    return firstAvailableMove;
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
    }
}