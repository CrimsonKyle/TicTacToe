using System;
using Xamarin.Forms;

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
				switch (Player)
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

        public Color SquareColor { get; set; } = Color.YellowGreen;

        public bool CanInteract{
            get {
                switch (Player)
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
		public Owner Player { get; set; } = Owner.None;
    }
}
