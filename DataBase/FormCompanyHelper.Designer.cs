namespace DataBase
{
    partial class FormCompanyHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompanyHelper));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddComp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditComp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveComp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Hide2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripQCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.SBString = new System.Windows.Forms.ToolStripStatusLabel();
            this.List3 = new System.Windows.Forms.ListBox();
            this.Company = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddComp,
            this.toolStripSeparator1,
            this.EditComp,
            this.toolStripSeparator2,
            this.SaveComp,
            this.toolStripSeparator3,
            this.Hide2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddComp
            // 
            this.AddComp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddComp.Image = ((System.Drawing.Image)(resources.GetObject("AddComp.Image")));
            this.AddComp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddComp.Name = "AddComp";
            this.AddComp.Size = new System.Drawing.Size(23, 22);
            this.AddComp.Text = "toolStripButton1";
            this.AddComp.ToolTipText = "Добавить";
            this.AddComp.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.AddComp.MouseEnter += new System.EventHandler(this.AddCompany_MouseEnter);
            this.AddComp.Click += new System.EventHandler(this.AddCompany_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditComp
            // 
            this.EditComp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditComp.Image = ((System.Drawing.Image)(resources.GetObject("EditComp.Image")));
            this.EditComp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditComp.Name = "EditComp";
            this.EditComp.Size = new System.Drawing.Size(23, 22);
            this.EditComp.Text = "toolStripButton2";
            this.EditComp.ToolTipText = "Редактировать";
            this.EditComp.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.EditComp.MouseEnter += new System.EventHandler(this.EditCompany_MouseEnter);
            this.EditComp.Click += new System.EventHandler(this.EditCompany_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveComp
            // 
            this.SaveComp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveComp.Image = ((System.Drawing.Image)(resources.GetObject("SaveComp.Image")));
            this.SaveComp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveComp.Name = "SaveComp";
            this.SaveComp.Size = new System.Drawing.Size(23, 22);
            this.SaveComp.Text = "toolStripButton3";
            this.SaveComp.ToolTipText = "Сохранить";
            this.SaveComp.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.SaveComp.MouseEnter += new System.EventHandler(this.SaveCompany_MouseEnter);
            this.SaveComp.Click += new System.EventHandler(this.SaveCompany_Click);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel1.Text = " Номер компании: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripQCompany,
            this.SBString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripQCompany
            // 
            this.StripQCompany.BackColor = System.Drawing.SystemColors.Control;
            this.StripQCompany.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StripQCompany.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.StripQCompany.Name = "StripQCompany";
            this.StripQCompany.Size = new System.Drawing.Size(129, 17);
            this.StripQCompany.Text = "Количество компаний: ";
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
            // List3
            // 
            this.List3.Cursor = System.Windows.Forms.Cursors.Default;
            this.List3.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.List3, "Сюда выводятся все компании (лейблы) из базы данных");
            this.List3.Location = new System.Drawing.Point(34, 109);
            this.List3.Name = "List3";
            this.helpProvider1.SetShowHelp(this.List3, true);
            this.List3.Size = new System.Drawing.Size(155, 173);
            this.List3.TabIndex = 5;
            this.List3.MouseEnter += new System.EventHandler(this.List3_MouseEnter);
            this.List3.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            // 
            // Company
            // 
            this.Company.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpProvider1.SetHelpString(this.Company, "Название компании");
            this.Company.Location = new System.Drawing.Point(209, 109);
            this.Company.MaxLength = 30;
            this.Company.Name = "Company";
            this.helpProvider1.SetShowHelp(this.Company, true);
            this.Company.Size = new System.Drawing.Size(155, 20);
            this.Company.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 296);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormCompanyHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.List3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompanyHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник компаний^^";
            this.Load += new System.EventHandler(this.FormCompanyHelper_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripQCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel SBString;
        private System.Windows.Forms.ToolStripButton AddComp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EditComp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveComp;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripTextBox Hide2;
    }
}