using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var queen = board.FindPiece(this);
            var availablemoves = new List<Square>();

            //Adding diagonal movements
            for (var i = 0; i < 8; i++)
                if ((queen.Row + i < 8) && (queen.Col - i >= 0))
                {
                    availablemoves.Add(Square.At(queen.Row + i, queen.Col - i));
                }

            for (var i = 0; i < 8; i++)
                if ((queen.Row + i < 8) && (queen.Col + i < 8))
                {
                    availablemoves.Add(Square.At(queen.Row + i, queen.Col + i));
                }

            for (var i = 0; i < 8; i++)
                if ((queen.Row - i >= 0) && (queen.Col - i < 8))
                {
                    availablemoves.Add(Square.At(queen.Row - i, queen.Col - i));
                }

            for (var i = 1; i < 8; i++)
                if ((queen.Row - i >= 0) && (queen.Col + i < 8))
                {
                    availablemoves.Add(Square.At(queen.Row - i, queen.Col + i));
                }
            
            //Adding lateral movements
            for (var i = 0; i < 8; i++)
                availablemoves.Add(Square.At(queen.Row, i));

            for (var i = 0; i < 8; i++)
                availablemoves.Add(Square.At(i, queen.Col));

            //Get rid of our starting location.
            availablemoves.RemoveAll(s => s == Square.At(queen.Row, queen.Col));

            return availablemoves;
        }
    }
}