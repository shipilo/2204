using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2204
{
    public partial class Element : UserControl
    {
        public bool Selected;
        private string path;
        private FormTC formTC;

        public Element(Image iconImage, string name, string path, int width, FormTC formTC)
        {
            InitializeComponent();
            Icon.Image = iconImage;
            if (iconImage != null) Icon.BackgroundImage = null;
            File.Text = name;
            Selected = false;
            this.path = path;
            this.formTC = formTC;
            this.Size = new Size(width - 10, this.Height);
            this.ContextMenuStrip = formTC.contextMenuStrip;
        }

        private void Element_Click(object sender, System.EventArgs e)
        {
            formTC.fileExplorer_Validation(this.Parent.Tag.ToString());
            Selected = !Selected;
            if (Selected)
            {
                this.BackColor = Color.FromArgb(170, 215, 230);
                formTC.pathsSelected.Add(path);
            }
            else
            {
                this.BackColor = Color.White;
                formTC.pathsSelected.Remove(path);
            }
        }

        private void Element_DoubleClick(object sender, EventArgs e)
        {
            if (Selected)
            {
                this.BackColor = Color.White;
                if (formTC.pathsSelected.Contains(path)) formTC.pathsSelected.Remove(path);
            }
            formTC.LoadElements(path);
            formTC.CreatePathHistoryBrunch(path);
        }

        private void Element_Enter(object sender, EventArgs e)
        {
            if (!Selected) this.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void Element_Leave(object sender, EventArgs e)
        {
            if (!Selected) this.BackColor = Color.Transparent;
        }
    }
}
