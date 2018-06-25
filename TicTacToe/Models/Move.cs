using System;

namespace TicTacToe
{
	public class Move
	{
		public int Location
		{
			get;
			set;
		}

		public Owner Player { get; set; } = Owner.None;
	}
}
