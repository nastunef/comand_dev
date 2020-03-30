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
        public Dictionary<String, List<String>> cities;
        //City -> orgs
        public Dictionary<String, List<TRIP_ORG>> organizations;
        private DbSet<TRIP_ORG> allOrgs;
        private DbSet<PLACE_TRIP> allPlaces;
        public KomandirovkaForm()
        {
            allOrgs = model.TRIP_ORG;

            //foreach (var org in allOrgs)
            //    Console.WriteLine(org.CountryPlace + ", " + org.CityPlace + ", " + org.NAME);
            InitializeComponent();

            UpdatePlaces();
            CounrtyColumn.DataSource = cities.Keys.ToList();
            OrganizationColumn.DisplayMember = "NAME";
            OrganizationColumn.ValueMember = "PK_TRIP_ORG";

            WorkersGridView.DataSource = 
        }

        public void UpdatePlaces()
        {
            organizations = new Dictionary<String, List<TRIP_ORG>>();
            cities = new Dictionary<String, List<String>>();
            allOrgs = model.TRIP_ORG;
            allPlaces = model.PLACE_TRIP;
            foreach (TRIP_ORG org in allOrgs)
            {
                PLACE_TRIP place = org.PLACE_TRIP;
                String country = place.Country;
                String city = place.City;
                if (!cities.ContainsKey(country))
                    cities[country] = new List<string>();
                cities[country].Add(city);
                if (!organizations.ContainsKey(city))
                    organizations[city] = new List<TRIP_ORG>();
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

        }

        private void AddPlaceButton_Click(object sender, EventArgs e)
        {
            AddPlaceKomandForm addPlaceKomandForm = new AddPlaceKomandForm(model, this);
            addPlaceKomandForm.Show();
        }

        private void placesView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = placesView.Rows[e.RowIndex];
            DataGridViewComboBoxCell city = row.Cells[1] as DataGridViewComboBoxCell;
            DataGridViewComboBoxCell organization = row.Cells[2] as DataGridViewComboBoxCell;
            if (e.ColumnIndex < 2)
            {
                if (city == null || row.Cells[0].Value == null)
                {
                    Console.WriteLine("city is null");
                    return;
                }
                city.DataSource = cities[row.Cells[0].Value as string];
                if (organization == null || row.Cells[1].Value == null)
                {
                    Console.WriteLine("organization is null");
                    return;
                }
                organization.DataSource = organizations[row.Cells[1].Value as string];
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
            Console.WriteLine($" {(placesView.Rows[i].Cells[0] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[1] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[2] as DataGridViewComboBoxCell).Value} ");
            (placesView.Rows[i].Cells[0] as DataGridViewComboBoxCell).Value = org.CountryPlace;
            (placesView.Rows[i].Cells[1] as DataGridViewComboBoxCell).Value = org.CityPlace;
            //(placesView.Rows[i].Cells[2] as DataGridViewComboBoxCell).Value = org;
            Console.WriteLine($" {(placesView.Rows[i].Cells[0] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[1] as DataGridViewComboBoxCell).Value} , {(placesView.Rows[i].Cells[2] as DataGridViewComboBoxCell).Value} ");

        }


        public Dictionary<string, List<string>> GetCities()
        {
            return cities;
        }

        private void DeletePlaceButton_Click(object sender, EventArgs e)
        {
            var rows = WorkersGridView.SelectedRows;
            if (rows.Count < 1)
                MyMsgBox.showInfo("Вы не выделили строку");
            if (MyMsgBox.showAsk("Вы точно хотите удалить?") == false)
                return;
            
            for(int i = 0; i < rows.Count; i++){
                TRIP_ORG org = rows[i].Cells[2].Value as TRIP_ORG;
                if (org == null)
                    continue;
                model.TRIP_ORG.Remove(org);
                WorkersGridView.Rows.Remove(rows[i]);
            }
            model.SaveChanges();
        }

        public void SetWorkers(IList<PERSONCARD> workers)
        {
            Console.WriteLine(workers);
        }
    }
}