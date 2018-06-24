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

		public Owner player { get; set; } = Owner.None;
	}
}
