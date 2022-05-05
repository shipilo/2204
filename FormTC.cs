using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace _2204
{
    public partial class FormTC : Form
    {
        private FlowLayoutPanel fileExplorer;
        private FlowLayoutPanel fileExplorerOpposite;

        private TextBox textBoxPath;
        private TextBox textBoxPathOpposite;

        private List<string> pathHistory;
        private List<string> pathHistoryOpposite;

        private List<string> pathHistory1;
        private List<string> pathHistory2;

        private int pathIndex;
        private int pathIndexOpposite;

        public List<string> pathsSelected;

        private List<string> pathsSelected1;
        private List<string> pathsSelected2;

        private string pathStarting1;
        private string pathStarting2;
        private bool pathSaving1;
        private bool pathSaving2;

        private bool loaded;

        public FormTC()
        {
            InitializeComponent();

            pathHistory1 = new List<string>();
            pathHistory2 = new List<string>();
            pathsSelected1 = new List<string>();
            pathsSelected2 = new List<string>();
        }

        private void FormTC_Load(object sender, EventArgs e)
        {
            pathStarting1 = DriveInfo.GetDrives()[0].Name;
            pathSaving1 = true;
            pathStarting2 = DriveInfo.GetDrives()[DriveInfo.GetDrives().Length - 1].Name;
            pathSaving2 = true;
            if (File.Exists("1.txt"))
            {
                try
                {
                    StreamReader sr = new StreamReader("1.txt");
                    string[] str = sr.ReadToEnd().Trim().Split('*');
                    pathStarting1 = str[0];
                    pathSaving1 = Convert.ToBoolean(str[1]);
                    sr.Close();
                }
                catch { }
            }
            if (File.Exists("2.txt"))
            {
                try
                {
                    StreamReader sr = new StreamReader("2.txt");
                    string[] str = sr.ReadToEnd().Trim().Split('*');
                    pathStarting2 = str[0];
                    pathSaving2 = Convert.ToBoolean(str[1]);
                    sr.Close();
                }
                catch { }
            }

            fileExplorer = fileExplorer2;
            textBoxPath = textBoxPath2;
            pathHistory = pathHistory2;
            pathHistory2.Add(pathStarting2);
            LoadElements(pathStarting2);

            fileExplorer = fileExplorer1;
            fileExplorerOpposite = fileExplorer2;
            textBoxPath = textBoxPath1;
            textBoxPathOpposite = textBoxPath2;
            pathHistory = pathHistory1;
            pathHistoryOpposite = pathHistory2;
            pathsSelected = pathsSelected1;
            pathHistory1.Add(pathStarting1);
            LoadElements(pathStarting1);

            loaded = true;
        }

        public void CreatePathHistoryBrunch(string path)
        {
            if (!File.Exists(path))
            {
                if (pathsSelected != null) pathsSelected.Clear();

                pathHistory.RemoveRange(pathIndex + 1, pathHistory.Count - pathIndex - 1);
                pathHistory.Add(path);
                pathIndex++;
            }
        }

        public void LoadElements(string path)
        {
            if (Directory.Exists(path))
            {
                fileExplorer.Controls.Clear();
                textBoxPath.Text = path;

                DirectoryInfo directory = new DirectoryInfo(path);
                try
                {
                    foreach (DirectoryInfo folder in directory.GetDirectories())
                    {
                        try
                        {
                            fileExplorer.Controls.Add(new Element(null, folder.Name, folder.FullName, fileExplorer.Width, this));
                        }
                        catch { }
                    }
                }
                catch { }
                try
                {
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        try
                        {
                            fileExplorer.Controls.Add(new Element(Icon.ExtractAssociatedIcon(file.FullName).ToBitmap(), file.Name, file.FullName, fileExplorer.Width, this));
                        }
                        catch { }
                    }
                }
                catch { }
            }
            else if (File.Exists(path))
            {
                Process.Start(path);
            }
            if (textBoxPath1.Text.Equals(textBoxPath2.Text) && loaded)
            {
                FlowLayoutPanel flowLayoutPanel = fileExplorer;
                fileExplorer = fileExplorerOpposite;
                LoadElements(textBoxPathOpposite.Text);
                fileExplorer = flowLayoutPanel;
            }
        }

        public void fileExplorer_Validation(string tag)
        {
            if (tag == "1")
            {
                if (fileExplorer.Tag.ToString() == "2")
                {
                    int index = pathIndex;
                    pathIndex = pathIndexOpposite;
                    pathIndexOpposite = index;
                }
                fileExplorer = fileExplorer1;
                fileExplorerOpposite = fileExplorer2;
                textBoxPath = textBoxPath1;
                textBoxPathOpposite = textBoxPath2;
                pathHistory = pathHistory1;
                pathHistoryOpposite = pathHistory2;
                pathsSelected = pathsSelected1;                
            }
            else if (tag == "2")
            {
                if (fileExplorer.Tag.ToString() == "1")
                {
                    int index = pathIndex;
                    pathIndex = pathIndexOpposite;
                    pathIndexOpposite = index;
                }
                fileExplorer = fileExplorer2;
                fileExplorerOpposite = fileExplorer1;
                textBoxPath = textBoxPath2;
                textBoxPathOpposite = textBoxPath1;
                pathHistory = pathHistory2;
                pathHistoryOpposite = pathHistory1;
                pathsSelected = pathsSelected2;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (pathIndex > 0)
            {
                LoadElements(pathHistory[--pathIndex]);
            }
            else
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(pathHistory[0]);
                if (directoryInfo.Parent != null)
                {
                    pathHistory.Insert(0, directoryInfo.Parent.FullName);
                    LoadElements(directoryInfo.Parent.FullName);
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pathHistory.Count > pathIndex + 1) LoadElements(pathHistory[++pathIndex]);
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            FormDialog formDialog = new FormDialog();
            if (formDialog.ShowDialog() == DialogResult.OK)
            {
                File.Create(textBoxPath.Text + "\\" + formDialog.textBoxFileName.Text);
                LoadElements(textBoxPath.Text);
            }
        }

        private void buttonCreateFolder_Click(object sender, EventArgs e)
        {
            FormDialog formDialog = new FormDialog();
            if (formDialog.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(textBoxPath.Text + "\\" + formDialog.textBoxFileName.Text);
                LoadElements(textBoxPath.Text);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (string path in pathsSelected)
            {
                if (Directory.Exists(path) &&
                    MessageBox.Show("Вы действительно хотите удалить эту папку со всем её содержимым?", path, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Directory.Delete(path, true);
                }
                else if (File.Exists(path) &&
                    MessageBox.Show("Вы действительно хотите удалить этот файл?", path, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(path);
                }
            }
            LoadElements(textBoxPath.Text);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            foreach (string path in pathsSelected)
            {
                if (Directory.Exists(path))
                {
                    string pathNew = textBoxPathOpposite.Text + "\\" + Path.GetFileName(path);
                    while (Directory.Exists(pathNew)) pathNew += " (копия)";
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(path, pathNew);

                    FlowLayoutPanel flowLayoutPanel = fileExplorer;
                    fileExplorer = fileExplorerOpposite;
                    LoadElements(textBoxPathOpposite.Text);
                    fileExplorer = flowLayoutPanel;
                }
                else if (File.Exists(path))
                {
                    string ext = Path.GetExtension(path);
                    string pathWithoutExt = textBoxPathOpposite.Text + "\\" + Path.GetFileNameWithoutExtension(path);
                    while (File.Exists(pathWithoutExt + ext)) pathWithoutExt += " (копия)";
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(path, pathWithoutExt + ext);

                    FlowLayoutPanel flowLayoutPanel = fileExplorer;
                    fileExplorer = fileExplorerOpposite;
                    LoadElements(textBoxPathOpposite.Text);
                    fileExplorer = flowLayoutPanel;
                }
            }
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (pathsSelected.Count == 1)
            {
                if (Directory.Exists(pathsSelected[0]))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(pathsSelected[0]);
                    FormDialog formDialog = new FormDialog(directoryInfo.Name);
                    if (formDialog.ShowDialog() == DialogResult.OK)
                    {
                        Directory.Move(directoryInfo.FullName, directoryInfo.Parent.FullName + "\\" + formDialog.textBoxFileName.Text);
                        LoadElements(textBoxPath.Text);
                    }
                }
                else if (File.Exists(pathsSelected[0]))
                {
                    FileInfo fileInfo = new FileInfo(pathsSelected[0]);                    
                    FormDialog formDialog = new FormDialog(fileInfo.Name);
                    if (formDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileSystem.Rename(fileInfo.FullName, fileInfo.DirectoryName + "\\" + formDialog.textBoxFileName.Text);
                        LoadElements(textBoxPath.Text);
                    }
                }
            }
        }

        private void свойстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string path in pathsSelected)
            {
                if (File.Exists(path))
                {
                    var dir = Path.GetDirectoryName(path);
                    var file = Path.GetFileName(path);

                    var shell = new Shell32.Shell();
                    var folder = shell.NameSpace(dir);
                    var folderItem = folder.ParseName(file);

                    var names =
                        (from idx in Enumerable.Range(0, short.MaxValue)
                         let key = folder.GetDetailsOf(null, idx)
                         where !string.IsNullOrEmpty(key)
                         select (idx, key)).ToDictionary(p => p.idx, p => p.key);

                    var properties =
                        (from idx in names.Keys
                         orderby idx
                         let value = folder.GetDetailsOf(folderItem, idx)
                         where !string.IsNullOrEmpty(value)
                         select (name: names[idx], value)).ToList();

                    string propertiesString = "";
                    foreach (var kvp in properties) propertiesString += $"{kvp.name}: {kvp.value}\n";
                    MessageBox.Show(propertiesString, "Свойства: " + path, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void вАрхивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нет у меня больше времени и сил пытаться загрузить библиотеку для архивации с помощью рефлексии.");
            /*SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile(saveFileDialog.FileName);
                foreach (string path in pathsSelected)
                {
                    zip.AddItem(path, "");
                }
                try
                {
                    zip.Save(saveFileDialog.FileName);
                    MessageBox.Show("Архивация прошла успешно.", "В архив", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Не удалось архивироать файлы.", "В архив", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        private void fileExplorer_SizeChanged(object sender, EventArgs e)
        {
            (sender as FlowLayoutPanel).Size = (sender as FlowLayoutPanel).Parent.Size;
            foreach (Control control in (sender as FlowLayoutPanel).Controls)
            {
                control.Size = new Size((sender as FlowLayoutPanel).Width - 10, control.Height);
            }
        }

        private void textBoxPath1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                fileExplorer_Validation((sender as TextBox).Tag.ToString());
                if (Directory.Exists((sender as TextBox).Text))
                {
                    LoadElements((sender as TextBox).Text);
                    CreatePathHistoryBrunch((sender as TextBox).Text);
                }
                (sender as TextBox).Text = pathHistory[pathHistory.Count - 1];
                (sender as TextBox).Text += " ";
            }
        }

        private void цаетоваяСхемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                ChangeFont(panelContainer, fontDialog.Font);
            }
        }

        private void ChangeFont(Control control, Font font)
        {
            if (control.Controls.Count == 0) control.Font = font;
            else
            {
                foreach (Control control1 in control.Controls)
                {
                    ChangeFont(control1, font);
                }
            }
        }

        private void директорияПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDirectoryDialog formDirectoryDialog = new FormDirectoryDialog(pathStarting1, pathStarting2, pathSaving1, pathSaving2);
            if (formDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                pathSaving1 = formDirectoryDialog.radioButtonLeft1.Checked;
                pathStarting1 = formDirectoryDialog.textBoxLeft.Text;

                pathSaving2 = formDirectoryDialog.radioButtonRight1.Checked;
                pathStarting2 = formDirectoryDialog.textBoxRight.Text;
            }
        }

        private void FormTC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pathSaving1) pathStarting1 = textBoxPath1.Text;
            StreamWriter sw1 = new StreamWriter("1.txt");
            sw1.Write(pathStarting1 + "*" + pathSaving1.ToString());
            sw1.Close();

            if (pathSaving2) pathStarting2 = textBoxPath2.Text;
            StreamWriter sw2 = new StreamWriter("2.txt");
            sw2.Write(pathStarting2 + "*" + pathSaving2.ToString());
            sw2.Close();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadElements(textBoxPath.Text);
        }
    }
}
