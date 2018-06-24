using System;

namespace TicTacToe
{
    public class GameSquare
    {
		public int Location
		{
            get;
            set;
		}

		public string Text {
            get {
				switch (player)
				{
					case Owner.X:
                        return "X";
					case Owner.O:
						return "O";
					default:
						return "";
				}
            }
        }

        public bool CanInteract{
            get {
                switch (player)
                {
                    case Owner.X:
                        return false;
                    case Owner.O:
                        return false;
                    default:
                        return true;
                }
            }
        }
		public Owner player { get; set; } = Owner.None;
    }
}
