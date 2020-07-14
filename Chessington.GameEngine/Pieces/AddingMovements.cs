using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class AddingMovements
    {
        public static List<Square> AddLateralMoves(List<Square> availableMoves, Square pieceLocation)
        {
            for (var i = 0; i < 8; i++)
                availableMoves.Add(Square.At(pieceLocation.Row, i));

            for (var i = 0; i < 8; i++)
                availableMoves.Add(Square.At(i, pieceLocation.Col));

            //Get rid of our starting location.
            availableMoves.RemoveAll(s => s == Square.At(pieceLocation.Row, pieceLocation.Col));

            return availableMoves;
        }

        public static List<Square> AddDiagonalMoves(List<Square> availableMoves, Square pieceLocation)
        {
            //Checking diagonals (best way I could find -- still a little messy?)
            for (var i = 0; i < 8; i++)
                if ((pieceLocation.Row + i < 8) && (pieceLocation.Col - i >= 0))
                {
                    availableMoves.Add(Square.At(pieceLocation.Row + i, pieceLocation.Col - i));
                }

            for (var i = 0; i < 8; i++)
                if ((pieceLocation.Row + i < 8) && (pieceLocation.Col + i < 8))
                {
                    availableMoves.Add(Square.At(pieceLocation.Row + i, pieceLocation.Col + i));
                }

            for (var i = 0; i < 8; i++)
                if ((pieceLocation.Row - i >= 0) && (pieceLocation.Col - i < 8))
                {
                    availableMoves.Add(Square.At(pieceLocation.Row - i, pieceLocation.Col - i));
                }

            for (var i = 1; i < 8; i++)
                if ((pieceLocation.Row - i >= 0) && (pieceLocation.Col + i < 8))
                {
                    availableMoves.Add(Square.At(pieceLocation.Row - i, pieceLocation.Col + i));
                }
            //Get rid of our starting location.
            availableMoves.RemoveAll(s => s == Square.At(pieceLocation.Row, pieceLocation.Col));

            return availableMoves;
        }
    }
}