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
    public partial class FormCountryHelper : Form
    {
        public FormCountryHelper()
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
        DataSetAlbumsTableAdapters.TableCountryTableAdapter daCountry =
           new DataBase.DataSetAlbumsTableAdapters.
           TableCountryTableAdapter();
        //
        //
        private void CountryFill()
        {
            daCountry.Fill(dsAlbums.TableCountry);
            StripQCountry.Text = "Количество стран: " + daCountry.ScalarQuery();
        }
        // ЗАГРУЗКА ДАННЫХ ПРИ ЗАГРУЗКЕ ПРИЛОЖЕНИЯ
        private void FormCountryHelper_Load(object sender, EventArgs e)
        {
            List3.Focus();
            Country.ReadOnly = true;
            CountryFill();
            //
            List3.DataSource = dsAlbums;
            List3.DisplayMember = "TableCountry.CountryName";
            List3.ValueMember = "TableCountry.CountryID";
            //
            Country.DataBindings.Add("Text", dsAlbums,
           "TableCountry.CountryName");
            Country.ReadOnly = true;           
            Hide2.TextBox.DataBindings.Add("Text", dsAlbums,
           "TableCountry.CountryID");
        }
        //____________________________________________________________________________________
        //
        // СТРОКИ СОСТОЯНИЯ:
        //____________________________________________________________________________________
        private void List3_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Список стран";
        }
        //
        private void List3_MouseLeave(object sender, EventArgs e)
        {
            SBString.Text = "Строка состояния: ";
        }
        //
        private void AddCountry_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Добавить страну";
        }
        //
        private void EditCountry_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Редактировать страну";
        }
        //
        private void SaveCountry_MouseEnterr(object sender, EventArgs e)
        {
            SBString.Text += "Сохранить страну";
        }      
        // ДОБАВИТЬ СТРАНУ
        private void AddCountry_Click(object sender, EventArgs e)
        {
            Country.ReadOnly = false;
            List3.Enabled = false;
            Country.Text = "";
            Country.Focus();
            K = 1;
        }
        // ИЗМЕНИТЬ СТРАНУ
        private void EditCountry_Click(object sender, EventArgs e)
        {
            Country.ReadOnly = false;
            List3.Enabled = false;
            Country.Focus();
            K = 2;
        }
        // СОХРАНИТЬ ИЗМЕНЕНИЯ
        private void SaveCountry_Click(object sender, EventArgs e)
        {
            int l = 0;
            if (K == 1)
            {
                if (Country.Text == ""||Country.TextLength>20)
                {
                    MessageBox.Show("Неверно введено название страны!");
                }
                else
                {
                    daCountry.InsertQuery(Country.Text.ToUpper(), (short)(daCountry.ScalarQuery() + 1));
                    l = 1;
                }
            }
            //
            if (K == 2)
            {
                if (Country.Text == "" || Country.TextLength > 20)
                {
                    MessageBox.Show("Неверно введено название страны!");
                }
                else
                {
                    daCountry.UpdateQuery(Country.Text.ToUpper(), short.Parse(Hide2.Text));
                    l = 1;
                }
            }
            //
            Country.ReadOnly = true;
            List3.Enabled = true;
            if (l == 1)
            {
                daCountry.Update(dsAlbums.TableCountry);
                CountryFill();
            }           
        }
        
    }
}
