using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseGame
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
        }

        #region Menu

        private void menuStandardPack_Click(object sender, EventArgs e)
        {
            var fileName = "questions.xml";
            var database = LoadDatabase(fileName);
            if (database == null) return;

            game = new Game(database);
            RenderGame();
        }

        private void menuLoadPack_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var database = LoadDatabase(fileName);
                if (database == null) return;

                game = new Game(database);
                RenderGame();
            }
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private TrueFalse LoadDatabase(string fileName)
        {
            TrueFalse database = new TrueFalse(fileName);
            try
            {
                database.Load();
            }
            catch (InvalidOperationException)
            {
                ShowError("Некорректный файл");
                return null;
            }
            catch (InvalidDataException ex)
            {
                ShowError(ex.Message);
                return null;
            }

            return database;
        }

        #endregion

        private void btnTrue_Click(object sender, EventArgs e)
        {
            ApplyAnswer(true);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            ApplyAnswer(false);
        }

        private void ApplyAnswer(bool answer)
        {
            if (game == null) return;

            game.Answer(answer);

            if (game.IsGameOver)
            {
                MessageBox.Show($"Вы угадали {game.RightAnswers} из {game.Rounds}", "Игра завершена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                game = null;
            }
            else
            {
                RenderGame();
            }
        }

        private void RenderGame()
        {
            lbInfo.Text = $"{game.CurrentRound} / {game.Rounds}";
            tbQuestion.Text = game.QuestionText;
        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
