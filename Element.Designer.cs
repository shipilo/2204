
namespace _2204
{
    partial class Element
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.File = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.ColumnCount = 2;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Controls.Add(this.Icon, 0, 0);
            this.Panel.Controls.Add(this.File, 1, 0);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 1;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Size = new System.Drawing.Size(200, 30);
            this.Panel.TabIndex = 0;
            this.Panel.Click += new System.EventHandler(this.Element_Click);
            //this.Panel.Click += new System.EventHandler(formTC.FileExplorer_Validation);
            this.Panel.DoubleClick += new System.EventHandler(this.Element_DoubleClick);
            this.Panel.MouseEnter += new System.EventHandler(this.Element_Enter);
            this.Panel.MouseLeave += new System.EventHandler(this.Element_Leave);
            // 
            // Icon
            // 
            this.Icon.BackgroundImage = global::_2204.Properties.Resources.icon;
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Icon.Location = new System.Drawing.Point(3, 3);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(24, 24);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            this.Icon.Click += new System.EventHandler(this.Element_Click);
            this.Icon.DoubleClick += new System.EventHandler(this.Element_DoubleClick);
            this.Icon.MouseEnter += new System.EventHandler(this.Element_Enter);
            this.Icon.MouseLeave += new System.EventHandler(this.Element_Leave);
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Dock = System.Windows.Forms.DockStyle.Left;
            this.File.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File.Location = new System.Drawing.Point(33, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(0, 30);
            this.File.TabIndex = 1;
            this.File.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.File.Click += new System.EventHandler(this.Element_Click);
            this.File.DoubleClick += new System.EventHandler(this.Element_DoubleClick);
            this.File.MouseEnter += new System.EventHandler(this.Element_Enter);
            this.File.MouseLeave += new System.EventHandler(this.Element_Leave);
            // 
            // Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "Element";
            this.Size = new System.Drawing.Size(200, 30);
            this.Click += new System.EventHandler(this.Element_Click);
            this.DoubleClick += new System.EventHandler(this.Element_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.Element_Enter);
            this.MouseLeave += new System.EventHandler(this.Element_Leave);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Label File;
    }
}
