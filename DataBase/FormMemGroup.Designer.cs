namespace DataBase
{
    partial class FormMemGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemGroup));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddMem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditMem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveMem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Hide2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripQMems = new System.Windows.Forms.ToolStripStatusLabel();
            this.SBString = new System.Windows.Forms.ToolStripStatusLabel();
            this.List3 = new System.Windows.Forms.ListBox();
            this.MemName = new System.Windows.Forms.TextBox();
            this.MemStatus = new System.Windows.Forms.ComboBox();
            this.TBMemStatus = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMem,
            this.toolStripSeparator1,
            this.EditMem,
            this.toolStripSeparator2,
            this.SaveMem,
            this.toolStripSeparator3,
            this.RemoveMem,
            this.toolStripSeparator4,
            this.Hide2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddMem
            // 
            this.AddMem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddMem.Image = ((System.Drawing.Image)(resources.GetObject("AddMem.Image")));
            this.AddMem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddMem.Name = "AddMem";
            this.AddMem.Size = new System.Drawing.Size(23, 22);
            this.AddMem.Text = "toolStripButton1";
            this.AddMem.ToolTipText = "Добавить";
            this.AddMem.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.AddMem.MouseEnter += new System.EventHandler(this.AddMem_MouseEnter);
            this.AddMem.Click += new System.EventHandler(this.AddMem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditMem
            // 
            this.EditMem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditMem.Image = ((System.Drawing.Image)(resources.GetObject("EditMem.Image")));
            this.EditMem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditMem.Name = "EditMem";
            this.EditMem.Size = new System.Drawing.Size(23, 22);
            this.EditMem.Text = "toolStripButton2";
            this.EditMem.ToolTipText = "Редактировать";
            this.EditMem.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.EditMem.MouseEnter += new System.EventHandler(this.EditMem_MouseEnter);
            this.EditMem.Click += new System.EventHandler(this.EditMem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveMem
            // 
            this.SaveMem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveMem.Image = ((System.Drawing.Image)(resources.GetObject("SaveMem.Image")));
            this.SaveMem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveMem.Name = "SaveMem";
            this.SaveMem.Size = new System.Drawing.Size(23, 22);
            this.SaveMem.Text = "toolStripButton3";
            this.SaveMem.ToolTipText = "Сохранить";
            this.SaveMem.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.SaveMem.MouseEnter += new System.EventHandler(this.SaveMem_MouseEnterr);
            this.SaveMem.Click += new System.EventHandler(this.SaveMem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // RemoveMem
            // 
            this.RemoveMem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveMem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveMem.Image")));
            this.RemoveMem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveMem.Name = "RemoveMem";
            this.RemoveMem.Size = new System.Drawing.Size(23, 22);
            this.RemoveMem.Text = "toolStripButton4";
            this.RemoveMem.ToolTipText = "Удалить";
            this.RemoveMem.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.RemoveMem.MouseEnter += new System.EventHandler(this.RemoveMem_MouseEnterr);
            this.RemoveMem.Click += new System.EventHandler(this.RemoveMemGroup_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabel1.Text = "Номер участника: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 298);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripQMems,
            this.SBString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripQMems
            // 
            this.StripQMems.BackColor = System.Drawing.SystemColors.Control;
            this.StripQMems.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StripQMems.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.StripQMems.Name = "StripQMems";
            this.StripQMems.Size = new System.Drawing.Size(140, 17);
            this.StripQMems.Text = "Количество участников: ";
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
            this.helpProvider1.SetHelpString(this.List3, "Сюда выводятся все участники выбранной группы");
            this.List3.Location = new System.Drawing.Point(34, 109);
            this.List3.Name = "List3";
            this.helpProvider1.SetShowHelp(this.List3, true);
            this.List3.Size = new System.Drawing.Size(155, 173);
            this.List3.TabIndex = 5;
            this.List3.MouseEnter += new System.EventHandler(this.List3_MouseEnter);
            this.List3.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            // 
            // MemName
            // 
            this.MemName.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpProvider1.SetHelpString(this.MemName, "Имя участника");
            this.MemName.Location = new System.Drawing.Point(210, 130);
            this.MemName.MaxLength = 40;
            this.MemName.Name = "MemName";
            this.helpProvider1.SetShowHelp(this.MemName, true);
            this.MemName.Size = new System.Drawing.Size(155, 20);
            this.MemName.TabIndex = 7;
            // 
            // MemStatus
            // 
            this.MemStatus.FormattingEnabled = true;
            this.MemStatus.Location = new System.Drawing.Point(210, 179);
            this.MemStatus.Name = "MemStatus";
            this.MemStatus.Size = new System.Drawing.Size(155, 21);
            this.MemStatus.TabIndex = 8;
            this.MemStatus.SelectedIndexChanged += new System.EventHandler(this.MemStatus_SelectedIndexChanged);
            // 
            // TBMemStatus
            // 
            this.TBMemStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpProvider1.SetHelpString(this.TBMemStatus, "Статус участника в группе");
            this.TBMemStatus.Location = new System.Drawing.Point(210, 180);
            this.TBMemStatus.Name = "TBMemStatus";
            this.helpProvider1.SetShowHelp(this.TBMemStatus, true);
            this.TBMemStatus.Size = new System.Drawing.Size(155, 20);
            this.TBMemStatus.TabIndex = 9;
            // 
            // FormMemGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.TBMemStatus);
            this.Controls.Add(this.MemStatus);
            this.Controls.Add(this.MemName);
            this.Controls.Add(this.List3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMemGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация об участниках группы^^";
            this.Load += new System.EventHandler(this.FormMemGroup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddMem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EditMem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveMem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton RemoveMem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripQMems;
        private System.Windows.Forms.ToolStripStatusLabel SBString;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.TextBox MemName;
        private System.Windows.Forms.ComboBox MemStatus;
        private System.Windows.Forms.TextBox TBMemStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        public System.Windows.Forms.ToolStripTextBox Hide2;
    }
}