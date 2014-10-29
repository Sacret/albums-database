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
    public partial class FormCompanyHelper : Form
    {
        public FormCompanyHelper()
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
        DataSetAlbumsTableAdapters.TableCompanyTableAdapter daCompany =
           new DataBase.DataSetAlbumsTableAdapters.
           TableCompanyTableAdapter();
        //
        private void CompanyFill()
        { 
            daCompany.Fill(dsAlbums.TableCompany);
            StripQCompany.Text = "Количество компаний: " + daCompany.ScalarQuery();
        }
        // ЗАГРУЗКА ДАННЫХ ПРИ ЗАГРУЗКЕ ПРИЛОЖЕНИЯ
        private void FormCompanyHelper_Load(object sender, EventArgs e)
        {
            List3.Focus();
            CompanyFill();
            //
            List3.DataSource = dsAlbums;
            List3.DisplayMember = "TableCompany.CompanyName";
            List3.ValueMember = "TableCompany.CompanyID";
            //
            Company.DataBindings.Add("Text", dsAlbums,
           "TableCompany.CompanyName");
            Company.ReadOnly = true;
            Hide2.TextBox.DataBindings.Add("Text", dsAlbums,
           "TableCompany.CompanyID");
        }
        //____________________________________________________________________________________
        //
        // СТРОКИ СОСТОЯНИЯ:
        //____________________________________________________________________________________
        private void List3_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Список компаний";
        }
        //
        private void List3_MouseLeave(object sender, EventArgs e)
        {
            SBString.Text = "Строка состояния: ";
        }
        //
        private void AddCompany_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Добавить компанию";
        }
        //
        private void EditCompany_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Редактировать компанию";
        }
        //
        private void SaveCompany_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Сохранить компанию";
        }       
        // ДОБАВИТЬ СТИЛЬ
        private void AddCompany_Click(object sender, EventArgs e)
        {
            Company.ReadOnly = false;
            List3.Enabled = false;
            Company.Text = "";
            Company.Focus();
            K = 1;
        }
        // ИЗМЕНИТЬ СТИЛЬ
        private void EditCompany_Click(object sender, EventArgs e)
        {
            Company.ReadOnly = false;
            List3.Enabled = false;
            Company.Focus();
            K = 2;
        }
        // СОХРАНИТЬ ИЗМЕНЕНИЯ
        private void SaveCompany_Click(object sender, EventArgs e)
        {
            int l = 0;
            if (K == 1)
            {
                if (Company.Text == ""||Company.TextLength>30)
                {
                    MessageBox.Show("Неверно введено название компании!");
                }
                else
                {
                    daCompany.InsertQuery(Company.Text.ToUpper(), (short)(daCompany.ScalarQuery()+1));
                    l = 1;
                }
            }
            //
            if (K == 2)
            {
                if (Company.Text == "" || Company.TextLength > 30)
                {
                    MessageBox.Show("Неверно введено название компании!");
                }
                else
                {
                    daCompany.UpdateQuery(Company.Text.ToUpper(), short.Parse(Hide2.Text));
                    l = 1;
                }
            }
            //
            Company.ReadOnly = true;
            List3.Enabled = true;
            if (l == 1)
            {  
                daCompany.Update(dsAlbums.TableCompany);
                CompanyFill();              
            }           
        }
    
    }
}
