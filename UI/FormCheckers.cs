using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;

namespace UI
{
    internal partial class FormCheckers : Form
    {
        enum ePlayerColors
        {
            RedPlayer =1
            ,GreenPlayer =2
        }
      private  Game m_Game;
      private MyPictureBox[,] m_Board;
      private bool m_CurrentlyShowingPossibleMoves=false;
      private MyPictureBox m_LastPossiblelMovesShowedPictureBox;

        internal FormCheckers(Game i_Game)
        {
            m_Game = i_Game;
            m_Game.SetGameToOngoing();
            InitializeComponent();
            getPlayersStats();
            updatePlayerTurnText();
           // updateBoardSize();
            InitializeBoard();
        }
        private void updatePlayerTurnText()
        {
            labelWhosPlayerTurn.Text = String.Format("{0}'s turn", m_Game.GetUsersTurnName());
        }
        private void updateBoardSize()
        {
            if(m_Game.GetBoardSize() == 8)
            {
                panelBoard.Width = 500;
                panelBoard.Height = 500;
            }
            else if(m_Game.GetBoardSize() == 10)
            {
                panelBoard.Width = 700;
                panelBoard.Height = 700;
            }

        }
        internal void InitializeBoard()
        {
            Size pictureSize = new Size(40, 40);
            m_Board = new MyPictureBox[m_Game.GetBoardSize(),m_Game.GetBoardSize()];
            int left =panelBoard.Left, top = panelBoard.Top;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for(int i=0;i<m_Game.GetBoardSize();i++)
            {
                left = panelBoard.Left;
                if(i%2 == 0)
                {
                    colors[0] = Color.Black;
                    colors[1] = Color.White;
                }
                else
                {
                    colors[0] = Color.White;
                    colors[1] = Color.Black;
                }
                for(int j=0;j<m_Game.GetBoardSize();j++)
                {
                    m_Board[i, j] = new MyPictureBox(i,j);
                    m_Board[i, j].MouseHover += myPictureBox_MouseHover;
                    m_Board[i, j].MouseLeave += myPictureBox_MouseLeave;
                    m_Board[i, j].Click += myPictureBox_Clicked;
                    m_Board[i,j].BackColor = colors[( j%2 ==0) ? 1 : 0 ];
                    m_Board[i,j].Location = new Point(left, top);
                    m_Board[i, j].Size = pictureSize;
                    left += pictureSize.Width;
                    m_Board[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                    if (m_Game.IsPlayerOneByPosition(i,j))
                    {
                        m_Board[i, j].Image = Properties.Resources.RedSoldier;

                    }
                    if (m_Game.IsPlayerTwoByPosition(i, j))
                    {
                       m_Board[i,j].Image = Properties.Resources.GreenSoldier;

                    }
                    panelBoard.Controls.Add(m_Board[i, j]);

                    
                }
               
                top += pictureSize.Width;
            }
        }
        private void myPictureBox_MouseLeave(object sender ,EventArgs e)
        {
            MyPictureBox myPictureBox = sender as MyPictureBox;
            if(m_Game.SquareInLocation(myPictureBox.Row,myPictureBox.Col) ==(int)ePlayerColors.GreenPlayer)
            {
                if (m_Game.IsKing(myPictureBox.Row, myPictureBox.Col))
                {
                    myPictureBox.Image = Properties.Resources.GreenKing;
                }
                else
                {
                    myPictureBox.Image = Properties.Resources.GreenSoldier;
                }
            }
            else if(m_Game.SquareInLocation(myPictureBox.Row, myPictureBox.Col) == (int)ePlayerColors.RedPlayer)
            {
                if (m_Game.IsKing(myPictureBox.Row, myPictureBox.Col))
                {
                    myPictureBox.Image = Properties.Resources.KingRed;
                }
                else
                {
                    myPictureBox.Image = Properties.Resources.RedSoldier;
                }
            }

        }
        private void myPictureBox_Clicked(object sender, EventArgs e)
        {
            MyPictureBox myPictureBox = sender as MyPictureBox;
            handlePossibleMoves(myPictureBox);
            handleMove(myPictureBox);
            
        }
        private void handleComputerMove()
        {
            if(m_Game.GetGameMode() ==2 && m_Game.CurrentPlayerTurn() == 2)
            {
                m_Game.ComputerMove();
                refreshBoard();
            }
        }
        private void handlePossibleMoves(MyPictureBox i_MyPictureBox)
        {
            if (isPlayerPictureBoxClicked(i_MyPictureBox))
            {
                if (currentPlayerPictureBoxClicked(i_MyPictureBox))
                {
                    List<Point> possibleMoves = m_Game.GetPossibleMovesLocations(i_MyPictureBox.Row, i_MyPictureBox.Col);
                    if (possibleMoves.Count > 0)
                    {
                        if (m_CurrentlyShowingPossibleMoves)
                        {
                            unPaintAvailableMoves(m_Game.GetPossibleMovesLocations(m_LastPossiblelMovesShowedPictureBox.Row, m_LastPossiblelMovesShowedPictureBox.Col));
                            if (m_LastPossiblelMovesShowedPictureBox != i_MyPictureBox)
                            {
                                paintAvailableMoves(possibleMoves);
                                m_LastPossiblelMovesShowedPictureBox = i_MyPictureBox;
                            }
                            else
                            {
                                m_CurrentlyShowingPossibleMoves = false;
                                m_LastPossiblelMovesShowedPictureBox = null;
                            }

                        }
                        else
                        {
                            paintAvailableMoves(possibleMoves);
                            m_LastPossiblelMovesShowedPictureBox = i_MyPictureBox;
                            m_CurrentlyShowingPossibleMoves = true;
                        }
                    }

                }
            }
        }
        private void handleMove(MyPictureBox i_MyPictureBox)
        {
            string wrongMove = "";
            bool isValidMove;
            if(i_MyPictureBox.IsPossibleMove)
            {
                unPaintAvailableMoves(m_Game.GetPossibleMovesLocations(m_LastPossiblelMovesShowedPictureBox.Row, m_LastPossiblelMovesShowedPictureBox.Col));
                isValidMove = m_Game.LogicCheckIfValidMove(new Point(m_LastPossiblelMovesShowedPictureBox.Row, m_LastPossiblelMovesShowedPictureBox.Col), new Point(i_MyPictureBox.Row, i_MyPictureBox.Col), ref wrongMove);
                if (!isValidMove)
                {
                    Message msg = new Message(wrongMove);
                    msg.ShowDialog();
                }
                else
                {
                    m_Game.UpdateGameDetails();
                    refreshBoard();
                    updatePlayerTurnText();
                }
                if(m_Game.IsGameOver())
                {
                    int winnerPoints = m_Game.CalcWinnersPoints();
                    Message msg = new Message(string.Format("Congratulations! {0} won with total of {1} points.", m_Game.GetWinnerName(), winnerPoints));
                    msg.setMessageToVisble();
                    msg.Show();
                    m_Game.ResetGame();
                    getPlayersStats();
                    refreshBoard();
                }

            }
        }
        private void refreshBoard()
        {
            
            for (int i=0;i<m_Game.GetBoardSize();i++)
            {
                for(int j=0;j<m_Game.GetBoardSize();j++)
                {
                    if(m_Game.IsPlayerOneByPosition(i, j))
                    {
                        if(m_Game.IsKing(i,j))
                        {
                            m_Board[i, j].Image = Properties.Resources.KingRed;
                        }
                        else
                        { 
                        m_Board[i, j].Image = Properties.Resources.RedSoldier;
                        }

                    }
                    else if (m_Game.IsPlayerTwoByPosition(i, j))
                    {
                        if (m_Game.IsKing(i, j))
                        {
                            m_Board[i, j].Image = Properties.Resources.GreenKing;
                        }
                        else
                        {
                            m_Board[i, j].Image = Properties.Resources.GreenSoldier;
                        }

                    }
                    else
                    {
                        m_Board[i, j].Image = null;
                    }
                }
            }

        }
        private bool isPlayerPictureBoxClicked(MyPictureBox i_MyPictureBox)
        {
            return m_Game.SquareInLocation(i_MyPictureBox.Row, i_MyPictureBox.Col) != 0;
        }
        private bool currentPlayerPictureBoxClicked(MyPictureBox i_MyPictureBox)
        {
            return m_Game.CurrentPlayerTurn() == m_Game.SquareInLocation(i_MyPictureBox.Row, i_MyPictureBox.Col);
        }
        private void paintAvailableMoves(List<Point> i_PossibleMoves)
        {
            foreach (Point p in i_PossibleMoves)
            {
                m_Board[p.X, p.Y].Image = Properties.Resources.PossibleMove2;
                m_Board[p.X,p.Y].IsPossibleMove = true;
            }
           
        }
        private void unPaintAvailableMoves(List<Point> i_PossibleMoves)
        {
            foreach (Point p in i_PossibleMoves)
            {
                m_Board[p.X, p.Y].Image = null;
                m_Board[p.X, p.Y].IsPossibleMove = false;
            }

        }
        private void myPictureBox_MouseHover(object sender, EventArgs e)
        {
            MyPictureBox myPictureBox = sender as MyPictureBox;
            if (checkIfThereIsAnyAvailableMoves(myPictureBox))
            {
                if (hoveredPieceCorrectPlayerTurn(myPictureBox))
                {
                    if (m_Game.CurrentPlayerTurn() == (int)ePlayerColors.GreenPlayer)
                    {
                        if (m_Game.IsKing(myPictureBox.Row, myPictureBox.Col))
                        {
                            myPictureBox.Image = Properties.Resources.KingGreenOnHover;
                        }
                        else
                        {
                            myPictureBox.Image = Properties.Resources.GreenSoldierOnHover;
                        }

                    }
                    else
                    {
                        if (m_Game.IsKing(myPictureBox.Row, myPictureBox.Col))
                        {
                            myPictureBox.Image = Properties.Resources.KingRedOnHOver;
                        }
                        else
                        {
                            myPictureBox.Image = Properties.Resources.RedSoldierOnHover;
                        }
                    }
                }
            }
        }
        private bool checkIfThereIsAnyAvailableMoves(MyPictureBox i_MyPictureBox)
        {
            bool res = false;
            if(m_Game.IsPlayerOneByPosition(i_MyPictureBox.Row, i_MyPictureBox.Col) || m_Game.IsPlayerTwoByPosition(i_MyPictureBox.Row,i_MyPictureBox.Col))
            {
                if(m_Game.GetPossibleMovesLocations(i_MyPictureBox.Row, i_MyPictureBox.Col).Count!= 0)
                {
                    res = true;
                }
            }
            return res;
        }
        private bool hoveredPieceCorrectPlayerTurn(MyPictureBox i_MyPictureBox)
        {
            bool isCorrectPlayer = false;
            if(m_Game.CurrentPlayerTurn() == m_Game.SquareInLocation(i_MyPictureBox.Row,i_MyPictureBox.Col))
            {
                isCorrectPlayer = true;
            }
            return isCorrectPlayer;
        }


        private void getPlayersStats()
        {
            labelFirstPlayerName.Text = string.Format("{0} :",m_Game.GetPlayersName(1));
            labelSecondPlayerName.Text = string.Format("{0} :", m_Game.GetPlayersName(2));
            labelFirstPlayerPoints.Text = m_Game.GetFirstPlayerPoints().ToString();
            labelSecondPlayerPoints.Text = m_Game.GetSecondPlayerPoints().ToString();

        }

    }
}
