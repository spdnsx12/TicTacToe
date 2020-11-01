using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int num;
        private int scoreO = 0;
        private int scoreX = 0;
        public Form1()
        {
            InitializeComponent();
            hideButtons();
            initialize();
        }


        private void playGame_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            bool xTurn = num % 2 == 0;
            Button myButton = (sender as Button);
            if (myButton.Text != "")
            {
                return;
            }
            if (xTurn)
            {
                myButton.Text = "X";
                myButton.ForeColor = Color.Blue;
            }
            else
            {
                myButton.Text = "O";
                myButton.ForeColor = Color.Red;
            }
            num++;
            getWinner();
            
        }

        public string gameMechanics()
        {
            if (num % 2 == 0)
            {
                num++;
                return "X";
            }
            else
            {
                num++;
                return "O";
            }
        }

        public void startGame()
        {
            gameInfo.Text = "It\'s time to play !";
            gameInfo.Show();
            resetButtons();
            num = 0;
            xWins.Show();
            xScore.Show();
            oWins.Show();
            oScore.Show();
        }


        public void gameEnd()
        {
            disableButtons();
            playGame.Text = "Restart";
            playGame.Show();

        }

        public void getWinner()
        {
            if (firstButton.Text + secondButton.Text + thirdButton.Text == "XXX" ||
                firstButton.Text + fifthButton.Text + ninghtButton.Text == "XXX" ||
                firstButton.Text + fourthButton.Text + seventhButton.Text == "XXX" ||
                secondButton.Text + fifthButton.Text + eightButton.Text == "XXX" ||
                thirdButton.Text + sixthButton.Text + ninghtButton.Text == "XXX" ||
                thirdButton.Text + fifthButton.Text + seventhButton.Text == "XXX" ||
                fourthButton.Text + fifthButton.Text + sixthButton.Text == "XXX" ||
                seventhButton.Text + eightButton.Text + ninghtButton.Text == "XXX"
                )
            {
                ++scoreX;
                this.xScore.Text = scoreX.ToString();
                gameEnd();
                gameInfo.Text = "Player X has won the game";
                
            }
            else if (firstButton.Text + secondButton.Text + thirdButton.Text == "OOO" ||
                     firstButton.Text + fifthButton.Text + ninghtButton.Text == "OOO" ||
                     firstButton.Text + fourthButton.Text + seventhButton.Text == "OOO" ||
                     secondButton.Text + fifthButton.Text + eightButton.Text == "OOO" ||
                     thirdButton.Text + sixthButton.Text + ninghtButton.Text == "OOO" ||
                     thirdButton.Text + fifthButton.Text + seventhButton.Text == "OOO" ||
                     fourthButton.Text + fifthButton.Text + sixthButton.Text == "OOO" ||
                     seventhButton.Text + eightButton.Text + ninghtButton.Text == "OOO"
                    )
                 {
                    ++scoreO;
                    this.oScore.Text = scoreO.ToString();
                    gameEnd();
                    gameInfo.Text = "Player O has won the game";
                    
                 }
                 else
                 {
                    if (num == 9) 
                    { 
                        gameEnd();
                        gameInfo.Text = "This is a tie";
                    }
                 }
        }

        private void initialize()
        {
            oWins.Hide();
            oScore.Hide();
            oScore.Text = "0";
            xWins.Hide();
            xScore.Hide();
            xScore.Text = "0";
        }
        private void hideButtons()
        {
            firstButton.Hide();
            secondButton.Hide();
            thirdButton.Hide();
            fourthButton.Hide();
            fifthButton.Hide();
            sixthButton.Hide();
            seventhButton.Hide();
            eightButton.Hide();
            ninghtButton.Hide();
        }

        public void disableButtons()
        {
            firstButton.Enabled = false;
            secondButton.Enabled = false;
            thirdButton.Enabled = false;
            fourthButton.Enabled = false;
            fifthButton.Enabled = false;
            sixthButton.Enabled = false;
            seventhButton.Enabled = false;
            eightButton.Enabled = false;
            ninghtButton.Enabled = false;
        }

        public void resetButtons()
        {
            playGame.Hide();
            firstButton.Text = "";
            firstButton.Enabled = true;
            firstButton.Show();
            secondButton.Text = "";
            secondButton.Enabled = true;
            secondButton.Show();
            thirdButton.Text = "";
            thirdButton.Enabled = true;
            thirdButton.Show();
            fourthButton.Text = "";
            fourthButton.Enabled = true;
            fourthButton.Show();
            fifthButton.Text = "";
            fifthButton.Enabled = true;
            fifthButton.Show();
            sixthButton.Text = "";
            sixthButton.Enabled = true;
            sixthButton.Show();
            seventhButton.Text = "";
            seventhButton.Enabled = true;
            seventhButton.Show();
            eightButton.Text = "";
            eightButton.Enabled = true;
            eightButton.Show();
            ninghtButton.Text = "";
            ninghtButton.Enabled = true;
            ninghtButton.Show();
        }
    }
}
