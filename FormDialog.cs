using System;
using System.Windows.Forms;

namespace _2204
{
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();

            this.Text = "Создать";
            this.ActiveControl = textBoxFileName;
        }

        public FormDialog(string fileName)
        {
            InitializeComponent();
            
            this.Text = "Переименовать";
            textBoxFileName.Text = fileName;
            textBoxFileName.SelectAll();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBoxFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                buttonSave_Click(sender, e);
            }
        }
    }
}
