using System;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();

            game = new Game();
            game.Start();
            RenderGame();
        }

        private void RenderGame()
        {
            lbGuessNumber.Text = game.GuessNumber.ToString();
            lbOperations.Text = game.OperationsCount.ToString();
            lbCurrentNumber.Text = game.CurrentNumber.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            game.Start();
            RenderGame();
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            game.IncOperation();
            RenderGame();
            CheckWin();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            game.DoubleOperation();
            RenderGame();
            CheckWin();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            game.Reset();
            RenderGame();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            game.Undo();
            RenderGame();
        }

        private void CheckWin()
        {
            if (game.IsWin())
            {
                MessageBox.Show("Победа!", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                game.Start();
                RenderGame();
            }
        }
    }
}
