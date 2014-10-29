using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace DataBase
{
    public partial class Form1 : Form
    {            
        public Form1()
        {
            InitializeComponent();                      
          //  Hide.TextBox.Parent = this;
        }
        //____________________________________________________________________________________
        //
        // ПЕРЕМЕННЫЕ:
        //____________________________________________________________________________________
        int K = 0;   // для определения действия: добавить/редактировать/удалить/сохранить        
        //____________________________________________________________________________________
        //
        // ОСНОВНОЕ МЕНЮ:
        //____________________________________________________________________________________
        // ФАЙЛ -> ВЫХОД
        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }   
        //____________________________________________________________________________________
        //
        // СТРОКИ СОСТОЯНИЯ:
        //____________________________________________________________________________________
        // ДОБАВИТЬ
        private void MenuAddNote_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы добавить нового исполнителя";
        }
        // ОТВЕДЁННЫЙ КУРСОР
        private void MenuAddNote_MouseLeave(object sender, EventArgs e)
        {
            SBString.Text = "Строка состояния: ";
        }
        // ОТМЕНА
        private void MenuUndo_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Отменить предыдущее действие";
        }
        // РЕДАКТИРОВАТЬ
        private void MenuEditNote_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы редактировать запись";
        }
        // ОБНОВЛЕНИЕ
        private void ButtonRefresh_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы обновить данные базы данных";
        }
        // СОХРАНИТЬ
        private void MenuSave_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы сохранить введённую запись";
        }
        // ПОИСК
        private void MenuSearchNote_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы найти определённую запись";
        }
        // УДАЛИТЬ
        private void MenuRemoveNote_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы удалить определённого исполнителя";
        }
        // ДОБАВИТЬ АЛЬБОМ
        private void ButtonAddAlbum_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы добавить новый альбом";
        }
        // УДАЛИТЬ АЛЬБОМ
        private void ButtonDelAlbum_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы удалить определённый альбом";
        }
        // ВЫХОД    
        private void MenuExit_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы выйти из программы";
        }
        // СПРАВОЧНИК СТИЛЕЙ
        private void MenuStyleHelper_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы просмотреть справочник стилей";
        }
        // СПРАВОЧНИК СТРАН
        private void MenuCountryHelper_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы просмотреть справочник стран";
        }
        // СПРАВОЧНИК ФИРМ
        private void MenuCompanyHelper_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы просмотреть справочник фирм";
        }
        // СПРАВКА О ПРОГРАММЕ
        private void MenuAbout_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы узнать о программе";
        }
        // ВЫЗОВ СПРАВКИ
        private void MenuHelpDB_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы вызвать справку";
        } 
        // СПИСОК ИСПОЛНИТЕЛЕЙ
        private void List1_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Список исполнителей в базе данных";
        }
        // СПИСОК АЛЬБОМОВ
        private void List2_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Список альбомов в базе данных";
        } 
        // ПРОСМОТР
        private void ButtonEditAlbum_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Нажмите, чтобы редактировать информацию об альбоме";
        }
        // ПОДРОБНОСТИ О ПЕСНЯХ
        private void ButtonSongs_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Просмотр подробностей о песнях";
        }
        // ПОДРОБНОСТИ ОБ УЧАСТНИКАХ ГРУППЫ
        private void ButtonGroup_MouseEnter(object sender, EventArgs e)
        {
            SBString.Text += "Просмотр подробностей об участниках";
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
        DataSetAlbumsTableAdapters.TableSongTableAdapter daSong =
            new DataBase.DataSetAlbumsTableAdapters.
            TableSongTableAdapter();
        DataSetAlbumsTableAdapters.TableStatusTableAdapter daStatus =
            new DataBase.DataSetAlbumsTableAdapters.
            TableStatusTableAdapter();
        DataSetAlbumsTableAdapters.TableStyleTableAdapter daStyle =
            new DataBase.DataSetAlbumsTableAdapters.
            TableStyleTableAdapter();
        //____________________________________________________________________________________
        //
        // ТОЛЬКО ЧТЕНИЕ ЗАПИСЕЙ И РЕЖИМ РЕДАКТИРОВАНИЯ
        //____________________________________________________________________________________
        // ТОЛЬКО ЧТЕНИЕ
        public void DisplayReadOnly()
        {
            GroupName.ReadOnly = true;
            WebSite.ReadOnly = true;
            AlbumTitle.ReadOnly = true;
            Year.ReadOnly = true;
            TBCountry.Visible = true;
            TBCountry.ReadOnly = true;
            TBStyle.Visible = true;
            TBStyle.ReadOnly = true;
            TBCompany.Visible = true;
            TBCompany.ReadOnly = true;
            QSongs.ReadOnly = true;
            Country.Visible = false;
            Style.Visible = false;
            Company.Visible = false;
            SongTitles.Enabled = true;
            Group.Enabled = true;
            SongTitles.DropDownStyle = ComboBoxStyle.DropDownList;
            Group.DropDownStyle = ComboBoxStyle.DropDownList;            
        }  
        // РЕДАКТИРОВАНИЕ - ИСПОЛНИТЕЛЬ
        public void DisplayEditNote()
        {
            GroupName.ReadOnly = false;
            WebSite.ReadOnly = false;        
            TBCountry.Visible = false;           
            Country.Visible = true;                
        }   
        // РЕДАКТИРОВАНИЕ - АЛЬБОМ
        public void DisplayEditNoteAlbum()
        {           
            AlbumTitle.ReadOnly = false;
            Year.ReadOnly = false;
            QSongs.ReadOnly = false;           
            TBStyle.Visible = false;
            TBCompany.Visible = false;           
            Style.Visible = true;
            Company.Visible = true;            
        }   
        // ЗАМЕНА КОМБО НА ТЕКСТ
        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBCountry.Text = Country.Text;          
        }
        //
        private void Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBCompany.Text = Company.Text;
        }
        //
        private void Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBStyle.Text = Style.Text;
        }  
        // ОЧИСТИТЬ (ПРИ ДОБАВЛЕНИИ НОВОГО)
        private void ClearGroup()
        {
            GroupName.Text = "";
            WebSite.Text = "";
            Country.SelectedIndex = -1;
            Group.SelectedIndex = -1;
        }
        //
        private void ClearAlbum()
        {
            AlbumTitle.Text = "";
            QSongs.Text = "";
            Year.Text = "";
            Style.SelectedIndex = -1;
            Company.SelectedIndex = -1;
            SongTitles.SelectedIndex = -1;
        }
        //
        private void Clear()
        {
            ClearAlbum();
            ClearGroup();            
        }
        //
        private void OnlySave()
        {
            ButtonNew.Enabled = false;
            ButtonAddAlbum.Enabled = false;
            ButtonEdit.Enabled = false;
            ButtonEditAlbum.Enabled = false;
            ButtonRemove.Enabled = false;
            ButtonDelAlbum.Enabled = false;
            ButtonRefresh.Enabled = false;
            MenuAddNote.Enabled = false;
            MenuAddAlbum.Enabled = false;
            MenuEditNote.Enabled = false;
            MenuEditAlbum.Enabled = false;
            MenuRemoveNote.Enabled = false;
            MenuRemoveAlbum.Enabled = false;
            MenuRefresh.Enabled = false;
            NewtoolStrip.Enabled = false;
            NewAlbumtoolStrip.Enabled = false;
            EdittoolStrip.Enabled = false;
            EditAlbumtoolStrip.Enabled = false;
            RemovetoolStrip.Enabled = false;
            RemoveAlbumtoolStrip.Enabled = false;
            RefreshtoolStrip.Enabled = false;
            ButtonSave.Enabled = true;          
            MenuSave.Enabled = true;
            SavetoolStrip.Enabled = true;  
            ButtonUndo.Enabled = true;
            UndotoolStrip.Enabled = true;
            MenuUndo.Enabled = true;
        }
        //
        private void NotSave()
        {
            ButtonNew.Enabled = true;
            ButtonAddAlbum.Enabled = true;
            ButtonEdit.Enabled = true;
            ButtonEditAlbum.Enabled = true;
            ButtonRemove.Enabled = true;
            ButtonDelAlbum.Enabled = true;
            ButtonRefresh.Enabled = true;
            MenuAddNote.Enabled = true;
            MenuAddAlbum.Enabled = true;
            MenuEditNote.Enabled = true;
            MenuEditAlbum.Enabled = true;
            MenuRemoveNote.Enabled = true;
            MenuRemoveAlbum.Enabled = true;
            MenuRefresh.Enabled = true;
            NewtoolStrip.Enabled = true;
            NewAlbumtoolStrip.Enabled = true;
            EdittoolStrip.Enabled = true;
            EditAlbumtoolStrip.Enabled = true;
            RemovetoolStrip.Enabled = true;
            RemoveAlbumtoolStrip.Enabled = true;
            RefreshtoolStrip.Enabled = true;
            ButtonSave.Enabled = false;            
            MenuSave.Enabled = false;
            SavetoolStrip.Enabled = false;
            ButtonUndo.Enabled = false;
            UndotoolStrip.Enabled = false;
            MenuUndo.Enabled = false;
        }
        //____________________________________________________________________________________
        //
        // ЗАПОЛНЕНИЕ ТАБЛИЦ ДАННЫМИ ИЗ БД
        //____________________________________________________________________________________
        public void AlbumsFill()
        {
              Hide1.Visible = true;
            daGroup.Fill(dsAlbums.TableGroup);           
            daAlbum.Fill(dsAlbums.TableAlbum);
            daCompany.Fill(dsAlbums.TableCompany);
            daCountry.Fill(dsAlbums.TableCountry);
            daMemGroup.Fill(dsAlbums.TableMemGroup);
            daSong.Fill(dsAlbums.TableSong);
            daStatus.Fill(dsAlbums.TableStatus);
            daStyle.Fill(dsAlbums.TableStyle);
            QAlbumsString.Text = "Количество альбомов: " + daAlbum.ScalarQuery();
            QGroupsString.Text = "Количество исполнителей: " + daGroup.ScalarQuery();           
        }
        // ОБНОВЛЕНИЕ ДАННЫХ
        public void AlbumsUpdate()
        {
            daGroup.Update(dsAlbums.TableGroup);
            daAlbum.Update(dsAlbums.TableAlbum);
            daCompany.Update(dsAlbums.TableCompany);
            daCountry.Update(dsAlbums.TableCountry);
            daMemGroup.Update(dsAlbums.TableMemGroup);
            daSong.Update(dsAlbums.TableSong);
            daStatus.Update(dsAlbums.TableStatus);
            daStyle.Update(dsAlbums.TableStyle);           
        }
        // ЗАГРУЗКА ДАННЫХ ПРИ ЗАГРУЗКЕ ПРИЛОЖЕНИЯ
        private void Form1_Load(object sender, EventArgs e)
        {           
            List1.Focus();
            DisplayReadOnly();                       
            AlbumsFill();  
            //
            List1.DataSource = dsAlbums;
            List1.DisplayMember = "TableGroup.GroupName";
            List1.ValueMember = "TableGroup.GroupID";
            //
            List2.DataSource = dsAlbums.TableAlbum.DefaultView;
            List2.DisplayMember = "AlbumName";
            List2.ValueMember = "AlbumID";
            //
            List1.SelectedIndexChanged += new EventHandler(List1_SelectedIndexChanged);
            /* */
            ReFreshGroup();
            //
            // Относятся к группе:
            GroupName.DataBindings.Add("Text", dsAlbums,
            "TableGroup.GroupName");  
            //
            WebSite.DataBindings.Add("Text", dsAlbums,
            "TableGroup.GroupSite");
            //
            Country.DataSource = this.dsAlbums.TableCountry;
            Country.DisplayMember = "CountryName";
            Country.ValueMember = "CountryID";
            Country.DataBindings.Add("SelectedValue", dsAlbums, "TableGroup.CountryID");            
            //
            Group.DataSource = this.dsAlbums.TableMemGroup.DefaultView;
            Group.DisplayMember = "MemName";
            Group.ValueMember = "StatusID";
            //
            // Относятся к альбому:
            AlbumTitle.DataBindings.Add("Text", dsAlbums.TableAlbum.DefaultView,
            "AlbumName");
            // 
            Year.DataBindings.Add("Text", dsAlbums.TableAlbum.DefaultView,
            "AlbumYear");
            QSongs.DataBindings.Add("Text", dsAlbums.TableAlbum.DefaultView,
            "AlbumQSongs");
            //
            Style.DataSource = this.dsAlbums.TableStyle;
            Style.DisplayMember = "StyleName";
            Style.ValueMember = "StyleID";
            Style.DataBindings.Add("SelectedValue", dsAlbums.TableAlbum.DefaultView, "StyleID");
            //
            Company.DataSource = this.dsAlbums.TableCompany;
            Company.DisplayMember = "CompanyName";
            Company.ValueMember = "CompanyID";
            Company.DataBindings.Add("SelectedValue", dsAlbums.TableAlbum.DefaultView, "CompanyID");
            //
            SongTitles.DataSource = this.dsAlbums.TableSong.DefaultView;
            SongTitles.DisplayMember = "SongName";
            SongTitles.ValueMember = "SongName";
            //
           /* Hide1.DataBindings.Add("Text", dsAlbums,
           "TableGroup.GroupID");  */
            Hide1.TextBox.DataBindings.Add("Text", dsAlbums,
           "TableGroup.GroupID");
            //
            if (daAlbum.ScalarQuery2(int.Parse(Hide1.Text))>0)
            {
                List2.SelectedIndexChanged += new EventHandler(List2_SelectedIndexChanged);                
                ReFreshAlbum();    
                //                           
                //Hide3.DataBindings.Add("Text", dsAlbums.TableAlbum.DefaultView, "AlbumID");
                Hide3.TextBox.DataBindings.Add("Text", dsAlbums.TableAlbum.DefaultView, "AlbumID"); 
            }
        }       
        //____________________________________________________________________________________
        //
        //   ПЕРЕМЕЩЕНИЕ ПО СПИСКУ ГРУПП И СПИСКУ АЛЬБОМОВ
        //____________________________________________________________________________________        
        void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReFreshGroup();
            ReFreshAlbum();
        }      
        //
        void List2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReFreshAlbum();
        }
        //
        // Обновить инфу, связанную с группой
        void ReFreshGroup()
        {
            try
            {
                string List1GroupID = List1.SelectedValue.ToString();
                string filterString = "GroupID=" + List1GroupID;
                dsAlbums.TableAlbum.DefaultView.RowFilter = filterString;
                dsAlbums.TableMemGroup.DefaultView.RowFilter = filterString;
            }
            catch { }
        }
        //
        // Обновить инфу, связанную с альбомом
        void ReFreshAlbum()
        {
            try
            {
                string List2AlbumID = List2.SelectedValue.ToString();
                string filterString2 = "AlbumID=" + List2AlbumID;
                dsAlbums.TableSong.DefaultView.RowFilter = filterString2;
            }
            catch { }
        }
        //____________________________________________________________________________________
        //
        //   ОБРАБОТКА ПУНКТОВ МЕНЮ
        //____________________________________________________________________________________      
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            NewGroup();
            OnlySave();
        }
        //
        private void MenuAddAlbum_Click(object sender, EventArgs e)
        {
            NewAlbum();
            OnlySave();
        }        
        //
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditGroup();
            OnlySave();
        }
        //
        private void ButtonEditAlbum_Click(object sender, EventArgs e)
        {
            EditAlbum();
            OnlySave();
        }
        //
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить данные о группе?",
            "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        MessageBox.Show("Начало удаления данных");
                        Remove();                        
                        break;
                    }
                case DialogResult.No:
                    {
                        //отмена удаления данных                         
                        MessageBox.Show("Отмена удаления данных");
                        break;
                    }
            } 
           
        }
        //       
        private void MenuRemoveAlbum_Click(object sender, EventArgs e)
        {
            if (daAlbum.ScalarQuery2(int.Parse(Hide1.Text)) > 0)
            {
                RemoveAlbum();
            }
        }
        //
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Save();
            NotSave();
        }
        //
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        
        //____________________________________________________________________________________
        //
        //   МОДИФИКАЦИЯ/СОЗДАНИЕ/СОХРАНИНИЕ/УДАЛЕНИЕ ДАННЫХ
        //____________________________________________________________________________________  
        // РЕДАКТИРОВАНИЕ
        private void EditGroup()
        {
            DisplayEditNote();            
            List1.Enabled = List2.Enabled = false;            
            GroupName.Focus();
            K = 3;
        }   
        //
        private void EditAlbum()
        {
            DisplayEditNoteAlbum();
            List1.Enabled = List2.Enabled = false;            
            AlbumTitle.Focus();
            K = 4;
        }
        // НОВАЯ ГРУППА
        public void NewGroup()
        {
            DisplayEditNote();           
            List1.Enabled = List2.Enabled = false;
            Clear();            
            GroupName.Focus();
            K = 1;
            //daGroup.InsertQuery(dsAlbums.TableGroup.Rows.Count + 1, "oompn", "www", 23);         
        }
        // НОВЫЙ АЛЬБОМ
        public void NewAlbum()
        {
            DisplayEditNoteAlbum();
            List1.Enabled = List2.Enabled = false;
            ClearAlbum();           
            AlbumTitle.Focus();
            K = 2;
        }
        // УДАЛЕНИЕ ДАННЫХ О ГРУППЕ
        public void Remove()
        {
            int pos = -1;
            pos = this.BindingContext[dsAlbums, "TableGroup"].Position;
            //
            string mes = GroupName.Text.ToString().Trim();
            //
            DialogResult result = MessageBox.Show(" Удалить данные об исполнителе " + mes + "?", 
             "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
             MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        //выполнить действия по удалению данных об исполнителе
                        // 
                        daGroup.DeleteQuery(int.Parse(Hide1.Text));                       
                        //
                        MessageBox.Show("Удаление данных");
                        break;
                    }
                case DialogResult.No:
                    {
                        //отмена удаления данных 
                        this.dsAlbums.TableGroup.RejectChanges();
                        MessageBox.Show("Отмена удаления данных");
                        break;
                    }
            }           
            AlbumsFill();
            AlbumsUpdate();
        }
        //
        // УДАЛЕНИЕ ДАННЫХ ОБ АЛЬБОМЕ
        public void RemoveAlbum()
        {
            int pos = -1;
            pos = this.BindingContext[dsAlbums, "TableAlbum"].Position;
            //
            string mes = AlbumTitle.Text.ToString().Trim();
            //
            DialogResult result = MessageBox.Show("Удалить данные об альбоме " + mes + "?",
             "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
             MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        //выполнить действия по удалению данных об исполнителе
                        //                        
                        daAlbum.DeleteQuery(short.Parse(Hide3.Text));
                        //
                        MessageBox.Show("Удаление данных");
                        break;
                    }
                case DialogResult.No:
                    {
                        //отмена удаления данных 
                        this.dsAlbums.TableAlbum.RejectChanges();
                        MessageBox.Show("Отмена удаления данных");
                        break;
                    }
            }
            AlbumsFill();
            AlbumsUpdate();
        }
        // СОХРАНЕНИЕ ИЗМЕНЕНИЙ
        private void Save()
        {
            short m = 0, n = 0, o = 0, p = 0;
            if (K == 1) // ДОБАВИЛИ ГРУППУ
            {
                if (GroupName.Text == "")
                {
                    MessageBox.Show("Неверно введено название группы!");
                }
                else
                {                  
                    if (Country.SelectedIndex == -1) m = 29;
                    else m = (short)((DataRowView)Country.Items[Country.SelectedIndex])["CountryID"];
                       daGroup.InsertQuery((int)(daGroup.ScalarQuery1() + 1), GroupName.Text.ToUpper(), WebSite.Text.ToLower(), m);                      
                }
            }
            if (K == 2) // ДОБАВИЛИ АЛЬБОМ
            {
                if (AlbumTitle.Text == "")
                {
                    MessageBox.Show("Неверно введена информация об альбоме!");
                }
                else
                {
                    if (Style.SelectedIndex == -1) m = 92;
                    else m = (short)((DataRowView)Style.Items[Style.SelectedIndex])["StyleID"];
                    if (Company.SelectedIndex == -1) n = 57;
                    else n = (short)((DataRowView)Company.Items[Company.SelectedIndex])["CompanyID"];
                    if (QSongs.Text == "") o = 0;
                    else o = short.Parse(QSongs.Text);
                    if (Year.Text == "") p = 2000;
                    else p = short.Parse(Year.Text);
                       daAlbum.InsertQuery(AlbumTitle.Text.ToUpper(), p, o, int.Parse(Hide1.Text), (short)(daAlbum.ScalarQuery1()+1),
                       n, m);
                }
            }
            if (K == 3) // РЕДАКТИРОВАЛИ ГРУППУ
            {
                if (GroupName.Text == "")
                {
                    MessageBox.Show("Неверно отредактирована информация!");
                }
                else
                {
                    if (Country.SelectedIndex == -1) m = 29;
                    else m = (short)((DataRowView)Country.Items[Country.SelectedIndex])["CountryID"];
                       daGroup.UpdateQuery(GroupName.Text.ToUpper(), WebSite.Text.ToLower(), m, int.Parse(Hide1.Text));             
                }                
            }
            if (K == 4) // РЕДАКТИРОВАЛИ АЛЬБОМ
            {
                if (AlbumTitle.Text == "")
                {
                    MessageBox.Show("Неверно отредактирована информация!");
                }
                else
                {
                    if (Style.SelectedIndex == -1) m = 92;
                    else m = (short)((DataRowView)Style.Items[Style.SelectedIndex])["StyleID"];
                    if (Company.SelectedIndex == -1) n = 57;
                    else n = (short)((DataRowView)Company.Items[Company.SelectedIndex])["CompanyID"];
                    if (QSongs.Text == "") o = 0;
                    else o = short.Parse(QSongs.Text);
                    if (Year.Text == "") p = 2000;
                    else p = short.Parse(Year.Text);
                       daAlbum.UpdateQuery(AlbumTitle.Text.ToUpper(), p, o, n, m, short.Parse(Hide3.Text));   
                }
            }
            DisplayReadOnly();
            List1.Enabled = true;
            List2.Enabled = true;   
            AlbumsUpdate();
            AlbumsFill();         
        }
        //
        // ОТМЕНА
        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            NotSave();
            DisplayReadOnly();
            List1.Enabled = true;
            List2.Enabled = true;            
            AlbumsUpdate();
            AlbumsFill();
        }
        // ОБНОВЛЕНИЕ
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            AlbumsUpdate();
            AlbumsFill();           
        }
        //____________________________________________________________________________________
        //
        // СПРАВОЧНИКИ:
        //____________________________________________________________________________________
        // СТИЛИ
        private void MenuStyleHelper_Click(object sender, EventArgs e)
        {
            // Создать объект класса FormStyleHelper
            FormStyleHelper FormStyleHelper = new FormStyleHelper();
            // Вывести на экран дочерее окно
            //FormStyleHelper.Show();
            FormStyleHelper.ShowDialog(this);
            AlbumsUpdate();
            AlbumsFill();
        }
        // КОМПАНИИ
        private void MenuCompanyHelper_Click(object sender, EventArgs e)
        {
            // Создать объект класса FormCompanyHelper
            FormCompanyHelper FormCompanyHelper = new FormCompanyHelper();
            // Вывести на экран дочерее окно
            //FormCompanyHelper.Show();
            FormCompanyHelper.ShowDialog(this);
            AlbumsUpdate();
            AlbumsFill();
        }
        // СТРАНЫ
        private void MenuCountryHelper_Click(object sender, EventArgs e)
        {
            // Создать объект класса FormCountryHelper
            FormCountryHelper FormCountryHelper = new FormCountryHelper();
            // Вывести на экран дочерее окно
            //FormCountryHelper.Show();
            FormCountryHelper.ShowDialog(this);
            AlbumsUpdate();
            AlbumsFill();
        }
        // СТАТУСЫ
        private void MenuStatusHelper_Click(object sender, EventArgs e)
        {
            // Создать объект класса FormStatusHelper
            FormStatusHelper FormStatusHelper = new FormStatusHelper();
            // Вывести на экран дочерее окно
            //FormStatusHelper.Show();
            FormStatusHelper.ShowDialog(this);
            AlbumsUpdate();
            AlbumsFill();
        }
        // ПОДРОБНОСТИ О ПЕСНЯХ
        private void ButtonSongs_Click(object sender, EventArgs e)
        {
            if (Hide3.Text != "")
            {
                // Создать объект класса FormSong
                FormSong FormSong = new FormSong();
                // Вывести на экран дочерее окно           
                FormSong.ShowDialog(this);
            }
            AlbumsUpdate();
            AlbumsFill();
        }
        // ПОДРОБНОСТИ ОБ УЧАСТНИКАХ
        private void ButtonGroup_Click(object sender, EventArgs e)
        {
            // Создать объект класса FormMemGroup
            FormMemGroup FormMemGroup = new FormMemGroup();
            // Вывести на экран дочерее окно           
            FormMemGroup.ShowDialog(this);
            AlbumsUpdate();
            AlbumsFill();
        }
        // ПОИСК
        private void Search()
        {
            FormSearch FormSearch = new FormSearch();
            FormSearch.ShowDialog(this); 
        }
        // ОТЧЁТ ПО ВСЕМ ГРУППАМ
        private void MenuReportGroups_Click(object sender, EventArgs e)
        {
            FormReport FormReport = new FormReport();
            FormReport.ShowDialog(this);
        }
        // СПРАВКА ПО РАБОТЕ БД
        private void MenuHelpDB_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "help.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // СПРАВКА -> О ПРОГРАММЕ
        private void MenuAbout_Click(object sender, EventArgs e)
        {
            // Создать объект класса FormAbout
            FormAbout FormAbout = new FormAbout();
            // Вывести на экран дочерее окно
            //FormAbout.Show();
            FormAbout.ShowDialog(this);
        }
        //____________________________________________________________________________________
        //
        // ПРОВЕРКА ВВОДА:
        //____________________________________________________________________________________
        // ВВОД НЕ ЦИФРЫ В ПОЛЕ "ГОД"
        private void Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(Year, "Must be number");
                MessageBox.Show("В этом поле можно вводить только цифры!");                
            }
        }
        // ВВОД НЕ ЦИФРЫ В ПОЛЕ "КОЛИЧЕСТВО"
        private void QSongs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(QSongs, "Must be number");
                MessageBox.Show("В этом поле можно вводить только цифры!");               
            }
        }

        private void MnuShow_Click(object sender, EventArgs e)
        {
            //Включаем отображения приложения на панели задач при запуске
            this.ShowInTaskbar = true;
            //Показываем форму
            this.Show();
            //Отключаем доступность пункта меню mnuShow
            MnuShow.Enabled = false;
            //Включаем доступность пункта меню mnuHide
            MnuHide.Enabled = true;
            //Переменной Hidden устанавливаем значение false
        }

        private void MnuHide_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
            MnuShow.Enabled = true;
            MnuHide.Enabled = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            MnuShow_Click(this, new EventArgs());
        }
      
    }
}
