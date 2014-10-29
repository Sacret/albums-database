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
    public partial class FormMemGroup : Form
    {
        public FormMemGroup()
        {
            InitializeComponent();
        }
        //
        int K = 0;
        int m;
        //   
        //____________________________________________________________________________________
        //
        // ОПРЕДЕЛЕНИЕ ДАННЫХ ИЗ БД
        //____________________________________________________________________________________
        // СОЗДАНИЕ ДАТАСЕТ И АДАПТЕРОВ   
        DataSetAlbums dsAlbums = new DataSetAlbums();
        // 
        DataSetAlbumsTableAdapters.TableMemGroupTableAdapter daMemGroup =
            new DataBase.DataSetAlbumsTableAdapters.
            TableMemGroupTableAdapter();
        DataSetAlbumsTableAdapters.TableStatusTableAdapter daStatus =
            new DataBase.DataSetAlbumsTableAdapters.
            TableStatusTableAdapter();
        //
        public void ReadOnly()
        {
            MemName.ReadOnly = true;
            TBMemStatus.Visible = true; 
            TBMemStatus.ReadOnly = true;
            MemStatus.Visible = false;
        }
        //
        public void Edit()
        {
            MemName.ReadOnly = false;
            TBMemStatus.Visible = false;
            MemStatus.Visible = true;
        }
        // ЗАМЕНА КОМБО НА ТЕКСТ
        private void MemStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBMemStatus.Text = MemStatus.Text;
        }
        //
        private void MemGroupFill(int m)
        {
            daMemGroup.FillBy(dsAlbums.TableMemGroup, m);
            StripQMems.Text = "Количество участников: " + daMemGroup.ScalarQuery(m);
        }
        // ЗАГРУЗКА ДАННЫХ ПРИ ЗАГРУЗКЕ ПРИЛОЖЕНИЯ
        private void FormMemGroup_Load(object sender, EventArgs e)
        {
            List3.Focus();
            m = int.Parse((Owner as Form1).Hide1.Text);
            ReadOnly();   
            MemGroupFill(m);
            daStatus.Fill(dsAlbums.TableStatus);
            //
            List3.DataSource = dsAlbums;
            List3.DisplayMember = "TableMemGroup.MemName";
            List3.ValueMember = "TableMemGroup.MemID";
            //
            MemName.DataBindings.Add("Text", dsAlbums,
           "TableMemGroup.MemName");
            //
            MemStatus.DataSource = this.dsAlbums.TableStatus;
            MemStatus.DisplayMember = "StatusName";
            MemStatus.ValueMember = "StatusID";
            MemStatus.DataBindings.Add("SelectedValue", dsAlbums, "TableMemGroup.StatusID");  
            //
            Hide2.TextBox.DataBindings.Add("Text", dsAlbums,
           "TableMemGroup.MemID");
        }
        //____________________________________________________________________________________
        //
        // СТРОКИ СОСТОЯНИЯ:
        //____________________________________________________________________________________
        private void List3_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Список участников";
        }
        //
        private void List3_MouseLeave(object sender, EventArgs e)
        {
            SBString.Text = "Строка состояния: ";
        }
        //
        private void AddMem_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Добавить участника";
        }
        //
        private void EditMem_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Изменить участника";
        }
        //
        private void SaveMem_MouseEnterr(object sender, EventArgs e)
        {
            SBString.Text += "Сохранить участника";
        }
        //
        private void RemoveMem_MouseEnterr(object sender, EventArgs e)
        {
            SBString.Text += "Удалить участника";
        }
        // ДОБАВИТЬ УЧАСТНИКА
        private void AddMem_Click(object sender, EventArgs e)
        {
            Edit();        
            MemStatus.SelectedIndex = -1;
            List3.Enabled = false;
            MemName.Text = "";           
            MemName.Focus();
            K = 1;
        }
        // ИЗМЕНИТЬ ИНФО ОБ УЧАСТНИКЕ
        private void EditMem_Click(object sender, EventArgs e)
        {
            Edit();           
            List3.Enabled = false;
            MemName.Focus();
            K = 2;
        }
        // СОХРАНИТЬ ИЗМЕНЕНИЯ
        private void SaveMem_Click(object sender, EventArgs e)
        {
            int l = 0;
            if (K == 1)
            {
                if (MemName.Text == ""||MemName.TextLength>40)
                {
                    MessageBox.Show("Неверно введено имя участника!");
                }
                else
                {
                    daMemGroup.InsertQuery(m, MemName.Text.ToUpper(), (short)((DataRowView)MemStatus.Items[MemStatus.SelectedIndex])
                    ["StatusID"], (short)(daMemGroup.ScalarQuery1() + 1));
                    l = 1;
                }
            }
            //
            if (K == 2)
            {
                if (MemName.Text == "" || MemName.TextLength > 40)
                {
                    MessageBox.Show("Неверно введено имя участника!");
                }
                else
                {
                    daMemGroup.UpdateQuery(MemName.Text.ToUpper(), (short)((DataRowView)MemStatus.Items[MemStatus.SelectedIndex])
                    ["StatusID"], short.Parse(Hide2.Text));
                    l = 1;
                }
            }
            //
            MemName.ReadOnly = true;
            TBMemStatus.Visible = true;
            MemStatus.Visible = false;
            TBMemStatus.ReadOnly = true;
            List3.Enabled = true;
            if (l == 1)
            {
                daMemGroup.Update(dsAlbums.TableMemGroup);
                MemGroupFill(m);
            }
        }
        // УДАЛЕНИЕ УЧАСТНИКА
        private void RemoveMemGroup_Click(object sender, EventArgs e)
        {
            int pos = -1;
            pos = this.BindingContext[dsAlbums, "TableSong"].Position;
            //
            string mes = MemName.Text.ToString().Trim();
            //
            DialogResult result = MessageBox.Show("Удалить данные об участнике " + mes + "?",
             "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
             MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        //выполнить действия по удалению данных об исполнителе
                        //
                        daMemGroup.DeleteQuery(short.Parse(Hide2.Text));
                        //
                        MessageBox.Show("Удаление данных");
                        break;
                    }
                case DialogResult.No:
                    {
                        //отмена удаления данных 
                        this.dsAlbums.TableMemGroup.RejectChanges();
                        MessageBox.Show("Отмена удаления данных");
                        break;
                    }
            }
            MemGroupFill(m);
            daMemGroup.Update(dsAlbums.TableMemGroup);
        }
    }
}
