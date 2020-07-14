using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var bishop = board.FindPiece(this);
            var availablemoves = new List<Square>();

            //Checking diagonals (best way I could find -- still a little messy?)
            for (var i = 0; i < 8; i++)
                if ((bishop.Row + i < 8) && (bishop.Col - i >= 0))
                {
                    availablemoves.Add(Square.At(bishop.Row + i, bishop.Col - i));
                }

            for (var i = 0; i < 8; i++)
                if ((bishop.Row + i < 8) && (bishop.Col + i < 8))
                {
                    availablemoves.Add(Square.At(bishop.Row + i, bishop.Col + i));
                }

            for (var i = 0; i < 8; i++)
                if ((bishop.Row - i >= 0) && (bishop.Col - i < 8))
                {
                    availablemoves.Add(Square.At(bishop.Row - i, bishop.Col - i));
                }

            for (var i = 1; i < 8; i++)
                if ((bishop.Row - i >= 0) && (bishop.Col + i < 8))
                {
                    availablemoves.Add(Square.At(bishop.Row - i, bishop.Col + i));
                }

            //Get rid of our starting location.
            availablemoves.RemoveAll(s => s == Square.At(bishop.Row, bishop.Col));
            
            return availablemoves;
        }
    }
}