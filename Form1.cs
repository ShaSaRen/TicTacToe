using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        string empty = "";
        int scorePlayerX;
        int scorePlayerO;
        bool checker;
        bool disable = false;
        bool enable = true;
        bool win = false;

        public Calculatrice()
        {
            InitializeComponent();
        }

       void enableDisableAllBtn(bool trueFalse)
        {
            btnTopLeft.Enabled = trueFalse;
            btnTop.Enabled = trueFalse;
            btnTopRight.Enabled = trueFalse;
            btnMidLeft.Enabled = trueFalse;
            btnMid.Enabled = trueFalse;
            btnMidRight.Enabled = trueFalse;
            btnBotLeft.Enabled = trueFalse;
            btnBot.Enabled = trueFalse;
            btnBotRight.Enabled = trueFalse;
        }

        void emptyingAllBtnText()
        {
            btnTopLeft.Text = empty;
            btnTop.Text = empty;
            btnTopRight.Text = empty;
            btnMidLeft.Text = empty;
            btnMid.Text = empty;
            btnMidRight.Text = empty;
            btnBotLeft.Text = empty;
            btnBot.Text = empty;
            btnBotRight.Text = empty;
        }

        void checkTheWinner()
        {
            // Checking if the player X win 
            if(btnTopLeft.Text == "X" && btnTop.Text == "X" && btnTopRight.Text == "X")
            {
                win = true;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe - Shasaren");
                scorePlayerX = int.Parse(lblScorePlayerX.Text);
                scorePlayerX++;
                lblScorePlayerX.Text = Convert.ToString(scorePlayerX);
                enableDisableAllBtn(disable);
            }
            if(btnMidLeft.Text == "X" && btnMid.Text == "X" && btnMidRight.Text == "X")
            {
                win = true;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe - Shasaren");
                scorePlayerX = int.Parse(lblScorePlayerX.Text);
                scorePlayerX++;
                lblScorePlayerX.Text = Convert.ToString(scorePlayerX);
                enableDisableAllBtn(disable);
            }
            if (btnBotLeft.Text == "X" && btnBot.Text == "X" && btnBotRight.Text == "X")
            {
                win = true;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe - Shasaren");
                scorePlayerX = int.Parse(lblScorePlayerX.Text);
                scorePlayerX++;
                lblScorePlayerX.Text = Convert.ToString(scorePlayerX);
                enableDisableAllBtn(disable);
            }
            if (btnTopLeft.Text == "X" && btnMidLeft.Text == "X" && btnBotLeft.Text == "X")
            {
                win = true;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe - Shasaren");
                scorePlayerX = int.Parse(lblScorePlayerX.Text);
                scorePlayerX++;
                lblScorePlayerX.Text = Convert.ToString(scorePlayerX);
                enableDisableAllBtn(disable);
            }
            if (btnTop.Text == "X" && btnMid.Text == "X" && btnBot.Text == "X")
            {
                win = true;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe - Shasaren");
                scorePlayerX = int.Parse(lblScorePlayerX.Text);
                scorePlayerX++;
                lblScorePlayerX.Text = Convert.ToString(scorePlayerX);
                enableDisableAllBtn(disable);
            }
            if (btnTopRight.Text == "X" && btnMidRight.Text == "X" && btnBotRight.Text == "X")
            {
                win = true;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe - Shasaren");
                scorePlayerX = int.Parse(lblScorePlayerX.Text);
                scorePlayerX++;
                lblScorePlayerX.Text = Convert.ToString(scorePlayerX);
                enableDisableAllBtn(disable);
            }
            if (btnTopLeft.Text == "X" && btnMid.Text == "X" && btnBotRight.Text == "X")
            {
                win = true;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe - Shasaren");
                scorePlayerX = int.Parse(lblScorePlayerX.Text);
                scorePlayerX++;
                lblScorePlayerX.Text = Convert.ToString(scorePlayerX);
                enableDisableAllBtn(disable);
            }
            if (btnTopRight.Text == "X" && btnMid.Text == "X" && btnBotLeft.Text == "X")
            {
                win = true;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe - Shasaren");
                scorePlayerX = int.Parse(lblScorePlayerX.Text);
                scorePlayerX++;
                lblScorePlayerX.Text = Convert.ToString(scorePlayerX);
                enableDisableAllBtn(disable);
            }
            // End of all the player X victory posibilities 
            // ----------------------------------------------------------------------------------------------------------
            // Checking if the player O win 
            if (btnTopLeft.Text == "O" && btnTop.Text == "O" && btnTopRight.Text == "O")
            {
                win = true;
                MessageBox.Show("The winner is Player O", "Tic Tac Toe - Shasaren");
                scorePlayerO = int.Parse(lblScorePlayerO.Text);
                scorePlayerO++;
                lblScorePlayerO.Text = Convert.ToString(scorePlayerO);
                enableDisableAllBtn(disable);
            }
            if (btnMidLeft.Text == "O" && btnMid.Text == "O" && btnMidRight.Text == "O")
            {
                win = true;
                MessageBox.Show("The winner is Player O", "Tic Tac Toe - Shasaren");
                scorePlayerO = int.Parse(lblScorePlayerO.Text);
                scorePlayerO++;
                lblScorePlayerO.Text = Convert.ToString(scorePlayerO);
                enableDisableAllBtn(disable);
            }
            if (btnBotLeft.Text == "O" && btnBot.Text == "O" && btnBotRight.Text == "O")
            {
                win = true;
                MessageBox.Show("The winner is Player O", "Tic Tac Toe - Shasaren");
                scorePlayerO = int.Parse(lblScorePlayerO.Text);
                scorePlayerO++;
                lblScorePlayerO.Text = Convert.ToString(scorePlayerO);
                enableDisableAllBtn(disable);
            }
            if (btnTopLeft.Text == "O" && btnMidLeft.Text == "O" && btnBotLeft.Text == "O")
            {
                win = true;
                MessageBox.Show("The winner is Player O", "Tic Tac Toe - Shasaren");
                scorePlayerO = int.Parse(lblScorePlayerO.Text);
                scorePlayerO++;
                lblScorePlayerO.Text = Convert.ToString(scorePlayerO);
                enableDisableAllBtn(disable);
            }
            if (btnTop.Text == "O" && btnMid.Text == "O" && btnBot.Text == "O")
            {
                win = true;
                MessageBox.Show("The winner is Player O", "Tic Tac Toe - Shasaren");
                scorePlayerO = int.Parse(lblScorePlayerO.Text);
                scorePlayerO++;
                lblScorePlayerO.Text = Convert.ToString(scorePlayerO);
                enableDisableAllBtn(disable);
            }
            if (btnTopRight.Text == "O" && btnMidRight.Text == "O" && btnBotRight.Text == "O")
            {
                win = true;
                MessageBox.Show("The winner is Player O", "Tic Tac Toe - Shasaren");
                scorePlayerO = int.Parse(lblScorePlayerO.Text);
                scorePlayerO++;
                lblScorePlayerO.Text = Convert.ToString(scorePlayerO);
                enableDisableAllBtn(disable);
            }
            if (btnTopLeft.Text == "O" && btnMid.Text == "O" && btnBotRight.Text == "O")
            {
                win = true;
                MessageBox.Show("The winner is Player O", "Tic Tac Toe - Shasaren");
                scorePlayerO = int.Parse(lblScorePlayerO.Text);
                scorePlayerO++;
                lblScorePlayerO.Text = Convert.ToString(scorePlayerO);
                enableDisableAllBtn(disable);
            }
            if (btnTopRight.Text == "O" && btnMid.Text == "O" && btnBotLeft.Text == "O")
            {
                win = true;
                MessageBox.Show("The winner is Player O", "Tic Tac Toe - Shasaren");
                scorePlayerO = int.Parse(lblScorePlayerO.Text);
                scorePlayerO++;
                lblScorePlayerO.Text = Convert.ToString(scorePlayerO);
                enableDisableAllBtn(disable);
            }
            // End of all the player X victory posibilities 
            // ----------------------------------------------------------------------------------------------------------
            // Checking for the tie game
            if (btnTopLeft.Text != "" && btnTop.Text != "" && btnTopRight.Text != "" &&
                btnMidLeft.Text != "" && btnMid.Text != "" && btnMidRight.Text != "" &&
                btnBotLeft.Text != "" && btnBot.Text != "" && btnBotRight.Text != "")// && win == false )
            {
                MessageBox.Show("Nobody win the game \n\n (╯°□°)╯︵ ┻━┻ ︵ ╯(°□° ╯)", "Tic Tac Toe - ShaSaRen");
                enableDisableAllBtn(disable);
            }

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            win = false;
            emptyingAllBtnText();
            lblScorePlayerX.Text = "0";
            lblScorePlayerO.Text = "0";
            scorePlayerO = 0;
            scorePlayerX = 0;
            enableDisableAllBtn(enable);
            MessageBox.Show("You reset the scores !"); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            win = false;
            emptyingAllBtnText();
            enableDisableAllBtn(enable);
        }

        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTopLeft.Text = "X";
                checker = true;
            }
            else
            {
                btnTopLeft.Text = "O";
                checker = false;
            }
            btnTopLeft.Enabled = false;
            checkTheWinner();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            checkTheWinner();
            if (checker == false)
            {
                btnTop.Text = "X";
                checker = true;
            }
            else
            {
                btnTop.Text = "O";
                checker = false;
            }
            btnTop.Enabled = false;
            checkTheWinner();
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            
            if (checker == false)
            {
                btnTopRight.Text = "X";
                checker = true;
            }
            else
            {
                btnTopRight.Text = "O";
                checker = false;
            }
            btnTopRight.Enabled = false;
            checkTheWinner();
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnMidLeft.Text = "X";
                checker = true;
            }
            else
            {
                btnMidLeft.Text = "O";
                checker = false;
            }
            btnMidLeft.Enabled = false;
            checkTheWinner();
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnMid.Text = "X";
                checker = true;
            }
            else
            {
                btnMid.Text = "O";
                checker = false;
            }
            btnMid.Enabled = false;
            checkTheWinner();
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnMidRight.Text = "X";
                checker = true;
            }
            else
            {
                btnMidRight.Text = "O";
                checker = false;
            }
            btnMidRight.Enabled = false;
            checkTheWinner();
        }

        private void btnBotLeft_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnBotLeft.Text = "X";
                checker = true;
            }
            else
            {
                btnBotLeft.Text = "O";
                checker = false;
            }
            btnBotLeft.Enabled = false;
            checkTheWinner();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnBot.Text = "X";
                checker = true;
            }
            else
            {
                btnBot.Text = "O";
                checker = false;
            }
            btnBot.Enabled = false;
            checkTheWinner();
        }

        private void btnBotRight_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnBotRight.Text = "X";
                checker = true;
            }
            else
            {
                btnBotRight.Text = "O";
                checker = false;
            }
            btnBotRight.Enabled = false;
            checkTheWinner();
        }
    }
}