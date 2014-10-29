namespace DataBase
{
    partial class FormCountryHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCountryHelper));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddCountry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditCountry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveCounrty = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Hide2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripQCountry = new System.Windows.Forms.ToolStripStatusLabel();
            this.SBString = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.List3 = new System.Windows.Forms.ListBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCountry,
            this.toolStripSeparator1,
            this.EditCountry,
            this.toolStripSeparator2,
            this.SaveCounrty,
            this.toolStripSeparator3,
            this.Hide2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddCountry
            // 
            this.AddCountry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCountry.Image = ((System.Drawing.Image)(resources.GetObject("AddCountry.Image")));
            this.AddCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(23, 22);
            this.AddCountry.Text = "toolStripButton1";
            this.AddCountry.ToolTipText = "Добавить";
            this.AddCountry.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.AddCountry.MouseEnter += new System.EventHandler(this.AddCountry_MouseEnter);
            this.AddCountry.Click += new System.EventHandler(this.AddCountry_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditCountry
            // 
            this.EditCountry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditCountry.Image = ((System.Drawing.Image)(resources.GetObject("EditCountry.Image")));
            this.EditCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCountry.Name = "EditCountry";
            this.EditCountry.Size = new System.Drawing.Size(23, 22);
            this.EditCountry.Text = "toolStripButton2";
            this.EditCountry.ToolTipText = "Редактировать";
            this.EditCountry.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.EditCountry.MouseEnter += new System.EventHandler(this.EditCountry_MouseEnter);
            this.EditCountry.Click += new System.EventHandler(this.EditCountry_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveCounrty
            // 
            this.SaveCounrty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveCounrty.Image = ((System.Drawing.Image)(resources.GetObject("SaveCounrty.Image")));
            this.SaveCounrty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveCounrty.Name = "SaveCounrty";
            this.SaveCounrty.Size = new System.Drawing.Size(23, 22);
            this.SaveCounrty.Text = "toolStripButton3";
            this.SaveCounrty.ToolTipText = "Сохранить";
            this.SaveCounrty.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            this.SaveCounrty.MouseEnter += new System.EventHandler(this.SaveCountry_MouseEnterr);
            this.SaveCounrty.Click += new System.EventHandler(this.SaveCountry_Click);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel1.Text = "Номер страны: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripQCountry,
            this.SBString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripQCountry
            // 
            this.StripQCountry.BackColor = System.Drawing.SystemColors.Control;
            this.StripQCountry.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StripQCountry.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.StripQCountry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StripQCountry.Name = "StripQCountry";
            this.StripQCountry.Size = new System.Drawing.Size(110, 17);
            this.StripQCountry.Text = "Количество стран: ";
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
            this.pictureBox1.Size = new System.Drawing.Size(406, 303);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // List3
            // 
            this.List3.Cursor = System.Windows.Forms.Cursors.Default;
            this.List3.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.List3, "Сюда выводятся все страны из базы данных");
            this.List3.Location = new System.Drawing.Point(34, 109);
            this.List3.Name = "List3";
            this.helpProvider1.SetShowHelp(this.List3, true);
            this.List3.Size = new System.Drawing.Size(155, 173);
            this.List3.TabIndex = 4;
            this.List3.MouseEnter += new System.EventHandler(this.List3_MouseEnter);
            this.List3.MouseLeave += new System.EventHandler(this.List3_MouseLeave);
            // 
            // Country
            // 
            this.Country.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpProvider1.SetHelpString(this.Country, "Название страны");
            this.Country.Location = new System.Drawing.Point(209, 109);
            this.Country.MaxLength = 20;
            this.Country.Name = "Country";
            this.helpProvider1.SetShowHelp(this.Country, true);
            this.Country.Size = new System.Drawing.Size(155, 20);
            this.Country.TabIndex = 6;
            // 
            // FormCountryHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.Country);
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
            this.Name = "FormCountryHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник стран^^";
            this.Load += new System.EventHandler(this.FormCountryHelper_Load);
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
        private System.Windows.Forms.ToolStripStatusLabel StripQCountry;
        private System.Windows.Forms.ToolStripStatusLabel SBString;
        private System.Windows.Forms.ToolStripButton AddCountry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EditCountry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveCounrty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripTextBox Hide2;
    }
}