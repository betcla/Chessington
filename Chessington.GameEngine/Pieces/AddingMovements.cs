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