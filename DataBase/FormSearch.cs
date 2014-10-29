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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }  
        //____________________________________________________________________________________
        //
        // ОПРЕДЕЛЕНИЕ ДАННЫХ ИЗ БД
        //____________________________________________________________________________________
        // СОЗДАНИЕ ДАТАСЕТ И АДАПТЕРОВ       
        DataSetAlbums dsAlbums = new DataSetAlbums();
        //
        DataSetAlbumsTableAdapters.TableGroupTableAdapter daGroup =
            new DataBase.DataSetAlbumsTableAdapters.
            TableGroupTableAdapter();
        DataSetAlbumsTableAdapters.TableAlbumTableAdapter daAlbum =
            new DataBase.DataSetAlbumsTableAdapters.
            TableAlbumTableAdapter();
        DataSetAlbumsTableAdapters.TableCompanyTableAdapter daCompany =
            new DataBase.DataSetAlbumsTableAdapters.
            TableCompanyTableAdapter();
        DataSetAlbumsTableAdapters.TableCountryTableAdapter daCountry =
            new DataBase.DataSetAlbumsTableAdapters.
            TableCountryTableAdapter();
        DataSetAlbumsTableAdapters.TableMemGroupTableAdapter daMemGroup =
            new DataBase.DataSetAlbumsTableAdapters.
            TableMemGroupTableAdapter();      
        DataSetAlbumsTableAdapters.TableStatusTableAdapter daStatus =
            new DataBase.DataSetAlbumsTableAdapters.
            TableStatusTableAdapter();
        DataSetAlbumsTableAdapters.TableStyleTableAdapter daStyle =
            new DataBase.DataSetAlbumsTableAdapters.
            TableStyleTableAdapter();        
        //____________________________________________________________________________________
        //
        // ЗАПОЛНЕНИЕ ТАБЛИЦ ДАННЫМИ ИЗ БД
        //____________________________________________________________________________________
        public void AlbumsFill()
        {           
            daCompany.Fill(dsAlbums.TableCompany);            
            daCountry.Fill(dsAlbums.TableCountry);           
            daStatus.Fill(dsAlbums.TableStatus);
            daStyle.Fill(dsAlbums.TableStyle);          
        }
        //
        private void InfoLoad()
        {
            if (RBComp.Checked)
            {
                CBSearch.DataSource = dsAlbums.TableCompany;
                CBSearch.DisplayMember = "CompanyName";
                CBSearch.ValueMember = "CompanyID";                
            }
            //
            if (RBCountry.Checked)
            {
                CBSearch.DataSource = dsAlbums.TableCountry;
                CBSearch.DisplayMember = "CountryName";
                CBSearch.ValueMember = "CountryID";              
            }
            //
            if (RBStatus.Checked)
            {
                CBSearch.DataSource = dsAlbums.TableStatus;
                CBSearch.DisplayMember = "StatusName";
                CBSearch.ValueMember = "StatusID";               
            }
            //
            if (RBStyle.Checked)
            {
                CBSearch.DataSource = dsAlbums.TableStyle;
                CBSearch.DisplayMember = "StyleName";
                CBSearch.ValueMember = "StyleID";                
            }
        }
        //
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            AlbumsFill();
            CBSearch.Visible = true;
            InfoLoad();
            ButtonEnter.Visible = false;
            SBString.Text = "Найдено: ";
        }
        //
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            CBSearch.Visible = false;
            ButtonEnter.Visible = true;
            short m = 0;
                    
            if (RBComp.Checked) m = (short)((DataRowView)CBSearch.Items[CBSearch.SelectedIndex])["CompanyID"];
            if (RBCountry.Checked) m = (short)((DataRowView)CBSearch.Items[CBSearch.SelectedIndex])["CountryID"];
            if (RBStatus.Checked) m = (short)((DataRowView)CBSearch.Items[CBSearch.SelectedIndex])["StatusID"]; 
            if (RBStyle.Checked) m = (short)((DataRowView)CBSearch.Items[CBSearch.SelectedIndex])["StyleID"];

            if (RBCountry.Checked)
            {
                daGroup.FillBy(dsAlbums.TableGroup, m);
                List3.DataSource = dsAlbums;
                List3.DisplayMember = "TableGroup.GroupName";
                SBString.Text = "Найдено: " + daGroup.ScalarQuery2(m).ToString() + " групп";
                
            }
            //
            if (RBStatus.Checked)
            {
                daMemGroup.FillBy1(dsAlbums.TableMemGroup, m);
                List3.DataSource = dsAlbums;
                List3.DisplayMember = "TableMemGroup.MemName";
                SBString.Text = "Найдено: " + daMemGroup.ScalarQuery2(m).ToString() + " участников";
            }
            //
            if (RBComp.Checked)
            {
                daAlbum.FillBy(dsAlbums.TableAlbum, m);
                List3.DataSource = dsAlbums;
                List3.DisplayMember = "TableAlbum.AlbumName";
                SBString.Text = "Найдено: " + daAlbum.ScalarQuery3(m).ToString() + " альбомов";
            }
            //
            if (RBStyle.Checked)
            {
                daAlbum.FillBy1(dsAlbums.TableAlbum, m);
                List3.DataSource = dsAlbums;
                List3.DisplayMember = "TableAlbum.AlbumName";
                SBString.Text = "Найдено: " + daAlbum.ScalarQuery4(m).ToString() + " альбомов";
            }
             
        }
        
       
      
    }
}
