using System;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Form1 : Form
    {
        private TrueFalse database;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog(this);
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);

                nudNumber.Maximum = database.Count;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                try
                {
                    database.Load();
                }
                catch (InvalidOperationException)
                {
                    database = null;
                    ShowError("Некорректный файл");
                    return;
                }

                nudNumber.Maximum = database.Count;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (ShowMessageIfDbExists()) return;

            database.Save();
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (ShowMessageIfDbExists()) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database.FileName = saveFileDialog.FileName;
                database.Save();
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null) return;

            int number = (int) nudNumber.Value;
            tbQuestion.Text = database[number - 1].Text;
            cbTrue.Checked = database[number - 1].TrueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ShowMessageIfDbExists()) return;

            database.Add("", false);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ShowMessageIfDbExists()) return;
            if (database.Count == 1)
            {
                ShowError("Нельзя удалить единственный вопрос");
                return;
            }

            var result = MessageBox.Show("Удалить вопрос?", "Удаление вопроса", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ShowMessageIfDbExists()) return;

            int number = (int)nudNumber.Value;
            database[number - 1].Text = tbQuestion.Text;
            database[number - 1].TrueFalse = cbTrue.Checked;
        }

        private bool ShowMessageIfDbExists()
        {
            if (database == null)
            {
                ShowError("База данных не выбрана");
                return true;
            }
            return false;
        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
