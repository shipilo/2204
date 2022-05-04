
namespace _2204
{
    partial class FormDirectoryDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirectoryDialog));
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.radioButtonLeft2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLeft1 = new System.Windows.Forms.RadioButton();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.radioButtonRight2 = new System.Windows.Forms.RadioButton();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.radioButtonRight1 = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.buttonLeft);
            this.groupBoxLeft.Controls.Add(this.textBoxLeft);
            this.groupBoxLeft.Controls.Add(this.radioButtonLeft2);
            this.groupBoxLeft.Controls.Add(this.radioButtonLeft1);
            this.groupBoxLeft.Font = new System.Drawing.Font("Segoe UI", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxLeft.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(450, 150);
            this.groupBoxLeft.TabIndex = 0;
            this.groupBoxLeft.TabStop = false;
            this.groupBoxLeft.Text = "Левая сторона";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(361, 100);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 29);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "Обзор...";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Location = new System.Drawing.Point(30, 100);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(324, 29);
            this.textBoxLeft.TabIndex = 2;
            // 
            // radioButtonLeft2
            // 
            this.radioButtonLeft2.AutoSize = true;
            this.radioButtonLeft2.Location = new System.Drawing.Point(30, 69);
            this.radioButtonLeft2.Name = "radioButtonLeft2";
            this.radioButtonLeft2.Size = new System.Drawing.Size(259, 25);
            this.radioButtonLeft2.TabIndex = 1;
            this.radioButtonLeft2.TabStop = true;
            this.radioButtonLeft2.Text = "Загружать директорию по пути";
            this.radioButtonLeft2.UseVisualStyleBackColor = true;
            this.radioButtonLeft2.CheckedChanged += new System.EventHandler(this.radioButtonLeft1_CheckedChanged);
            // 
            // radioButtonLeft1
            // 
            this.radioButtonLeft1.AutoSize = true;
            this.radioButtonLeft1.Location = new System.Drawing.Point(30, 38);
            this.radioButtonLeft1.Name = "radioButtonLeft1";
            this.radioButtonLeft1.Size = new System.Drawing.Size(390, 25);
            this.radioButtonLeft1.TabIndex = 0;
            this.radioButtonLeft1.TabStop = true;
            this.radioButtonLeft1.Text = "Сохранять директорию при закрытии программы";
            this.radioButtonLeft1.UseVisualStyleBackColor = true;
            this.radioButtonLeft1.CheckedChanged += new System.EventHandler(this.radioButtonLeft1_CheckedChanged);
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.buttonRight);
            this.groupBoxRight.Controls.Add(this.radioButtonRight2);
            this.groupBoxRight.Controls.Add(this.textBoxRight);
            this.groupBoxRight.Controls.Add(this.radioButtonRight1);
            this.groupBoxRight.Font = new System.Drawing.Font("Segoe UI", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRight.Location = new System.Drawing.Point(12, 157);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(450, 150);
            this.groupBoxRight.TabIndex = 1;
            this.groupBoxRight.TabStop = false;
            this.groupBoxRight.Text = "Правая сторона";
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(361, 99);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 29);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "Обзор...";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // radioButtonRight2
            // 
            this.radioButtonRight2.AutoSize = true;
            this.radioButtonRight2.Location = new System.Drawing.Point(30, 68);
            this.radioButtonRight2.Name = "radioButtonRight2";
            this.radioButtonRight2.Size = new System.Drawing.Size(259, 25);
            this.radioButtonRight2.TabIndex = 1;
            this.radioButtonRight2.TabStop = true;
            this.radioButtonRight2.Text = "Загружать директорию по пути";
            this.radioButtonRight2.UseVisualStyleBackColor = true;
            this.radioButtonRight2.CheckedChanged += new System.EventHandler(this.radioButtonRight1_CheckedChanged);
            // 
            // textBoxRight
            // 
            this.textBoxRight.Location = new System.Drawing.Point(30, 99);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(324, 29);
            this.textBoxRight.TabIndex = 2;
            // 
            // radioButtonRight1
            // 
            this.radioButtonRight1.AutoSize = true;
            this.radioButtonRight1.Location = new System.Drawing.Point(30, 37);
            this.radioButtonRight1.Name = "radioButtonRight1";
            this.radioButtonRight1.Size = new System.Drawing.Size(390, 25);
            this.radioButtonRight1.TabIndex = 0;
            this.radioButtonRight1.TabStop = true;
            this.radioButtonRight1.Text = "Сохранять директорию при закрытии программы";
            this.radioButtonRight1.UseVisualStyleBackColor = true;
            this.radioButtonRight1.CheckedChanged += new System.EventHandler(this.radioButtonRight1_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(361, 314);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 27);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormDirectoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 353);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxRight);
            this.Controls.Add(this.groupBoxLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDirectoryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Директория по умолчанию";
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxLeft.PerformLayout();
            this.groupBoxRight.ResumeLayout(false);
            this.groupBoxRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.RadioButton radioButtonLeft2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.RadioButton radioButtonRight2;
        public System.Windows.Forms.TextBox textBoxLeft;
        public System.Windows.Forms.TextBox textBoxRight;
        public System.Windows.Forms.RadioButton radioButtonLeft1;
        public System.Windows.Forms.RadioButton radioButtonRight1;
    }
}