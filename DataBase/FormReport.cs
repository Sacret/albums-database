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
    public partial class FormReport : Form
    {
        public FormReport()
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
         //____________________________________________________________________________________
        //
        // ЗАПОЛНЕНИЕ ТАБЛИЦ ДАННЫМИ ИЗ БД
        //____________________________________________________________________________________
        public void AlbumsFill()
        {
            daGroup.Fill(dsAlbums.TableGroup);
            daAlbum.Fill(dsAlbums.TableAlbum);
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            AlbumsFill();
            reportDocument1.SetDataSource(dsAlbums);
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = reportDocument1;
        }

    }
}
