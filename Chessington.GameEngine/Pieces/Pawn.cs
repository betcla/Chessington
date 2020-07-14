using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        private readonly AddingPawnMovements addingPawnMovements;

        public Pawn(Player player)
            : base(player)
        {
            addingPawnMovements = new AddingPawnMovements(this);
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            if (this.Player == Player.White)
            {
                var whitePiece = board.FindPiece(this);

                return addingPawnMovements.AddWhitePawnMovements(board, whitePiece);
            }

            if (this.Player == Player.Black)
            {
                var blackPiece = board.FindPiece(this);

                return addingPawnMovements.AddBlackPawnMovements(board, blackPiece);
            }
            else
            {
                return Enumerable.Empty<Square>();
            }
        }
    }
}