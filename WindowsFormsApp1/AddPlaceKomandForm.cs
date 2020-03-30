using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Komandirovki
{
    public partial class AddPlaceKomandForm : Form
    {
        private Model1 model;
        private KomandirovkaForm komandirovkaForm;

        public AddPlaceKomandForm()
        {
            InitializeComponent();
        }

        public AddPlaceKomandForm(Model1 model, KomandirovkaForm komandirovkaForm)
        {
            InitializeComponent();
            this.model = model;
            this.komandirovkaForm = komandirovkaForm;
            CountryComboBox.DataSource = komandirovkaForm.GetCities().Keys.ToList();
            CountryComboBox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var country = CountryComboBox.SelectedValue;
            if (country == null) {
                MyMsgBox.showError("Страна не выбрана!");
                return;
            }

            var city = CityTextBox.Text;
            if (city == null)
            {
                MyMsgBox.showError("Введите город");
                return;
            }
            var org = OrganizationTextBox.Text;
            if (org == null || org == "")
            {
                MyMsgBox.showError("Введите название организации");
                return;
            }
            var places = model.PLACE_TRIP;

            PLACE_TRIP neededPlace = null;
            foreach(PLACE_TRIP place in places)
            {
                if(String.Compare(place.NAME, city, true) == 0) {
                    neededPlace = place;
                    break;
                }
            }

            if(neededPlace == null)
            {
                PLACE_TRIP newPlace = new PLACE_TRIP();
                string test = country as string;
                newPlace.Country = test;
                newPlace.City = city;
                newPlace.createName();
                model.PLACE_TRIP.Add(newPlace);
                model.SaveChanges();
                neededPlace = model.PLACE_TRIP.Where(place => place.NAME == newPlace.NAME).FirstOrDefault();
            }

            TRIP_ORG trip_org = new TRIP_ORG();
            trip_org.NAME = org;
            trip_org.PLACE_TRIP = neededPlace;
            model.TRIP_ORG.Add(trip_org);
            model.SaveChanges();
            komandirovkaForm.UpdatePlaces();

            MyMsgBox.showInfo("Добавлено!");
        }
    }
}