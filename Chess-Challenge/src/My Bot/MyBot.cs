using ChessChallenge.API;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

public class MyBot : IChessBot
{
    private struct RatedMove 
    {
        public RatedMove() { }

        public Move move = Move.NullMove;
        public int rating = 0;
    }

    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();
        foreach (Move move in moves)
        {

        }
        return moves[0];
    }

    private RatedMove BasicPawnMove (Move move)
    {
        if (move.MovePieceType == (PieceType)1 )
        {
            RatedMove thisMove = new RatedMove();
            thisMove.move = move;
            thisMove.rating = 10;
            return thisMove;
        }
        return new RatedMove();
    }
}