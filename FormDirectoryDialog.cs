using System;
using System.IO;
using System.Windows.Forms;

namespace _2204
{
    public partial class FormDirectoryDialog : Form
    {
        public FormDirectoryDialog(string path1, string path2, bool cheked1, bool cheked2)
        {
            InitializeComponent();

            textBoxLeft.Text = path1;
            radioButtonLeft1.Checked = cheked1;
            radioButtonLeft2.Checked = !cheked1;
             
            textBoxRight.Text = path2;
            radioButtonRight1.Checked = cheked2;
            radioButtonRight2.Checked = !cheked2;
        }

        private void radioButtonLeft1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLeft1.Checked)
            {
                textBoxLeft.Enabled = false;
                buttonLeft.Enabled = false;
            }
            else
            {
                textBoxLeft.Enabled = true;
                buttonLeft.Enabled = true;
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                if ((sender as Control) == buttonLeft)
                {
                    textBoxLeft.Text = folderDialog.SelectedPath;
                }
                else
                {
                    textBoxRight.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void radioButtonRight1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRight1.Checked)
            {
                textBoxRight.Enabled = false;
                buttonRight.Enabled = false;
            }
            else
            {
                textBoxRight.Enabled = true;
                buttonRight.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxLeft.Text) || !Directory.Exists(textBoxRight.Text))
            {
                MessageBox.Show("По крайней мере одна из выбранных директорий не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
