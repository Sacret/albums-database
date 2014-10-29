namespace DataBase
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RBCountry = new System.Windows.Forms.RadioButton();
            this.RBComp = new System.Windows.Forms.RadioButton();
            this.RBStyle = new System.Windows.Forms.RadioButton();
            this.RBStatus = new System.Windows.Forms.RadioButton();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.List3 = new System.Windows.Forms.ListBox();
            this.CBSearch = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SBString = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 301);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RBCountry
            // 
            this.RBCountry.AutoSize = true;
            this.RBCountry.BackColor = System.Drawing.SystemColors.Control;
            this.RBCountry.Checked = true;
            this.RBCountry.Location = new System.Drawing.Point(67, 128);
            this.RBCountry.Name = "RBCountry";
            this.RBCountry.Size = new System.Drawing.Size(14, 13);
            this.RBCountry.TabIndex = 3;
            this.RBCountry.TabStop = true;
            this.RBCountry.UseVisualStyleBackColor = false;
            // 
            // RBComp
            // 
            this.RBComp.AutoSize = true;
            this.RBComp.BackColor = System.Drawing.SystemColors.Control;
            this.RBComp.Location = new System.Drawing.Point(67, 145);
            this.RBComp.Name = "RBComp";
            this.RBComp.Size = new System.Drawing.Size(14, 13);
            this.RBComp.TabIndex = 4;
            this.RBComp.UseVisualStyleBackColor = false;
            // 
            // RBStyle
            // 
            this.RBStyle.AutoSize = true;
            this.RBStyle.BackColor = System.Drawing.SystemColors.Control;
            this.RBStyle.Location = new System.Drawing.Point(67, 162);
            this.RBStyle.Name = "RBStyle";
            this.RBStyle.Size = new System.Drawing.Size(14, 13);
            this.RBStyle.TabIndex = 5;
            this.RBStyle.UseVisualStyleBackColor = false;
            // 
            // RBStatus
            // 
            this.RBStatus.AutoSize = true;
            this.RBStatus.BackColor = System.Drawing.SystemColors.Control;
            this.RBStatus.Location = new System.Drawing.Point(67, 179);
            this.RBStatus.Name = "RBStatus";
            this.RBStatus.Size = new System.Drawing.Size(14, 13);
            this.RBStatus.TabIndex = 7;
            this.RBStatus.UseVisualStyleBackColor = false;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.Location = new System.Drawing.Point(31, 220);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(158, 20);
            this.ButtonSearch.TabIndex = 10;
            this.ButtonSearch.Text = "ИСКАТЬ";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // List3
            // 
            this.List3.Cursor = System.Windows.Forms.Cursors.Default;
            this.List3.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.List3, "Сюда выводятся результаты поиска");
            this.List3.Location = new System.Drawing.Point(210, 92);
            this.List3.Name = "List3";
            this.helpProvider1.SetShowHelp(this.List3, true);
            this.List3.Size = new System.Drawing.Size(158, 147);
            this.List3.TabIndex = 11;
            // 
            // CBSearch
            // 
            this.CBSearch.FormattingEnabled = true;
            this.CBSearch.Location = new System.Drawing.Point(31, 92);
            this.CBSearch.Name = "CBSearch";
            this.CBSearch.Size = new System.Drawing.Size(158, 21);
            this.CBSearch.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SBString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(402, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SBString
            // 
            this.SBString.BackColor = System.Drawing.SystemColors.Control;
            this.SBString.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.SBString.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.SBString.Name = "SBString";
            this.SBString.Size = new System.Drawing.Size(62, 17);
            this.SBString.Text = "Найдено: ";
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEnter.Location = new System.Drawing.Point(31, 93);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(158, 20);
            this.ButtonEnter.TabIndex = 16;
            this.ButtonEnter.Text = "ВВОД";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(402, 320);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CBSearch);
            this.Controls.Add(this.List3);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.RBStatus);
            this.Controls.Add(this.RBStyle);
            this.Controls.Add(this.RBComp);
            this.Controls.Add(this.RBCountry);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск^^";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RBCountry;
        private System.Windows.Forms.RadioButton RBComp;
        private System.Windows.Forms.RadioButton RBStyle;
        private System.Windows.Forms.RadioButton RBStatus;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.ComboBox CBSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SBString;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.HelpProvider helpProvider1;


    }
}