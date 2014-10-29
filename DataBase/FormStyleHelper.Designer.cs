namespace DataBase
{
    partial class FormStyleHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStyleHelper));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddStyle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditStyle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveStyle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Hide2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.List3 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripQStyles = new System.Windows.Forms.ToolStripStatusLabel();
            this.SBString = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Style = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStyle,
            this.toolStripSeparator1,
            this.EditStyle,
            this.toolStripSeparator2,
            this.SaveStyle,
            this.toolStripSeparator3,
            this.Hide2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddStyle
            // 
            this.AddStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddStyle.Image = ((System.Drawing.Image)(resources.GetObject("AddStyle.Image")));
            this.AddStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStyle.Name = "AddStyle";
            this.AddStyle.Size = new System.Drawing.Size(23, 22);
            this.AddStyle.Text = "toolStripButton1";
            this.AddStyle.ToolTipText = "Добавить";
            this.AddStyle.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.AddStyle.MouseEnter += new System.EventHandler(this.AddStyle_MouseEnter);
            this.AddStyle.Click += new System.EventHandler(this.AddStyle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditStyle
            // 
            this.EditStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditStyle.Image = ((System.Drawing.Image)(resources.GetObject("EditStyle.Image")));
            this.EditStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditStyle.Name = "EditStyle";
            this.EditStyle.Size = new System.Drawing.Size(23, 22);
            this.EditStyle.Text = "toolStripButton2";
            this.EditStyle.ToolTipText = "Редактировать";
            this.EditStyle.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.EditStyle.MouseEnter += new System.EventHandler(this.EditStyle_MouseEnter);
            this.EditStyle.Click += new System.EventHandler(this.EditStyle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveStyle
            // 
            this.SaveStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveStyle.Image = ((System.Drawing.Image)(resources.GetObject("SaveStyle.Image")));
            this.SaveStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveStyle.Name = "SaveStyle";
            this.SaveStyle.Size = new System.Drawing.Size(23, 22);
            this.SaveStyle.Text = "toolStripButton1";
            this.SaveStyle.ToolTipText = "Сохранить";
            this.SaveStyle.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.SaveStyle.MouseEnter += new System.EventHandler(this.SaveStyle_MouseEnterr);
            this.SaveStyle.Click += new System.EventHandler(this.SaveStyle_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Hide2
            // 
            this.Hide2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Hide2.BackColor = System.Drawing.Color.White;
            this.Hide2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hide2.Name = "Hide2";
            this.Hide2.ReadOnly = true;
            this.Hide2.Size = new System.Drawing.Size(40, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "Номер стиля: ";
            // 
            // List3
            // 
            this.List3.Cursor = System.Windows.Forms.Cursors.Default;
            this.List3.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.List3, "Сюда выводятся все стили из базы данных");
            this.List3.Location = new System.Drawing.Point(34, 109);
            this.List3.Name = "List3";
            this.helpProvider1.SetShowHelp(this.List3, true);
            this.List3.Size = new System.Drawing.Size(155, 173);
            this.List3.TabIndex = 3;
            this.List3.MouseEnter += new System.EventHandler(this.List3_MouseEnter);
            this.List3.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripQStyles,
            this.SBString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripQStyles
            // 
            this.StripQStyles.BackColor = System.Drawing.SystemColors.Control;
            this.StripQStyles.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StripQStyles.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.StripQStyles.Name = "StripQStyles";
            this.StripQStyles.Size = new System.Drawing.Size(116, 17);
            this.StripQStyles.Text = "Количество стилей: ";
            // 
            // SBString
            // 
            this.SBString.BackColor = System.Drawing.SystemColors.Control;
            this.SBString.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.SBString.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.SBString.Name = "SBString";
            this.SBString.Size = new System.Drawing.Size(110, 17);
            this.SBString.Text = "Строка состояния: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase.Properties.Resources.stylehelper;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 307);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Style
            // 
            this.Style.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpProvider1.SetHelpString(this.Style, "Название стиля");
            this.Style.Location = new System.Drawing.Point(209, 109);
            this.Style.MaxLength = 20;
            this.Style.Name = "Style";
            this.helpProvider1.SetShowHelp(this.Style, true);
            this.Style.Size = new System.Drawing.Size(155, 20);
            this.Style.TabIndex = 5;
            // 
            // FormStyleHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.Style);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.List3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStyleHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник стилей^^";
            this.Load += new System.EventHandler(this.FormStyleHelper_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripQStyles;
        private System.Windows.Forms.ToolStripStatusLabel SBString;
        private System.Windows.Forms.ToolStripButton AddStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EditStyle;
        private System.Windows.Forms.TextBox Style;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripTextBox Hide2;
    }
}