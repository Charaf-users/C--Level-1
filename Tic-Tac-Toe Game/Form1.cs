using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        void changeImage(Button btn)
        {
            if ((string)btn.Tag == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        {
                            btn.Image = Resources.X;
                            PlayerTurn = enPlayer.Player2;
                            lbTurn.Text = "player 2";
                            GameStatus.PlayCount++;
                            btn.Tag = "X";
                            checkWinner();
                           
                           
                           
                            break;
                        }
                    case enPlayer.Player2:
                        {
                            btn.Image = Resources.O;
                            PlayerTurn = enPlayer.Player1;
                            lbTurn.Text = "player 1";
                            GameStatus.PlayCount++;
                            btn.Tag = "O";
                            checkWinner();

                            break;


                        }
                        
                }

                
            }
            else
            {
                MessageBox.Show("Wrong Choice","Wrong Choice",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            if(GameStatus.PlayCount==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }

        }

       public   bool checkValues(Button Btn1, Button Btn2, Button Btn3)
        {
            if (Btn1.Tag.ToString() != "?" && Btn1.Tag.ToString() == Btn2.Tag.ToString() && Btn1.Tag.ToString() == Btn3.Tag.ToString())
            {
                {
                    Btn1.BackColor = Color.GreenYellow;
                    Btn2.BackColor = Color.GreenYellow;
                    Btn3.BackColor = Color.GreenYellow;
                    if (Btn1.Tag.ToString() == "X")
                    {
                        GameStatus.Winner = enWinner.Player1;
                        GameStatus.GameOver = true;
                        EndGame();
                        return true;

                    }

                    else
                    {
                        GameStatus.Winner = enWinner.Player2;
                        GameStatus.GameOver = true;
                        EndGame();
                        return true;


                    }
                }
               
            }
            GameStatus.GameOver = false;
            return false;

        }

        void EndGame()
            {
                lbTurn.Text = "Game Over";
                switch(GameStatus.Winner)
                {
                    case enWinner.Player1:
                        lbWinnerIs.Text = "Player 1";
                        break;
                    case enWinner.Player2:
                        lbWinnerIs.Text = "Player 2";
                        break;
                    default:
                        lbWinnerIs.Text = "Draw ";
                        break;
                }
                MessageBox.Show("Game Over","Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        
        void checkWinner()
        {
           
                if(checkValues(btn2,btn3,btn4))
                    return;
                if (checkValues(btn5, btn6, btn7))
                    return;
                if (checkValues(btn8, btn9, btn10))
                    return;
                if (checkValues(btn2, btn6, btn10))
                    return;
                if (checkValues(btn4, btn6, btn8))
                    return;
                if (checkValues(btn2, btn5, btn8))
                    return;
                if (checkValues(btn3, btn6, btn9))
                    return;
                if (checkValues(btn4, btn7, btn10))
                    return;




        }

        private void restButtom(Button btn)
        {
            btn.BackColor = Color.Transparent;
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
        }

        void RestartGame()
        {
            restButtom(btn2);
            restButtom(btn3);
            restButtom(btn4);
            restButtom(btn5);
            restButtom(btn6);
            restButtom(btn7);
            restButtom(btn8);
            restButtom(btn9);
            restButtom(btn10);

            PlayerTurn = enPlayer.Player1;
            lbTurn.Text = "player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;

            lbWinnerIs.Text = "In Progress";



        }

        
       
        private void Paint_Form(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(white);
            Pen.Width = 15;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 500, 140, 500, 650);
            e.Graphics.DrawLine(Pen, 700, 140, 700, 650);

            e.Graphics.DrawLine(Pen, 300, 300, 900, 300);
            e.Graphics.DrawLine(Pen, 300, 500, 900, 500);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            changeImage((Button)sender);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
