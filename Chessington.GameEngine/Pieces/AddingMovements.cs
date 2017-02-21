using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class AddingMovements
    {
        public static List<Square> AddLateralMoves(Square pieceLocation)
        {
            var availableMoves = new List<Square>();
            for (var i = 0; i < GameSettings.BoardSize; i++)
            {
                availableMoves.Add(Square.At(pieceLocation.Row, i));
            }

            for (var i = 0; i < GameSettings.BoardSize; i++)
            {
                availableMoves.Add(Square.At(i, pieceLocation.Col));
            }

            availableMoves.RemoveAll(s => s == pieceLocation);

            return availableMoves;
        }

        public static List<Square> AddRooksLateralMoves(Board board, Square pieceLocation)
        {
            var availableMoves = new List<Square>();

            for (var i = 0; i < GameSettings.BoardSize; i++)
            {
                if ((board.GetPiece(Square.At(pieceLocation.Row, i)) == null) || i == pieceLocation.Row)
                {
                    availableMoves.Add(Square.At(pieceLocation.Row, i));
                }
                else
                {
                    break;
                }
            }

            for (var i = 0; i < GameSettings.BoardSize; i++)
            {
                if ((board.GetPiece(Square.At(i, pieceLocation.Col)) == null) || (i == pieceLocation.Col))
                {
                    availableMoves.Add(Square.At(i, pieceLocation.Col));
                }
                else
                {
                    break;
                }
            }
            return availableMoves;

            /*var i = 0;
            var j = 0;
            
            
            do
            {
                if (i != pieceLocation.Row)
                {
                    availableMoves.Add(Square.At(pieceLocation.Row, i));
                    i++;
                }

            } while (i < GameSettings.BoardSize || (board.GetPiece(Square.At(pieceLocation.Row, i)) == null) || (pieceLocation.Row == i));
            
            do
            {
                if (j != pieceLocation.Col)
                {
                    availableMoves.Add(Square.At(j, pieceLocation.Col));
                    i++;
                }

            } while (j < GameSettings.BoardSize || (board.GetPiece(Square.At(j, pieceLocation.Col)) == null) || (pieceLocation.Col == j));
            
            availableMoves.RemoveAll(s => s == pieceLocation);

            return availableMoves;*/
        }

        public static List<Square> AddDiagonalMoves(Square pieceLocation)
        {
            var availableMoves = new List<Square>();
            for (var i = 0; i < GameSettings.BoardSize; i++)
                if ((pieceLocation.Row + i < GameSettings.BoardSize) && (pieceLocation.Col - i >= 0))
                {
                    availableMoves.Add(Square.At(pieceLocation.Row + i, pieceLocation.Col - i));
                }

            for (var i = 0; i < GameSettings.BoardSize; i++)
                if ((pieceLocation.Row + i < GameSettings.BoardSize) && (pieceLocation.Col + i < GameSettings.BoardSize))
                {
                    availableMoves.Add(Square.At(pieceLocation.Row + i, pieceLocation.Col + i));
                }

            for (var i = 0; i < GameSettings.BoardSize; i++)
                if ((pieceLocation.Row - i >= 0) && (pieceLocation.Col - i < GameSettings.BoardSize))
                {
                    availableMoves.Add(Square.At(pieceLocation.Row - i, pieceLocation.Col - i));
                }

            for (var i = 1; i < GameSettings.BoardSize; i++)
                if ((pieceLocation.Row - i >= 0) && (pieceLocation.Col + i < GameSettings.BoardSize))
                {
                    availableMoves.Add(Square.At(pieceLocation.Row - i, pieceLocation.Col + i));
                }

            availableMoves.RemoveAll(s => s == pieceLocation);

            return availableMoves;
        }
    }
}