using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class GameState
    {
        public List<GameSquare> Squares
        {
            get; set;
        }

		public List<Move> Moves
		{
			get; set;
		}

        public Owner NextMove
		{
			get
            {
                if (Moves.Count() > 0)
                {
                    switch (Moves.Last().player)
                    {
                        case Owner.X:
                            return Owner.O;
                        case Owner.O:
                            return Owner.X;
                        default:
                            return Owner.X;
                    }
                } else {
                    return Owner.X;
                }
			}
		}

		public Enum Status
		{
			get
			{
                return Status;
				//Game Logic
			}
		}
    }
}
