﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using WindowsFormsApp1;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Komandirovki
{
    public partial class KomandirovkaForm : Form
    {
        private Model1 model;
        //Country -> cities
        private Dictionary<String, HashSet<String>> cities;
        //City -> orgs
        private Dictionary<String, HashSet<TRIP_ORG>> organizations;
        private DbSet<TRIP_ORG> allOrgs;

        private UPDTRIP trip = null;

        private readonly DateTime _nullDateTime = new DateTime(2020, 01, 01);

        /*
         * Для добавления командировки
         * **/
        public KomandirovkaForm()
        {
            Donloading waitForm = new Donloading();
            waitForm.Show(this);
            model = new Model1();
            allOrgs = model.TRIP_ORG;
            InitializeComponent();
            UpdatePlaces();
            CounrtyColumn.DataSource = cities.Keys.ToList();
            waitForm.Close();
         }

        /*
         * Для получения инфы по командировке UPDTRIP c перв.ключом == pk_UPDTRIP, её редактирования и удаления
         * **/
        public void SetTrip(decimal pkUpdtrip)
        {
            try
            {
                trip = model.UPDTRIP.Find(pkUpdtrip);
                if (trip == null)
                    throw new Exception("Командировки с таким ключом не найдено!");
            }
            catch (Exception except)
            {
                MyMsgBox.showError("Не удалось найти подробную информацию");
                Console.Error.WriteLine(except.Message);
                return;
            }

            SetWorkers(trip.PERSONCARD_IN_TRIP);
            foreach (TRIP_ORG org in trip.TRIP_ORG)
                AddOrgTrip(org);

            if(trip.PRIKAZ != null)
            {
                NumPrikazTextBox.Text = trip.PRIKAZ.NUMDOC;
                DatePrikaz.Value = trip.PRIKAZ.CREATEDATE ?? DateTime.Now;
                IsProject.Checked = trip.PRIKAZ.ISPROJECT.Equals("1"); 
             
                // По-умолчанию для режима редактирования
                GenNumPrikaz.Checked = false;
                try
                {
                    // Если мы сами генерировали
                    GenNumPrikaz.Checked = Decimal.Parse(trip.PRIKAZ.NUMDOC) == trip.PRIKAZ.PK_PRIKAZ;
                }
                catch (Exception)
                {
                    // Забить
                }
                GenNumPrikaz_CheckedChanged(null, null);
            }

            ReasonTextBox.Text = trip.OSNOVANIE ?? "";

            if(trip.OSNOVANIEDATE != null)
            {
                isDateReasonCheckBox.Checked = true;
                isDateReasonCheckBox_CheckedChanged(null,null);
                DateReason.Value = (DateTime)trip.OSNOVANIEDATE;
            }
            else
            {
                isDateReasonCheckBox.Checked = false;

            }
            NoteTextBox.Text = trip.NOTE ?? "";
        }

        /*
         * Для добавления командировки из личной карточки сотрудника
         * **/
        public void SetOneWorker(decimal pkPerson) {
            // Нужно найти именно текущей моделью
            try
            {
                SetWorkers(new List<PERSONCARD> {model.PERSONCARD.Find(pkPerson)});
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine(exception.Message);
                MyMsgBox.showError("Не удалось открыть форму. Скорее всего, такого работника нет в базе");
            }
        }

        /*
         * Для добавления командировки из личной карточки сотрудника
         * **/
        public void SetOneWorkerByTabelNumber(decimal tabNumber)
        {
            PERSONCARD personcard;
            try
            {
                 personcard = model.PERSONCARD.First(p => p.TABEL_NUM == tabNumber);
                if (personcard == null)
                    throw new NullReferenceException("personcard == null");
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine(exception.Message);
                MyMsgBox.showError("Не удалось открыть форму. Скорее всего, такого работника нет в базе");
                return;
            }
            SetWorkers(new List<PERSONCARD> {personcard});
        }
        
        /*
         * Для открытия командировки по приказу 
         * **/
        public void SetPrikaz(long selectedPrikazPkPrikaz)
        {
            UPDTRIP trip = null;
            try{
                trip = model.UPDTRIP.First(t => t.PK_PRIKAZ == selectedPrikazPkPrikaz);
                if(trip == null)
                    throw new NullReferenceException("С этим приказом не связано ни одной командировки");
            }
            catch (Exception exception)
            {
                MyMsgBox.showError(exception.Message);
                return;
            }
            SetTrip(trip.PK_TRIP);
        }
        
        public void UpdatePlaces()
        {
            organizations = new Dictionary<String, HashSet<TRIP_ORG>>();
            cities = new Dictionary<String, HashSet<String>>();
            allOrgs = model.TRIP_ORG;
            foreach (TRIP_ORG org in allOrgs)
            {
                PLACE_TRIP place = org.PLACE_TRIP;
                String country = place.Country;
                String city = place.City;
                if (!cities.ContainsKey(country))
                    cities[country] = new HashSet<string>();
                cities[country].Add(city);
                if (!organizations.ContainsKey(city))
                    organizations[city] = new HashSet<TRIP_ORG>();
                organizations[city].Add(org);
            }
            CounrtyColumn.DataSource = cities.Keys.ToList();
            OrganizationColumn.ValueType = typeof(TRIP_ORG);
            OrganizationColumn.DisplayMember = "NAME";
            OrganizationColumn.ValueMember = "PK_TRIP_ORG";
        }


        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            SearchWorkerForm searchWorkerForm = new SearchWorkerForm(model, this);
            searchWorkerForm.ShowDialog();
            this.Activate();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPlaceButton_Click(object sender, EventArgs e)
        {
            AddPlaceKomandForm addPlaceKomandForm = new AddPlaceKomandForm(model, this);
            addPlaceKomandForm.ShowDialog();
            this.Activate();
        }

        private void placesView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = placesView.Rows[e.RowIndex];
            DataGridViewComboBoxCell city = row.Cells[CityColumn.Name] as DataGridViewComboBoxCell;
            DataGridViewComboBoxCell organization = row.Cells[OrganizationColumn.Name] as DataGridViewComboBoxCell;
            if (e.ColumnIndex < 2)
            {
                if (city == null || row.Cells[0].Value == null)
                {
                    Console.WriteLine("city is null");
                    return;
                }
                city.DataSource = cities[row.Cells[0].Value as string].ToList();
                if (organization == null || row.Cells[1].Value == null)
                {
                    Console.WriteLine("organization is null");
                    return;
                }
                organization.DataSource = organizations[row.Cells[1].Value as string].ToList();
                organization.ValueType = typeof(TRIP_ORG);
                organization.DisplayMember = "NAME";
                organization.ValueMember = "PK_TRIP_ORG";
            }

            if (e.ColumnIndex == 0)
            {
                city.Value = null;
                organization.Value = null;
            }

            if (e.ColumnIndex == 1)
            {
                organization.Value = null;
            }
        }
        
        public void AddOrgTrip(TRIP_ORG org)
        {
            int i = placesView.Rows.Add();
            DataGridViewRow row = placesView.Rows[i];
            DataGridViewComboBoxCell country = row.Cells[CounrtyColumn.Name] as DataGridViewComboBoxCell;
            DataGridViewComboBoxCell city = row.Cells[CityColumn.Name] as DataGridViewComboBoxCell;
            DataGridViewComboBoxCell organization = row.Cells[OrganizationColumn.Name] as DataGridViewComboBoxCell;
            country.DataSource = cities.Keys.ToList();
            city.DataSource = cities[org.PLACE_TRIP.Country].ToList();
            organization.DataSource = organizations[org.PLACE_TRIP.City].ToList();
            organization.ValueType = typeof(TRIP_ORG);
            organization.DisplayMember = "NAME";
            organization.ValueMember = "PK_TRIP_ORG";
            Console.WriteLine($" {(placesView.Rows[i].Cells[0] as DataGridViewComboBoxCell).Value} , " +
                              $"{(placesView.Rows[i].Cells[1] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[2] as DataGridViewComboBoxCell).Value} ");
            country.Value = org.PLACE_TRIP.Country;
            city.Value = org.PLACE_TRIP.City;
            organization.Value = org.PK_TRIP_ORG;
            Console.WriteLine($" {(placesView.Rows[i].Cells[0] as DataGridViewComboBoxCell).Value} ," +
                              $" {(placesView.Rows[i].Cells[1] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[2] as DataGridViewComboBoxCell).Value} ");
        }


        public Dictionary<string, HashSet<string>> GetCities()
        {
            return cities;
        }

        private void DeletePlaceButton_Click(object sender, EventArgs e)
        {
            var rows = placesView.SelectedRows;
            if (rows.Count < 1)
            {
                MyMsgBox.showInfo("Вы не выделили строку");
                return;
            }
            if (MyMsgBox.showAsk("Вы точно хотите удалить?") == false)
                return;
            
            for(int i = 0; i < rows.Count; i++){
                placesView.Rows.Remove(rows[i]);
            }
        }

        public void SetWorkers(ICollection<PERSONCARD_IN_TRIP> addedWorkers)
        {
            foreach (PERSONCARD_IN_TRIP worker in addedWorkers)
            {
                pERSONCARDINTRIPBindingSource.Add(worker);
            }
        }

        public void SetWorkers(IList<PERSONCARD> addedWorkers)
        {
            foreach(PERSONCARD worker in addedWorkers)
            {
                PERSONCARD_IN_TRIP tripWorker = model.PERSONCARD_IN_TRIP.Create();
                tripWorker.PERSONCARD = worker;
                pERSONCARDINTRIPBindingSource.Add(tripWorker);
            }
        }

        /*
         * Сохранение
         * 
         * */
         public bool Save()
        {
            if (trip == null)
                trip = new UPDTRIP();

            DateTime allStartDate = DateTime.Now, allFinishDate = DateTime.Now;
            String allPurpose = "", allFinance = "";
            if (isSameDatesCheckBox.Checked)
            {
                allStartDate = startDate.Value;
                allFinishDate = finishDate.Value;
                if (!checkedDates(allStartDate, allFinishDate))
                    return false;
            }

            if (PurposeCheckBox.Checked)
            {
                allPurpose = PurposeTextBox.Text;
                if (!checkString(allPurpose, "Цель - пустая строка"))
                    return false;
            }
            
            if (FinanceCheckBox.Checked)
            {
                allFinance = FinanceTextBox.Text;
                if (!checkString(allFinance, "Источник финансов - пустая строка"))
                    return false;

            }

            String numPrikaz, reason, note;
            DateTime datePrikaz;

            // Основание
            reason = ReasonTextBox.Text;
            if (!checkString(reason, "Основание - пустая строка")) return false;
            trip.OSNOVANIE = reason;
            if (isDateReasonCheckBox.Checked)
            {
                if (checkDateOnNull(DateReason.Value, "Дата основания"))
                    trip.OSNOVANIEDATE = DateReason.Value;
                else
                    return false;
            }

            // Примечание
            note = NoteTextBox.Text;
            trip.NOTE = note;
            
            // Организации
            List<TRIP_ORG> addedOrgs = new List<TRIP_ORG>();
            int countOrgs = 0;
            foreach (DataGridViewRow row in placesView.Rows)
            {
                decimal pk_org;
                try
                {
                    if((row.Cells[2] as DataGridViewComboBoxCell).Value == null)
                        throw new Exception();
                    pk_org = (Decimal)(row.Cells[2] as DataGridViewComboBoxCell).Value;
                }
                catch (Exception)
                {
                    //Игнорируем 
                    continue;
                }

                if (pk_org == 0)
                {
                    Console.WriteLine("пк орг = 0");
                    continue;
                }

                TRIP_ORG org = model.TRIP_ORG.Find(pk_org);

                if (org == null)
                {
                    Console.WriteLine("орг = 0, но пкОрг != 0");
                    continue;
                }
                addedOrgs.Add(org);
                if (trip.TRIP_ORG.Contains(org) == false)
                    trip.TRIP_ORG.Add(org);
                countOrgs++;
            }
            if(countOrgs == 0)
            {
                MyMsgBox.showError("Добавьте хотя бы 1 организацию");
                return false;
            }
            DeleteFromList<TRIP_ORG>(addedOrgs, trip.TRIP_ORG);

            //Люди
            //Костылёк
            PERSONCARD workerForAddInPrikaz = null; 
            List<PERSONCARD_IN_TRIP> addedWorkers = new List<PERSONCARD_IN_TRIP>();
            foreach (PERSONCARD_IN_TRIP worker in pERSONCARDINTRIPBindingSource)
            {
                if (isSameDatesCheckBox.Checked)
                {
                    worker.STARTDATE = allStartDate;
                    worker.ENDDATE = allFinishDate;
                }
                if (PurposeCheckBox.Checked)
                {
                    worker.GOAL = allPurpose;
                }
                if (FinanceCheckBox.Checked)
                {
                    worker.FINANCE = allFinance;
                }
                if (checkWorker(worker))
                {
                    if (workerForAddInPrikaz == null)
                        workerForAddInPrikaz = worker.PERSONCARD;
                    addedWorkers.Add(worker);
                    if (trip.PERSONCARD_IN_TRIP.Contains<PERSONCARD_IN_TRIP>(worker) == false)
                        trip.PERSONCARD_IN_TRIP.Add(worker);
                }
                else
                {
                    if (!MyMsgBox.showAsk("Найдены работники с невалидными данными. Пропустить их(ДА) или остановить сохранение(НЕТ)"))
                        return false;
                }
            }
            if(workerForAddInPrikaz == null)
            {
                MyMsgBox.showError("Добавьте хотя бы 1 человека");
                return false;
            }
            DeleteFromList<PERSONCARD_IN_TRIP>(addedWorkers, trip.PERSONCARD_IN_TRIP);
            
            //Приказ
            datePrikaz = DatePrikaz.Value;
            if (trip.PRIKAZ == null)
            {
                trip.PRIKAZ = new PRIKAZ();
                trip.PRIKAZ.PK_TYPE_PRIKAZ = 2;
                trip.PRIKAZ.PK_OUR_ORG = 1;
                if (trip.PERSONCARD_IN_TRIP.Count > 1)
                    trip.PRIKAZ.OKUD = "0301023";
                else
                    trip.PRIKAZ.OKUD = "0301022";
                trip.PRIKAZ.OKPO = model.OUR_ORG.First().OKPO ?? "";
            }
            //Костылёк
            if (workerForAddInPrikaz != null)
                trip.PRIKAZ.PK_PERSONCARD = workerForAddInPrikaz.PK_PERSONCARD;
            if (checkDateOnNull(DatePrikaz.Value, "Дата приказа"))
                trip.PRIKAZ.CREATEDATE = datePrikaz;
            else
                return false;
            trip.PRIKAZ.ISPROJECT = IsProject.Checked ? "1" : "0";
            if(GenNumPrikaz.Checked){
                if(trip.PRIKAZ.PK_PRIKAZ != 0)
                    numPrikaz = trip.PRIKAZ.PK_PRIKAZ.ToString();
                else
                {
                    long sequenceGen = model.Database.SqlQuery<long>("Select ADMIN.prikaz_seq.NEXTVAL from dual")
                        .SingleOrDefault();
                    numPrikaz = sequenceGen.ToString();
                    trip.PRIKAZ.PK_PRIKAZ = sequenceGen;
                }
            }
            else
                numPrikaz = NumPrikazTextBox.Text;
            
            if (!checkString(numPrikaz, "Номер приказа - пустая строка")) return false;
            trip.PRIKAZ.NUMDOC = numPrikaz;
            
            //Новая или старая
            if (trip.PK_TRIP != 0)
            {
                model.Entry<UPDTRIP>(trip).State = EntityState.Modified;
            }
            else
                model.UPDTRIP.Add(trip);
            
            try { 
                model.SaveChanges();
            }
            catch(Exception except)
            {
                Console.Error.WriteLine(except.Message);
                return false;
            }
            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(Save())
                MyMsgBox.showInfo("Сохранено");
        }

        public void DeleteFromList<TEntity>(ICollection<TEntity> added, ICollection<TEntity> all) where TEntity : class
        {
            List<TEntity> needDelete = new List<TEntity>();
            foreach(TEntity entity in all)
            {
                if (added.Contains<TEntity>(entity) == false)
                    needDelete.Add(entity);
            }
            foreach (TEntity delEntity in needDelete)
                model.Entry<TEntity>(delEntity).State = EntityState.Deleted;
        }

            public bool checkWorker(PERSONCARD_IN_TRIP worker)
        {
            if (worker == null || worker.PERSONCARD == null)
                return false;
            if (!checkedDates(worker.STARTDATE, worker.ENDDATE, false)){
                MyMsgBox.showError($"Для рабоника №{worker.TABEL_NUM} некорректные даты");
                return false;
            }

            if (!checkString(worker.FINANCE, $"Для рабоника №{worker.TABEL_NUM} некорректный источник финансов"))
                return false;

            if (!checkString(worker.GOAL, $"Для рабоника №{worker.TABEL_NUM} некорректная цель"))
                return false;

            return true;

        }
        public bool checkString(string str, string msg = "")
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                if (msg != "")
                    MyMsgBox.showError(msg);
                return false;
            }
            return true;
        }
        public bool checkDateOnNull(DateTime? date, string nameDate)
        {
            if (date == null) { 
                MyMsgBox.showError($"{nameDate} не установлена");
                return false;
            }
            return true;
        }
        public bool checkedDates(DateTime? start, DateTime? finish, bool showMsg = true)
        {
            if(!checkDateOnNull(start, "Дата начала") || !checkDateOnNull(finish, "Дата окончания") || ((DateTime)start).CompareTo(finish) > 0)
            {
                if (showMsg && ((DateTime)start).CompareTo(finish) > 0)
                    MyMsgBox.showError("Дата начала не может быть позже даты окончания");
                return false;
            }
            return true;
        }

        private void isSameDatesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            StartDateColumn.Visible = !isSameDatesCheckBox.Checked;
            FinishDateColumn.Visible = !isSameDatesCheckBox.Checked;
            panelDates.Visible = isSameDatesCheckBox.Checked;
        }

        private void WorkersGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MyMsgBox.showError("Дата должна быть в формате дд.мм.гггг");
        }

        private void PurposeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PurposeColumn.Visible = !PurposeCheckBox.Checked;
            panelPurpose.Visible = PurposeCheckBox.Checked;
        }

        private void FinanceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FinanceColumn.Visible = !FinanceCheckBox.Checked;
            panelFinance.Visible = FinanceCheckBox.Checked;
        }

        private void KomandirovkaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !MyMsgBox.showAsk("Вы точно хотите закрыть окно? Все несохранённые изменения будут утеряны!");
        }

        private void placesView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Для игнора ошибок от placesView
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(trip == null)
            {
                MyMsgBox.showError("Нельзя удалить ещё не добавленную командировку");
                return;
            }
            else if(MyMsgBox.showAsk("Вы уверены, что хотите удалить командировку ?"))
            {
                model.UPDTRIP.Remove(trip);
                try { 
                    model.SaveChanges();
                    MyMsgBox.showInfo("Удалено!");
                }
                catch(Exception exc)
                {
                    Console.Error.WriteLine(exc);
                    MyMsgBox.showError("Ошибка при удалении");
                }
            }
        }

        private void isDateReasonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DateReason.Enabled = isDateReasonCheckBox.Checked;
        }
        
        private void GenNumPrikaz_CheckedChanged(object sender, EventArgs e)
        {
            NumPrikazTextBox.Enabled = !GenNumPrikaz.Checked;
        }

        private void DeleteWorkerButton_Click(object sender, EventArgs e)
        {
            var rows = WorkersGridView.SelectedRows;
            if (rows.Count < 1)
            {
                MyMsgBox.showInfo("Вы не выделили строку");
                return;
            }
            if (MyMsgBox.showAsk("Вы точно хотите удалить?") == false)
                return;

            for (int i = 0; i < rows.Count; i++)
            {
                WorkersGridView.Rows.Remove(rows[i]);
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Application exApp;
            try
            {
                exApp = new Application();
                 
            }
            catch (Exception)
            {
                MyMsgBox.showError("Не удалось открыть Excel для заполения данных.");
                return;
            }
            string PATH_TO_T9 = "templates\\T-9.xls";
            string PATH_TO_T9A = "templates\\T-9A.xls";
            if (!Directory.Exists("templates"))
                Directory.CreateDirectory("templates");
            // спешл фор Астахова
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            // try
            // {
            //     // спешл фор 7 винда
            //     //if(Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString().Contains("7"))
            //         System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            // }catch(Exception){}
            try
            {
                if (!File.Exists(PATH_TO_T9))
                {
                    new WebClient().DownloadFile(new Uri("https://github.com/pi62/templates/raw/master/T-9.xls"),
                        PATH_TO_T9);
                }

                if (!File.Exists(PATH_TO_T9A))
                {
                    new WebClient().DownloadFile(new Uri("https://github.com/pi62/templates/raw/master/T-9A.xls"),
                        PATH_TO_T9A);
                }
            }
            catch (Exception)
            {
                MyMsgBox.showError("Не удалось скачать шаблоны для заполнения.");
                return;
            }

            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.ShowDialog();
            var savePath = saveFileDialog1.FileName;
           
            if (String.IsNullOrWhiteSpace(savePath))
                return;
            if (!Save() || trip == null)
            {
                MyMsgBox.showError("Не удалось сохранить командировку. Экспорт невозможен. Проверьте данные и попробуйте ещё раз");
                return;
            }
            Workbook excelappworkbooks;
            try {
                if (trip.PERSONCARD_IN_TRIP.Count > 1) {
                    excelappworkbooks = exApp.Workbooks.Open(Directory.GetCurrentDirectory() + "\\" + PATH_TO_T9A, Type.Missing, false, Type.Missing, Type.Missing,
                  Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                else
                {
                    excelappworkbooks = exApp.Workbooks.Open(Directory.GetCurrentDirectory() + "\\" + PATH_TO_T9, Type.Missing, false, Type.Missing, Type.Missing,
                      Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
            } catch (Exception except)
            {
                Console.Error.WriteLine(except.Message);
                MyMsgBox.showError("Не удалось открыть шаблон");
                return;
            }
            if (excelappworkbooks == null) {
                MyMsgBox.showError("Не удалось открыть шаблон");
                return;
            }
            try { 
                if (trip.PERSONCARD_IN_TRIP.Count > 1)
                {
                    Worksheet excelsheets = excelappworkbooks.Worksheets.Item[1];
                    OUR_ORG org = model.OUR_ORG.First<OUR_ORG>();
                    if (trip.PRIKAZ.ISPROJECT.Equals("1")){
                        excelsheets.Cells[9, 34].Value = "ПРОЕКТ ПРИКАЗА";
                        excelsheets.Cells[10, 34].Value = "(распоряжения)";
                    }
                    else
                    {
                        excelsheets.Cells[9, 34].Value = "ПРИКАЗ";
                        excelsheets.Cells[10, 34].Value = "(распоряжение)";
                    }
                    excelsheets.Cells[5,1].Value = org.NAME;
                    excelsheets.Cells[5, 93] = org.OKPO;
                    excelsheets.Cells[9, 61] = trip.PRIKAZ.NUMDOC;
                    if (trip.PRIKAZ.CREATEDATE != null)
                        excelsheets.Cells[9, 80] = trip.PRIKAZ.CREATEDATE.Value.ToString("dd.MM.yyyy");
                    int i = 0;
                    foreach(PERSONCARD_IN_TRIP person in trip.PERSONCARD_IN_TRIP) {
                        if(i == 3)
                        {
                            MyMsgBox.showError("В одном приказе не больше 3х человек");
                            break;
                        }
                        excelsheets.Cells[15, 44 + 22 * i].Value = person.SURNAME + " " + person.NAME + " " + person.MIDDLENAME;
                        excelsheets.Cells[16, 44 + 22 * i].Value = person.TABEL_NUM;
                        if(person.PODRAZDELORG != null)
                            excelsheets.Cells[17, 44 + 22 * i].Value = person.PODRAZDELORG.NAME;
                        excelsheets.Cells[18, 44 + 22 * i].Value = person.JOB_POS.NAME;
                        excelsheets.Cells[21, 44 + 22 * i].Value = person.STARTDATE.Value.ToString("dd.MM.yyyy");
                        excelsheets.Cells[22, 44 + 22 * i].Value = person.ENDDATE.Value.ToString("dd.MM.yyyy");
                        excelsheets.Cells[23, 44 + 22 * i].Value = (int)person.ENDDATE.Value.Subtract(person.STARTDATE.Value).TotalDays;
                        excelsheets.Cells[24, 44 + 22 * i].Value = person.GOAL;
                        excelsheets.Cells[25, 44 + 22 * i].Value = person.FINANCE;
                        i++;
                    }
                    
                    foreach(TRIP_ORG tripOrg in trip.TRIP_ORG) {
                        excelsheets.Cells[19, 44].Value += tripOrg.PLACE_TRIP.NAME;
                        excelsheets.Cells[19, 44].Value += ", " + tripOrg.NAME;
                        excelsheets.Cells[19, 44].Value += ";  ";
                    }
                    
                    if (trip.OSNOVANIEDATE != null)
                        excelsheets.Cells[30,36].Value = trip.OSNOVANIE + " от " + trip.OSNOVANIEDATE.Value.ToString("dd.MM.yyyy");
                    else
                        excelsheets.Cells[30,36].Value = trip.OSNOVANIE;
                }
                else
                {
                    Worksheet excelsheets = excelappworkbooks.Worksheets.Item[1];
                    OUR_ORG org = model.OUR_ORG.First();
                    if (trip.PRIKAZ.ISPROJECT.Equals("1")){
                        excelsheets.Cells[13, 19].Value = "ПРОЕКТ ПРИКАЗА";
                        excelsheets.Cells[14, 19].Value = "(распоряжения)";
                    }
                    else
                    {
                        excelsheets.Cells[13, 19].Value = "ПРИКАЗ";
                        excelsheets.Cells[14, 19].Value = "(распоряжение)";
                    }

                    excelsheets.Cells[7, 1].Value = org.NAME;
                    excelsheets.Cells[7, 45] = org.OKPO;
                    excelsheets.Cells[13, 35] = trip.PRIKAZ.NUMDOC;
                    if (trip.PRIKAZ.CREATEDATE != null)
                        excelsheets.Cells[13, 48] = trip.PRIKAZ.CREATEDATE.Value.ToString("dd.MM.yyyy");
                    PERSONCARD_IN_TRIP person = trip.PERSONCARD_IN_TRIP.First();
                    excelsheets.Cells[18, 1].Value = person.SURNAME + " " + person.NAME + " " + person.MIDDLENAME;
                    excelsheets.Cells[18, 47].Value = person.TABEL_NUM;
                    if (person.PODRAZDELORG != null)
                        excelsheets.Cells[20, 1].Value = person.PODRAZDELORG.NAME;
                    excelsheets.Cells[22,1].Value = person.JOB_POS.NAME;
                    int i = 0;
                    foreach(TRIP_ORG tripOrg in trip.TRIP_ORG) { 
                        if(excelsheets.Cells[24 + i, 1].Text.Length > 100)
                        {
                            if (i == 0)
                                i += 2;
                            else
                                i++;
                        }
                        excelsheets.Cells[24+i, 1].Value += tripOrg.PLACE_TRIP.NAME;
                        excelsheets.Cells[24+i, 1].Value += ", " + tripOrg.NAME;
                        excelsheets.Cells[24 + i, 1].Value += " ; ";
                    }
                    excelsheets.Cells[33, 3].Value = person.STARTDATE.Value.Day;
                    excelsheets.Cells[33, 7].Value = person.STARTDATE.Value.ToString("MMMM");
                    excelsheets.Cells[33, 21].Value = person.STARTDATE.Value.ToString("yy");

                    excelsheets.Cells[33, 30].Value = person.ENDDATE.Value.Day;
                    excelsheets.Cells[33, 34].Value = person.ENDDATE.Value.ToString("MMMM");
                    excelsheets.Cells[33, 48].Value = person.ENDDATE.Value.ToString("yy");

                    excelsheets.Cells[31, 8].Value = (int)person.ENDDATE.Value.Subtract(person.STARTDATE.Value).TotalDays;
                    excelsheets.Cells[35,6].Value = person.GOAL;
                    excelsheets.Cells[38, 18].Value = person.FINANCE;
                   
                    

                    if (trip.OSNOVANIEDATE != null)
                        excelsheets.Cells[42, 15].Value = trip.OSNOVANIE + " от " + trip.OSNOVANIEDATE.Value.ToString("dd.MM.yyyy");
                    else
                        excelsheets.Cells[42, 15].Value = trip.OSNOVANIE;
                }
                
            }
            catch(Exception except)
            {
                Console.Error.WriteLine(except.Message);
            }
            MyMsgBox.showInfo("Готово!");
            excelappworkbooks.SaveAs(savePath);
            exApp.Quit();
        }
    }
}