// using System;
// using System.Linq;
// using System.Windows.Forms;
// using WindowsFormsApp1;
//
// namespace Komandirovki
// {
//     public partial class AddPlaceKomandForm : Form
//     {
//         private Model1 model;
//         private KomandirovkaForm komandirovkaForm;
//
//         public AddPlaceKomandForm()
//         {
//             InitializeComponent();
//         }
//
//         public AddPlaceKomandForm(Model1 model, KomandirovkaForm komandirovkaForm)
//         {
//             InitializeComponent();
//             this.model = model;
//             this.komandirovkaForm = komandirovkaForm;
//             CountryComboBox.DataSource = komandirovkaForm.GetCities().Keys.ToList();
//             CountryComboBox.SelectedIndex = 0;
//         }
//
//         private void SaveButton_Click(object sender, EventArgs e)
//         {
//             var country = CountryComboBox.SelectedValue;
//             if (country == null) {
//                 MyMsgBox.showError("Страна не выбрана!");
//                 return;
//             }
//
//             var city = CityTextBox.Text;
//             if (city == null)
//             {
//                 MyMsgBox.showError("Введите город");
//                 return;
//             }
//             var org = OrganizationTextBox.Text;
//             if (string.IsNullOrEmpty(org))
//             {
//                 MyMsgBox.showError("Введите название организации");
//                 return;
//             }
//             var places = model.PLACE_TRIP;
//
//             PLACE_TRIP neededPlace = null;
//             foreach(PLACE_TRIP place in places)
//             {
//                 if(String.Compare(place.City, city, StringComparison.OrdinalIgnoreCase) == 0) {
//                     neededPlace = place;
//                     break;
//                 }
//             }
//
//             if(neededPlace == null)
//             {
//                 PLACE_TRIP newPlace = new PLACE_TRIP();
//                 string test = country as string;
//                 newPlace.Country = test;
//                 newPlace.City = city;
//                 newPlace.createName();
//                 model.PLACE_TRIP.Add(newPlace);
//                 model.SaveChanges();
//                 neededPlace = newPlace;
//                 Console.WriteLine($"id = {neededPlace.PK_PLACE_TRIP}");
//                 //neededPlace = model.PLACE_TRIP.FirstOrDefault(place => place.NAME == newPlace.NAME);
//             }
//
//             TRIP_ORG trip_org = model.TRIP_ORG.Create();
//             trip_org.NAME = org;
//             trip_org.PLACE_TRIP = neededPlace;
//             model.TRIP_ORG.Add(trip_org);
//             model.SaveChanges();
//             komandirovkaForm.UpdatePlaces();
//             Console.WriteLine($"id org = {trip_org.PK_TRIP_ORG}");
//             komandirovkaForm.AddOrgTrip(trip_org);
//             MyMsgBox.showInfo("Добавлено!");
//         }
//
//         private void AddPlaceKomandForm_FormClosing(object sender, FormClosingEventArgs e)
//         {
//             if (!MyMsgBox.showAsk("Вы уверены?"))
//                 e.Cancel = true;
//         }
//     }
// }