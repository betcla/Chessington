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
            var pieceLocation = board.FindPiece(this);
            var piece = this;

            return addingPawnMovements.AddPawnMovements(board, piece);
           
        }
    }
}