namespace DataBase
{
    partial class FormSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSong));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddSong = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditSong = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveSong = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveSong = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Hide2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripQSongs = new System.Windows.Forms.ToolStripStatusLabel();
            this.SBString = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.List3 = new System.Windows.Forms.ListBox();
            this.Song = new System.Windows.Forms.TextBox();
            this.SongTime = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSong,
            this.toolStripSeparator1,
            this.EditSong,
            this.toolStripSeparator2,
            this.SaveSong,
            this.toolStripSeparator3,
            this.RemoveSong,
            this.toolStripSeparator4,
            this.Hide2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddSong
            // 
            this.AddSong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddSong.Image = ((System.Drawing.Image)(resources.GetObject("AddSong.Image")));
            this.AddSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSong.Name = "AddSong";
            this.AddSong.Size = new System.Drawing.Size(23, 22);
            this.AddSong.Text = "toolStripButton1";
            this.AddSong.ToolTipText = "Добавить";
            this.AddSong.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.AddSong.MouseEnter += new System.EventHandler(this.AddSong_MouseEnter);
            this.AddSong.Click += new System.EventHandler(this.AddSong_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditSong
            // 
            this.EditSong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditSong.Image = ((System.Drawing.Image)(resources.GetObject("EditSong.Image")));
            this.EditSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditSong.Name = "EditSong";
            this.EditSong.Size = new System.Drawing.Size(23, 22);
            this.EditSong.Text = "toolStripButton2";
            this.EditSong.ToolTipText = "Редактировать";
            this.EditSong.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.EditSong.MouseEnter += new System.EventHandler(this.EditSong_MouseEnter);
            this.EditSong.Click += new System.EventHandler(this.EditSong_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveSong
            // 
            this.SaveSong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveSong.Image = ((System.Drawing.Image)(resources.GetObject("SaveSong.Image")));
            this.SaveSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveSong.Name = "SaveSong";
            this.SaveSong.Size = new System.Drawing.Size(23, 22);
            this.SaveSong.Text = "toolStripButton3";
            this.SaveSong.ToolTipText = "Сохранить";
            this.SaveSong.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.SaveSong.MouseEnter += new System.EventHandler(this.SaveSong_MouseEnter);
            this.SaveSong.Click += new System.EventHandler(this.SaveSong_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // RemoveSong
            // 
            this.RemoveSong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveSong.Image = ((System.Drawing.Image)(resources.GetObject("RemoveSong.Image")));
            this.RemoveSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveSong.Name = "RemoveSong";
            this.RemoveSong.Size = new System.Drawing.Size(23, 22);
            this.RemoveSong.Text = "toolStripButton1";
            this.RemoveSong.ToolTipText = "Удалить песню";
            this.RemoveSong.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.RemoveSong.MouseEnter += new System.EventHandler(this.RemoveSong_MouseEnter);
            this.RemoveSong.Click += new System.EventHandler(this.RemoveSong_Click);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "Номер песни: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripQSongs,
            this.SBString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripQSongs
            // 
            this.StripQSongs.BackColor = System.Drawing.SystemColors.Control;
            this.StripQSongs.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StripQSongs.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.StripQSongs.Name = "StripQSongs";
            this.StripQSongs.Size = new System.Drawing.Size(110, 17);
            this.StripQSongs.Text = "Количество песен: ";
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 300);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // List3
            // 
            this.List3.Cursor = System.Windows.Forms.Cursors.Default;
            this.List3.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.List3, "Сюда выводятся все песни из выбранного альбома");
            this.List3.Location = new System.Drawing.Point(34, 109);
            this.List3.Name = "List3";
            this.helpProvider1.SetShowHelp(this.List3, true);
            this.List3.Size = new System.Drawing.Size(155, 173);
            this.List3.TabIndex = 4;
            this.List3.MouseEnter += new System.EventHandler(this.List3_MouseEnter);
            this.List3.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            // 
            // Song
            // 
            this.Song.Cursor = System.Windows.Forms.Cursors.Default;
            this.Song.Location = new System.Drawing.Point(210, 130);
            this.Song.MaxLength = 40;
            this.Song.Name = "Song";
            this.Song.Size = new System.Drawing.Size(155, 20);
            this.Song.TabIndex = 6;
            // 
            // SongTime
            // 
            this.SongTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.SongTime.Location = new System.Drawing.Point(210, 173);
            this.SongTime.MaxLength = 5;
            this.SongTime.Name = "SongTime";
            this.SongTime.Size = new System.Drawing.Size(155, 20);
            this.SongTime.TabIndex = 7;
            // 
            // FormSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.SongTime);
            this.Controls.Add(this.Song);
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
            this.Name = "FormSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о песнях^^";
            this.Load += new System.EventHandler(this.FormSong_Load);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton AddSong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EditSong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveSong;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.TextBox Song;
        private System.Windows.Forms.TextBox SongTime;
        private System.Windows.Forms.ToolStripStatusLabel StripQSongs;
        private System.Windows.Forms.ToolStripStatusLabel SBString;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton RemoveSong;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripTextBox Hide2;
    }
}