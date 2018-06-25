using System;
using Xamarin.Forms;
namespace TicTacToe.Models
{
    public class GameButton : Button
    {
        public GameButton()
        {
            Style = (Style)Application.Current.Resources["gameSquareStyle"];
        }

		public int Location
		{
			get;
			set;
		}
    }
}
