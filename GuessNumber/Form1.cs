using System;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();

            game = new Game();
            game.Start();
            ResetGUI();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(tbUserNumber.Text, out n))
            {
                Answer answer = game.Guess(n);
                switch (answer)
                {
                    case Answer.EXACTLY:
                        ResetGUI();
                        MessageBox.Show($"Победа! Попыток: {game.Tries}", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        game.Start();
                        break;
                    case Answer.LESS:
                        lbAnswer.Text = "Меньше";
                        break;
                    case Answer.MORE:
                        lbAnswer.Text = "Больше";
                        break;
                }
            }
            else
            {
                lbAnswer.Text = "Введите число!";
            }
        }

        private void ResetGUI()
        {
            tbUserNumber.Text = "";
            lbAnswer.Text = "";
        }
    }
}
