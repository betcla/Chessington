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

        public IEnumerable<Square> AddBlackPawnMovements(Board board, Square pieceLocation)
        {
            if (board.GetPiece(Square.At(pieceLocation.Row + 1, pieceLocation.Col)) == null)
            {
                var availableMoves = new[] {Square.At(pieceLocation.Row + 1, pieceLocation.Col)};

                if ((pieceLocation.Row == 1) &&
                    (board.GetPiece(Square.At(pieceLocation.Row + 2, pieceLocation.Col)) == null))
                {
                    var firstAvailableMove =
                        availableMoves.Concat(new[] {Square.At(pieceLocation.Row + 2, pieceLocation.Col)});
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

        public IEnumerable<Square> AddWhitePawnMovements(Board board, Square pieceLocation)
        {
            if (board.GetPiece(Square.At(pieceLocation.Row - 1, pieceLocation.Col)) == null)
            {
                var availableMoves = new[] {Square.At(pieceLocation.Row - 1, pieceLocation.Col)};

                if ((pieceLocation.Row == 7) &&
                    (board.GetPiece(Square.At(pieceLocation.Row - 2, pieceLocation.Col)) == null))
                {
                    var firstAvailableMove =
                        availableMoves.Concat(new[] {Square.At(pieceLocation.Row - 2, pieceLocation.Col)});
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