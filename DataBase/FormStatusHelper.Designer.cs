namespace DataBase
{
    partial class FormStatusHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatusHelper));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Hide2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripQStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.SBString = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.List3 = new System.Windows.Forms.ListBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStatus,
            this.toolStripSeparator1,
            this.EditStatus,
            this.toolStripSeparator2,
            this.SaveStatus,
            this.toolStripSeparator3,
            this.Hide2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddStatus
            // 
            this.AddStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddStatus.Image = ((System.Drawing.Image)(resources.GetObject("AddStatus.Image")));
            this.AddStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStatus.Name = "AddStatus";
            this.AddStatus.Size = new System.Drawing.Size(23, 22);
            this.AddStatus.Text = "toolStripButton1";
            this.AddStatus.ToolTipText = "Добавить";
            this.AddStatus.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.AddStatus.MouseEnter += new System.EventHandler(this.AddStatus_MouseEnter);
            this.AddStatus.Click += new System.EventHandler(this.AddStatus_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditStatus
            // 
            this.EditStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditStatus.Image = ((System.Drawing.Image)(resources.GetObject("EditStatus.Image")));
            this.EditStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditStatus.Name = "EditStatus";
            this.EditStatus.Size = new System.Drawing.Size(23, 22);
            this.EditStatus.Text = "toolStripButton2";
            this.EditStatus.ToolTipText = "Редактировать";
            this.EditStatus.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.EditStatus.MouseEnter += new System.EventHandler(this.EditStatus_MouseEnter);
            this.EditStatus.Click += new System.EventHandler(this.EditStatus_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveStatus
            // 
            this.SaveStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveStatus.Image = ((System.Drawing.Image)(resources.GetObject("SaveStatus.Image")));
            this.SaveStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveStatus.Name = "SaveStatus";
            this.SaveStatus.Size = new System.Drawing.Size(23, 22);
            this.SaveStatus.Text = "toolStripButton3";
            this.SaveStatus.ToolTipText = "Сохранить";
            this.SaveStatus.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.SaveStatus.MouseEnter += new System.EventHandler(this.SaveStatus_MouseEnterr);
            this.SaveStatus.Click += new System.EventHandler(this.SaveStatus_Click);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Номер статуса: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripQStatus,
            this.SBString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripQStatus
            // 
            this.StripQStatus.BackColor = System.Drawing.SystemColors.Control;
            this.StripQStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StripQStatus.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.StripQStatus.Name = "StripQStatus";
            this.StripQStatus.Size = new System.Drawing.Size(127, 17);
            this.StripQStatus.Text = "Количество статусов: ";
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 306);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // List3
            // 
            this.List3.Cursor = System.Windows.Forms.Cursors.Default;
            this.List3.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.List3, "Сюда выводятся все статусы участников групп");
            this.List3.Location = new System.Drawing.Point(34, 109);
            this.List3.Name = "List3";
            this.helpProvider1.SetShowHelp(this.List3, true);
            this.List3.Size = new System.Drawing.Size(155, 173);
            this.List3.TabIndex = 6;
            this.List3.MouseEnter += new System.EventHandler(this.List3_MouseEnter);
            this.List3.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            // 
            // Status
            // 
            this.Status.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpProvider1.SetHelpString(this.Status, "Название статуса");
            this.Status.Location = new System.Drawing.Point(209, 109);
            this.Status.MaxLength = 20;
            this.Status.Name = "Status";
            this.helpProvider1.SetShowHelp(this.Status, true);
            this.Status.Size = new System.Drawing.Size(155, 20);
            this.Status.TabIndex = 7;
            // 
            // FormStatusHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.Status);
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
            this.Name = "FormStatusHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник статусов^^";
            this.Load += new System.EventHandler(this.FormStatusHelper_Load);
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
        private System.Windows.Forms.ToolStripStatusLabel StripQStatus;
        private System.Windows.Forms.ToolStripStatusLabel SBString;
        private System.Windows.Forms.ToolStripButton AddStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EditStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripTextBox Hide2;
    }
}