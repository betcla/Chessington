using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var knight = board.FindPiece(this);
            //Adding knight moves
            var availablesMoves = new List<Square>
            {
                Square.At(knight.Row-2, knight.Col+1),
                Square.At(knight.Row-2, knight.Col-1),
                Square.At(knight.Row-1, knight.Col+2),
                Square.At(knight.Row-1, knight.Col-2),
                Square.At(knight.Row+1, knight.Col+2),
                Square.At(knight.Row+1, knight.Col-2),
                Square.At(knight.Row+2, knight.Col+1),
                Square.At(knight.Row+2, knight.Col-1)
            };
            return availablesMoves;
        }
    }
}