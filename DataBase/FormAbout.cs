using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBase
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        //т По нажатию на форму - выход
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
