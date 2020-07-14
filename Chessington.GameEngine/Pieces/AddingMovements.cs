using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class AddingMovements
    {
        public static List<Square> AddLateralMoves(List<Square> availablemoves, Square piecelocation)
        {
            for (var i = 0; i < 8; i++)
                availablemoves.Add(Square.At(piecelocation.Row, i));

            for (var i = 0; i < 8; i++)
                availablemoves.Add(Square.At(i, piecelocation.Col));

            //Get rid of our starting location.
            availablemoves.RemoveAll(s => s == Square.At(piecelocation.Row, piecelocation.Col));

            return availablemoves;
        }

        public static List<Square> AddDiagonalMoves(List<Square> availablemoves, Square piecelocation)
        {
            //Checking diagonals (best way I could find -- still a little messy?)
            for (var i = 0; i < 8; i++)
                if ((piecelocation.Row + i < 8) && (piecelocation.Col - i >= 0))
                {
                    availablemoves.Add(Square.At(piecelocation.Row + i, piecelocation.Col - i));
                }

            for (var i = 0; i < 8; i++)
                if ((piecelocation.Row + i < 8) && (piecelocation.Col + i < 8))
                {
                    availablemoves.Add(Square.At(piecelocation.Row + i, piecelocation.Col + i));
                }

            for (var i = 0; i < 8; i++)
                if ((piecelocation.Row - i >= 0) && (piecelocation.Col - i < 8))
                {
                    availablemoves.Add(Square.At(piecelocation.Row - i, piecelocation.Col - i));
                }

            for (var i = 1; i < 8; i++)
                if ((piecelocation.Row - i >= 0) && (piecelocation.Col + i < 8))
                {
                    availablemoves.Add(Square.At(piecelocation.Row - i, piecelocation.Col + i));
                }
            //Get rid of our starting location.
            availablemoves.RemoveAll(s => s == Square.At(piecelocation.Row, piecelocation.Col));

            return availablemoves;
        }
    }
}