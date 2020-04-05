using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1;

namespace Komandirovki
{
    public partial class KomandirovkaForm : Form
    {
        private Model1 model = new Model1();
        //Country -> cities
        public Dictionary<String, HashSet<String>> cities;
        //City -> orgs
        public Dictionary<String, HashSet<TRIP_ORG>> organizations;
        private DbSet<TRIP_ORG> allOrgs;

        private UpdatedTRIP trip = null;

        private DateTime nullDateTime = new DateTime(2020, 01, 01);
        /*
         * Для добавления командировки
         * **/
        public KomandirovkaForm()
        {
            allOrgs = model.TRIP_ORG;
            InitializeComponent();

            UpdatePlaces();
            CounrtyColumn.DataSource = cities.Keys.ToList();
            OrganizationColumn.DisplayMember = "NAME";
            OrganizationColumn.ValueMember = "PK_TRIP_ORG";
            OrganizationColumn.ValueType = typeof(TRIP_ORG);
         }

        /*
         * Для получения инфы по командировке UpdatedTRIP c перв.ключом == pk_UpdatedTrip, её редактирования и удаления
         * **/
        public KomandirovkaForm(decimal pk_UpdatedTrip) : this()
        {
            try
            {
                trip = model.UpdatedTRIP.Find(pk_UpdatedTrip);
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
                DatePrikaz.Value = trip.PRIKAZ.CREATEDATE != null ? (DateTime)trip.PRIKAZ.CREATEDATE : nullDateTime;
            }

            ReasonTextBox.Text = trip.OSNOVANIE != null ? trip.OSNOVANIE : "";

            if(trip.OSNOVANIEDATE != null)
            {
                isDateReasonCheckBox.Checked = true;
                DateReason.Value = (DateTime)trip.OSNOVANIEDATE;
            }
            else
            {
                isDateReasonCheckBox.Checked = false;

            }
            NoteTextBox.Text = trip.NOTE != null ? trip.NOTE : "";
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
        }


        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            SearchWorkerForm searchWorkerForm = new SearchWorkerForm(model, this);
            searchWorkerForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPlaceButton_Click(object sender, EventArgs e)
        {
            AddPlaceKomandForm addPlaceKomandForm = new AddPlaceKomandForm(model, this);
            addPlaceKomandForm.Show();
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
            city.DataSource = cities[org.CountryPlace].ToList();
            organization.DataSource = organizations[org.CityPlace].ToList();
            organization.ValueType = typeof(TRIP_ORG);
            organization.DisplayMember = "NAME";
            organization.ValueMember = "PK_TRIP_ORG";
            Console.WriteLine($" {(placesView.Rows[i].Cells[0] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[1] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[2] as DataGridViewComboBoxCell).Value} ");
            country.Value = org.CountryPlace;
            city.Value = org.CityPlace;
            organization.Value = org.PK_TRIP_ORG;
            Console.WriteLine($" {(placesView.Rows[i].Cells[0] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[1] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[2] as DataGridViewComboBoxCell).Value} ");
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
         * **/
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (trip == null)
                trip = new UpdatedTRIP();

            DateTime allStartDate = DateTime.Now, allFinishDate = DateTime.Now;
            String allPurpose = "", allFinance = "";
            if (isSameDatesCheckBox.Checked)
            {
                allStartDate = startDate.Value;
                allFinishDate = finishDate.Value;
                if (!checkedDates(allStartDate, allFinishDate))
                    return;
            }

            if (PurposeCheckBox.Checked)
            {
                allPurpose = PurposeTextBox.Text;
                if (!checkString(allPurpose, "Цель - пустая строка"))
                    return;

            }


            if (FinanceCheckBox.Checked)
            {
                allFinance = FinanceTextBox.Text;
                if (!checkString(allFinance, "Источник финансов - пустая строка"))
                    return;

            }

            String numPrikaz, reason, note;
            DateTime datePrikaz;

            reason = ReasonTextBox.Text;
            if (!checkString(reason, "Основание - пустая строка")) return;
            trip.OSNOVANIE = reason;
            if (isDateReasonCheckBox.Checked) {
                if (checkDateOnNull(DateReason.Value, "Дата основания"))
                    trip.OSNOVANIEDATE = DateReason.Value;
                else
                    return;
            }

            note = NoteTextBox.Text;
            trip.NOTE = note;

            datePrikaz = DatePrikaz.Value;
            if (trip.PRIKAZ == null)
            {
                trip.PRIKAZ = new PRIKAZ();
                trip.PRIKAZ.PK_TYPE_PRIKAZ = 2;
                trip.PRIKAZ.PK_OUR_ORG = 1;
            }
            if (checkDateOnNull(DatePrikaz.Value, "Дата приказа"))
                trip.PRIKAZ.CREATEDATE = datePrikaz;
            else
                return;

            numPrikaz = NumPrikazTextBox.Text;
            if (!checkString(numPrikaz, "Номер приказа - пустая строка")) return;
            trip.PRIKAZ.NUMDOC = numPrikaz;
            List<TRIP_ORG> addedOrgs = new List<TRIP_ORG>();
            foreach (DataGridViewRow row in placesView.Rows)
            {
                decimal pk_org = 0;
                try 
                { 
                    pk_org = (Decimal)(row.Cells[2] as DataGridViewComboBoxCell).Value;
                }
                catch(Exception except)
                {
                    continue;
                }

               if (pk_org == 0) {
                    Console.WriteLine("пк орг = 0");
                    continue;
                }

                TRIP_ORG  org = model.TRIP_ORG.Find(pk_org);

                if(org == null)
                {
                    Console.WriteLine("орг = 0, но пкОрг != 0");
                    continue;
                }
                addedOrgs.Add(org);
                if (trip.TRIP_ORG.Contains(org) == false)
                    trip.TRIP_ORG.Add(org);
            }
            DeleteFromList<TRIP_ORG>(addedOrgs, trip.TRIP_ORG);

            List<PERSONCARD_IN_TRIP> addedWorkers = new List<PERSONCARD_IN_TRIP>();
            foreach (PERSONCARD_IN_TRIP worker in pERSONCARDINTRIPBindingSource)
            {
                if (isSameDatesCheckBox.Checked) {
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
                if (checkWorker(worker)) {
                    addedWorkers.Add(worker);
                    if(trip.PERSONCARD_IN_TRIP.Contains<PERSONCARD_IN_TRIP>(worker) == false)
                        trip.PERSONCARD_IN_TRIP.Add(worker);
                }
                else
                {
                    if (!MyMsgBox.showAsk("Найдены работники с невалидными данными. Пропустить их(ДА) или остановить сохранение(НЕТ)"))
                        return;
                }
            }
            DeleteFromList<PERSONCARD_IN_TRIP>(addedWorkers, trip.PERSONCARD_IN_TRIP);

            if (trip.PK_TRIP != 0) 
            {
                model.Entry<UpdatedTRIP>(trip).State = System.Data.Entity.EntityState.Modified;
            }
            else
                model.UpdatedTRIP.Add(trip);
            model.SaveChanges();
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
                model.Entry<TEntity>(delEntity).State = System.Data.Entity.EntityState.Deleted;
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
            if (date == null || ((DateTime)date).Equals(nullDateTime)) { 
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
            if (isSameDatesCheckBox.Checked)
            {
                StartDateColumn.Visible = false;
                FinishDateColumn.Visible = false;
                panelDates.Visible = true;
            }
            else
            {
                panelDates.Visible = false;
                StartDateColumn.Visible = true;
                FinishDateColumn.Visible = true;
            }
        }

        private void WorkersGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MyMsgBox.showError("Дата должна быть в формате дд.мм.гггг");
        }

        private void PurposeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PurposeCheckBox.Checked)
            {
                PurposeColumn.Visible = false;
                panelPurpose.Visible = true;
            }
            else
            {
                panelPurpose.Visible = false;
                PurposeColumn.Visible = true;
            }
        }

        private void FinanceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FinanceCheckBox.Checked)
            {
                FinanceColumn.Visible = false;
                panelFinance.Visible = true;
            }
            else
            {
                panelFinance.Visible = false;
                FinanceColumn.Visible = true;
            }
        }

        private void KomandirovkaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!MyMsgBox.showAsk("Вы точно хотите закрыть окно? Все несохранённые изменения будут утеряны!"))
            {
                //Отменить закрытие
                e.Cancel = true;
            }
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
                model.UpdatedTRIP.Remove(trip);
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
            if (isDateReasonCheckBox.Checked)
                DateReason.Enabled = true;
            else
                DateReason.Enabled = false;
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
    }
}