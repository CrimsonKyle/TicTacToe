using System;
using TicTacToe.Models;
using Xamarin.Forms;

namespace TicTacToe
{
    public partial class GamePage : ContentPage
    {
        public GameState Game = new GameState();

        public GamePage()
        {
            InitializeComponent();
            UpdateGameView();
        }

		public void NewGame(object sender, EventArgs args)
		{
            Game = new GameState();
            UpdateGameView();
		}
         
		public void Move(object sender, EventArgs args)
		{
            GameButton button = sender as GameButton;
            if (Game.Squares[button.Location].CanInteract && Game.GameStatus == Status.InProgress)
            {
                Move move = new Move();
                move.Player = Game.NextMove;
                move.Location = button.Location;
                Game.Moves.Add(move);
                Game.UpdateState();
                UpdateGameView();
            }
		}

        public void UpdateGameView()
        {
            Game_Message.Text = Game.Message;

            foreach (GameSquare g in Game.Squares)
            {
                Console.WriteLine(g.SquareColor);
				switch (g.Location)
				{
					case 0:
						Square_0.Text = g.Text;
                        Square_0.BackgroundColor = g.SquareColor;
                        break;
					case 1:
						Square_1.Text = g.Text;
                        Square_1.BackgroundColor = g.SquareColor;
                        break;
					case 2:
                        Square_2.Text = g.Text;
                        Square_2.BackgroundColor = g.SquareColor;
                        break;
					case 3:
						Square_3.Text = g.Text;
                        Square_3.BackgroundColor = g.SquareColor;
                        break;
					case 4:
						Square_4.Text = g.Text;
                        Square_4.BackgroundColor = g.SquareColor;
                        break;
					case 5:
						Square_5.Text = g.Text;
                        Square_5.BackgroundColor = g.SquareColor;
                        break;
					case 6:
						Square_6.Text = g.Text;
                        Square_6.BackgroundColor = g.SquareColor;
                        break;
					case 7:
						Square_7.Text = g.Text;
                        Square_7.BackgroundColor = g.SquareColor;
                        break;
					case 8:
						Square_8.Text = g.Text;
                        Square_8.BackgroundColor = g.SquareColor;
                        break;
					default:
						break;
				}
            }
        }
    }
}
