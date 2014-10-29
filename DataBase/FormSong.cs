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
    public partial class FormSong : Form
    {
        public FormSong()
        {
            InitializeComponent(); 
        }
        //
        int K = 0;
        short m;
        //   
        //____________________________________________________________________________________
        //
        // ОПРЕДЕЛЕНИЕ ДАННЫХ ИЗ БД
        //____________________________________________________________________________________
        // СОЗДАНИЕ ДАТАСЕТ И АДАПТЕРОВ   
        DataSetAlbums dsAlbums = new DataSetAlbums();
        // 
        DataSetAlbumsTableAdapters.TableSongTableAdapter daSong =
           new DataBase.DataSetAlbumsTableAdapters.
           TableSongTableAdapter();
        //
        //
        private void SongFill(short m)
        {            
            daSong.FillBy(dsAlbums.TableSong, m);
            StripQSongs.Text = "Количество песен: " + daSong.ScalarQuery(m);
        }
        // ЗАГРУЗКА ДАННЫХ ПРИ ЗАГРУЗКЕ ПРИЛОЖЕНИЯ
        private void FormSong_Load(object sender, EventArgs e)
        {
            List3.Focus();
            m = short.Parse((Owner as Form1).Hide3.TextBox.Text);
            Song.ReadOnly = true;
            SongTime.ReadOnly = true;
            SongFill(m);           
            //
            List3.DataSource = dsAlbums;
            List3.DisplayMember = "TableSong.SongName";            
            //
            Song.DataBindings.Add("Text", dsAlbums,
           "TableSong.SongName");
            SongTime.DataBindings.Add("Text", dsAlbums,
           "TableSong.SongTime");
            //
            Hide2.TextBox.DataBindings.Add("Text", dsAlbums,
           "TableSong.SongID");
        }
        //____________________________________________________________________________________
        //
        // СТРОКИ СОСТОЯНИЯ:
        //____________________________________________________________________________________
        private void List3_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Список песен";
        }
        //
        private void List3_MouseLeave(object sender, EventArgs e)
        {
            SBString.Text = "Строка состояния: ";
        }
        //
        private void AddSong_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Добавить песню";
        }
        //
        private void EditSong_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Редактировать песню";
        }
        //
        private void SaveSong_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Сохранить песню";
        }
        //
        private void RemoveSong_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Удалить песню";
        }
        //
        private void RemoveAllSong_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Удалить все песни";
        }
        // ДОБАВИТЬ ПЕСНЮ
        private void AddSong_Click(object sender, EventArgs e)
        {
            Song.ReadOnly = false;
            SongTime.ReadOnly = false;
            List3.Enabled = false;
            Song.Text = "";
            SongTime.Text = "";
            Song.Focus();
            K = 1;
        }
        // ИЗМЕНИТЬ ПЕСНЮ
        private void EditSong_Click(object sender, EventArgs e)
        {
            Song.ReadOnly = false;
            SongTime.ReadOnly = false;
            List3.Enabled = false;
            Song.Focus();
            K = 2;
        }
        // СОХРАНИТЬ ИЗМЕНЕНИЯ
        private void SaveSong_Click(object sender, EventArgs e)
        {
            int l = 0;
            if (K == 1)
            {
                if (Song.Text == ""||Song.TextLength>40)
                {
                    MessageBox.Show("Неверно введено название песни!");
                }
                else
                {
                    daSong.InsertQuery(Song.Text.ToUpper(), SongTime.Text, m, (short)(daSong.ScalarQuery1() + 1));
                    l = 1;
                }
            }
            //
            if (K == 2)
            {
                if (Song.Text == "" || Song.TextLength > 40)
                {
                    MessageBox.Show("Неверно введено название песни!");
                }
                else
                {
                    daSong.UpdateQuery(Song.Text.ToUpper(), SongTime.Text, short.Parse(Hide2.Text));
                    l = 1;
                }
            }
            //
            Song.ReadOnly = true;
            SongTime.ReadOnly = true;
            List3.Enabled = true;
            if (l == 1)
            {
                daSong.Update(dsAlbums.TableSong);
                SongFill(m);
            }
        }
        // УДАЛЕНИЕ ПЕСНИ
        private void RemoveSong_Click(object sender, EventArgs e)
        {
            int pos = -1;
            pos = this.BindingContext[dsAlbums, "TableSong"].Position;
            //
            string mes = Song.Text.ToString().Trim();
            //
            DialogResult result = MessageBox.Show("Удалить данные о песне " + mes + "?",
             "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
             MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        //выполнить действия по удалению данных об исполнителе
                        //
                        daSong.DeleteQuery(short.Parse(Hide2.Text));
                        //
                        MessageBox.Show("Удаление данных");
                        break;
                    }
                case DialogResult.No:
                    {
                        //отмена удаления данных 
                        this.dsAlbums.TableSong.RejectChanges();
                        MessageBox.Show("Отмена удаления данных");
                        break;
                    }
            }
            SongFill(m);
            daSong.Update(dsAlbums.TableSong);
        }
        
        
    }
}
