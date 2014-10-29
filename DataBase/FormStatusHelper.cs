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
    public partial class FormStatusHelper : Form
    {
        public FormStatusHelper()
        {
            InitializeComponent();
        }
        //
        int K = 0;
        //____________________________________________________________________________________
        //
        // ОПРЕДЕЛЕНИЕ ДАННЫХ ИЗ БД
        //____________________________________________________________________________________
        // СОЗДАНИЕ ДАТАСЕТ И АДАПТЕРОВ   
        DataSetAlbums dsAlbums = new DataSetAlbums();
        // 
        DataSetAlbumsTableAdapters.TableStatusTableAdapter daStatus =
           new DataBase.DataSetAlbumsTableAdapters.
           TableStatusTableAdapter();
        //
        //
        private void StatusFill()
        {
            daStatus.Fill(dsAlbums.TableStatus);
            StripQStatus.Text = "Количество статусов: " + daStatus.ScalarQuery();
        }
        // ЗАГРУЗКА ДАННЫХ ПРИ ЗАГРУЗКЕ ПРИЛОЖЕНИЯ
        private void FormStatusHelper_Load(object sender, EventArgs e)
        {
            List3.Focus();
            Status.ReadOnly = true;
            StatusFill();
            //
            List3.DataSource = dsAlbums;
            List3.DisplayMember = "TableStatus.StatusName";
            List3.ValueMember = "TableStatus.StatusID";
            //
            Status.DataBindings.Add("Text", dsAlbums,
           "TableStatus.StatusName");
            Status.ReadOnly = true;
            Hide2.TextBox.DataBindings.Add("Text", dsAlbums,
           "TableStatus.StatusID");
        }
        //____________________________________________________________________________________
        //
        // СТРОКИ СОСТОЯНИЯ:
        //____________________________________________________________________________________
        private void List3_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Список статусов";
        }
        //
        private void List3_MouseLeave(object sender, EventArgs e)
        {
            SBString.Text = "Строка состояния: ";
        }
        //
        private void AddStatus_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Добавить статус";
        }
        //
        private void EditStatus_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Редактировать статус";
        }
        //
        private void SaveStatus_MouseEnterr(object sender, EventArgs e)
        {
            SBString.Text += "Сохранить статус";
        }       
        // ДОБАВИТЬ СТАТУС
        private void AddStatus_Click(object sender, EventArgs e)
        {
            Status.ReadOnly = false;
            List3.Enabled = false;
            Status.Text = "";
            Status.Focus();
            K = 1;
        }
        // ИЗМЕНИТЬ СТАТУС
        private void EditStatus_Click(object sender, EventArgs e)
        {
            Status.ReadOnly = false;
            List3.Enabled = false;
            Status.Focus();
            K = 2;
        }
        // СОХРАНИТЬ ИЗМЕНЕНИЯ
        private void SaveStatus_Click(object sender, EventArgs e)
        {
            int l = 0;
            if (K == 1)
            {
                if (Status.Text == ""||Status.TextLength>20)
                {
                    MessageBox.Show("Неверно введено название статуса!");
                }
                else
                {
                    daStatus.InsertQuery(Status.Text.ToUpper(), (short)(daStatus.ScalarQuery() + 1));
                    l = 1;
                }
            }
            //
            if (K == 2)
            {
                if (Status.Text == "" || Status.TextLength > 20)
                {
                    MessageBox.Show("Неверно введено название статуса!");
                }
                else
                {
                    daStatus.UpdateQuery(Status.Text.ToUpper(), short.Parse(Hide2.Text));
                    l = 1;
                }
            }
            //
            Status.ReadOnly = true;
            List3.Enabled = true;
            if (l == 1)
            {
                daStatus.Update(dsAlbums.TableStatus);
                StatusFill();
            }
            
        }

       
    
    }
}
