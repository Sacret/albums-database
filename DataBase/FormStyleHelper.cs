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
    public partial class FormStyleHelper : Form
    {
        public FormStyleHelper()
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
        DataSetAlbumsTableAdapters.TableStyleTableAdapter daStyle =
           new DataBase.DataSetAlbumsTableAdapters.
           TableStyleTableAdapter();
        //
        //
        private void StyleFill()
        {
            daStyle.Fill(dsAlbums.TableStyle);
            StripQStyles.Text = "Количество стилей: " + daStyle.ScalarQuery();
        }
        // ЗАГРУЗКА ДАННЫХ ПРИ ЗАГРУЗКЕ ПРИЛОЖЕНИЯ
        private void FormStyleHelper_Load(object sender, EventArgs e)
        {
            List3.Focus();
            Style.ReadOnly = true;
            StyleFill();
            //
            List3.DataSource = dsAlbums;
            List3.DisplayMember = "TableStyle.StyleName";
            List3.ValueMember = "TableStyle.StyleID"; 
            //
            Style.DataBindings.Add("Text", dsAlbums,
           "TableStyle.StyleName");
            Style.ReadOnly = true;
            Hide2.TextBox.DataBindings.Add("Text", dsAlbums,
           "TableStyle.StyleID");
        }
        //____________________________________________________________________________________
        //
        // СТРОКИ СОСТОЯНИЯ:
        //____________________________________________________________________________________
        private void List3_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Список стилей";
        }
        //
        private void List3_MouseLeave(object sender, EventArgs e)
        {
            SBString.Text = "Строка состояния: ";
        }
        //
        private void AddStyle_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Добавить стиль";
        }
        //
        private void EditStyle_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Редактировать стиль";
        }
        //
        private void SaveStyle_MouseEnterr(object sender, EventArgs e)
        {
            SBString.Text += "Сохранить стиль";
        }
        // ДОБАВИТЬ СТИЛЬ
        private void AddStyle_Click(object sender, EventArgs e)
        {
            Style.ReadOnly = false;
            List3.Enabled = false;
            Style.Text="";            
            Style.Focus();
            K = 1;
        }
        // ИЗМЕНИТЬ СТИЛЬ
        private void EditStyle_Click(object sender, EventArgs e)
        {
            Style.ReadOnly = false;
            List3.Enabled = false;
            Style.Focus();
            K = 2;
        }
        // СОХРАНИТЬ ИЗМЕНЕНИЯ
        private void SaveStyle_Click(object sender, EventArgs e)
        {
            int l = 0;
            if (K == 1)
            {
                if (Style.Text == ""||Style.TextLength>20)
                {
                    MessageBox.Show("Неверно введено название стиля!");
                }
                else
                {
                    daStyle.InsertQuery(Style.Text.ToUpper(), (short)(daStyle.ScalarQuery() + 1));
                    l = 1;
                }
            }
            //
            if (K == 2)
            {
                if (Style.Text == "" || Style.TextLength > 20)
                {
                    MessageBox.Show("Неверно введено название стиля!");
                }
                else
                {
                    daStyle.UpdateQuery(Style.Text.ToUpper(), short.Parse(Hide2.Text));
                    l = 1;
                }
            }
            //
            Style.ReadOnly=true;
            List3.Enabled = true;           
            if (l == 1)
            { 
                daStyle.Update(dsAlbums.TableStyle);  
                StyleFill();               
            }           
        }
       
    }
}
