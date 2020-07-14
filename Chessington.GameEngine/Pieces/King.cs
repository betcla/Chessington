using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var king = board.FindPiece(this);
            var availableMoves = new List<Square>
            {
                Square.At(king.Row-1, king.Col-1),
                Square.At(king.Row-1, king.Col),
                Square.At(king.Row-1, king.Col+1),
                Square.At(king.Row, king.Col-1),
                Square.At(king.Row, king.Col+1),
                Square.At(king.Row+1, king.Col-1),
                Square.At(king.Row+1, king.Col),
                Square.At(king.Row+1, king.Col+1)
            };
            return availableMoves;
        }
    }
}