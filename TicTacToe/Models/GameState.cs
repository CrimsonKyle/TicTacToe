using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TicTacToe
{
    public class GameState
    {

        public GameState()
        {
            Squares = new List<GameSquare>();
            Moves = new List<Move>();
            int index = 0;
            while (index < 9)
            {
                GameSquare square = new GameSquare();
                square.Location = index;
                Squares.Add(square);
                index++;
            }
        }

        public List<GameSquare> Squares { get; set; }

        public List<Move> Moves { get; set; }

        public Owner NextMove
        {
            get
            {
                if (Moves.Count() > 0)
                {
                    switch (Moves.Last().Player)
                    {
                        case Owner.X:
                            return Owner.O;
                        case Owner.O:
                            return Owner.X;
                        default:
                            return Owner.X;
                    }
                }
                else
                {
                    return Owner.X;
                }
            }
        }

        public string Message
        {
            get
            {
                if (GameStatus == Status.InProgress)
                {
                    switch (NextMove)
                    {
                        case Owner.X:
                            return "X Your Move";
                        case Owner.O:
                            return "O Your Move";
                        default:
                            return "";
                    }
                }
                else
                {
                    switch (GameStatus)
                    {
                        case Status.X_Wins:
                            return "X Wins";
                        case Status.O_Wins:
                            return "O Wins";
                        case Status.Draw:
                            return "Draw";
                        default:
                            return "";
                    }
                }
            }
        }

        public Status GameStatus { get; set; }

        public void UpdateState()
        {
            foreach (GameSquare gs in Squares)
            {
                foreach (Move m in Moves)
                {
                    if (m.Location == gs.Location)
                    {
                        gs.Player = m.Player;
                    }
                }
            }
            CheckForWinner();
        }

        public void CheckForWinner()
        {
            CheckForWinnerHorizontal();
            CheckForWinnerVertical();
            CheckForWinnerDiagonal();
            CheckForDraw();
        }

        public void CheckForWinnerHorizontal()
        {
            if (GameStatus == Status.InProgress)
            {
                if (Squares[0].Player == Squares[1].Player && Squares[1].Player == Squares[2].Player)
                {
                    DeclareWinner(0, 1, 2);
                }
                else if (Squares[3].Player == Squares[4].Player && Squares[4].Player == Squares[5].Player)
                {
                    DeclareWinner(3, 4, 5);
                }
                else if (Squares[6].Player == Squares[7].Player && Squares[7].Player == Squares[8].Player)
                {
                    DeclareWinner(6, 7, 8);
                }
            }
        }

        public void CheckForWinnerVertical()
        {
            if (GameStatus == Status.InProgress)
            {
                if (Squares[0].Player == Squares[3].Player && Squares[3].Player == Squares[6].Player)
                {
                    DeclareWinner(0, 3, 6);
                }
                else if (Squares[1].Player == Squares[4].Player && Squares[4].Player == Squares[7].Player)
                {
                    DeclareWinner(1, 4, 7);
                }
                else if (Squares[2].Player == Squares[5].Player && Squares[5].Player == Squares[8].Player)
                {
                    DeclareWinner(2, 5, 8);
                }
            }
        }

        public void CheckForWinnerDiagonal()
        {
            if (GameStatus == Status.InProgress)
            {
                if (Squares[0].Player == Squares[4].Player && Squares[4].Player == Squares[8].Player)
                {
                    DeclareWinner(0, 4, 8);
                }
                else if (Squares[6].Player == Squares[4].Player && Squares[4].Player == Squares[2].Player)
                {
                    DeclareWinner(6, 4, 2);
                }
            }
        }

        public void CheckForDraw()
        {
            if (Moves.Count() >= 9 && GameStatus == Status.InProgress)
            {
                GameStatus = Status.Draw;
                ColorDraw();
            }
        }

        public void DeclareWinner(int square1, int square2, int square3)
        {
            switch (Squares[square1].Player)
            {
                case Owner.X:
                    GameStatus = Status.X_Wins;
                    ColorWin(square1, square2, square3);
                    break;
                case Owner.O:
                    GameStatus = Status.O_Wins;
                    ColorWin(square1, square2, square3);
                    break;
                default:
                    break;
            }
        }

        public void ColorWin(int square1, int square2, int square3)
        {
            Squares[square1].SquareColor = Color.Red;
            Squares[square2].SquareColor = Color.Red;
            Squares[square3].SquareColor = Color.Red;
        }

        public void ColorDraw()
        {
            Squares[0].SquareColor = Color.LightGray;
            Squares[1].SquareColor = Color.LightGray;
            Squares[2].SquareColor = Color.LightGray;
            Squares[3].SquareColor = Color.LightGray;
            Squares[4].SquareColor = Color.LightGray;
            Squares[5].SquareColor = Color.LightGray;
            Squares[6].SquareColor = Color.LightGray;
            Squares[7].SquareColor = Color.LightGray;
            Squares[8].SquareColor = Color.LightGray;
        }
    }
}
