using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PersonalCard : Form
    {
        private long id = -1;

        public PersonalCard()
        {
            InitializeComponent();
            initCatalogs();
            richTextBox_dopSved.ReadOnly = true;
        }

        public PersonalCard(long id)
        {
            InitializeComponent();
            initCatalogs();
            richTextBox_dopSved.ReadOnly = true;
            this.id = id;
            initData(id);
        }

        private void initCatalogs()
        {
            Model1 model = new Model1();

            comboBox_grazdan.Items.AddRange(model.GRAZDAN.Select(g => g.NAME).ToArray());

            comboBox_gender.Items.AddRange(model.GENDER.Select(g => g.NAME).ToArray());

            comboBobx_brak.Items.AddRange(model.MARTIAL_STATUS.Select(g => g.NAME).ToArray());

            Column_languageLevel.Items.AddRange(model.LANGUAGE_LVL.Select(g => g.NAME).ToArray());

            Column_language.Items.AddRange(model.LANGUAGE.Select(g => g.NAME).ToArray());

            comboBox_profession.Items.AddRange(model.PROFESSION.Select(p => p.NAME).ToArray());

            Column_educationType.Items.AddRange(model.TYPE_EDU.Select(type => type.NAME));
            Column_educationPlace.Items.AddRange(model.PLACE_EDU.Select(place => place.NAME));
            Column_specialnost.Items.AddRange(model.SPECIALTY.Select(spec => spec.NAME));
        }

        private void button_dopSved_Click(object sender, EventArgs e)
        {
            richTextBox_dopSved.ReadOnly = !richTextBox_dopSved.ReadOnly;
            button_dopSved.Text = richTextBox_dopSved.ReadOnly
                ? "Включить режим редактирования"
                : "Выключить режим редактирования";
        }

        private void initData(long id)
        {
            Model1 model = new Model1();
            var card = model.PERSONCARD.First(c => c.PK_PERSONCARD == id);
            if (card == null)
                return;

            textBox_name.Text = card.NAME;
            textBox_secondName.Text = card.SURNAME;
            textBox_otch.Text = card.MIDDLENAME;
            textBox_telephone.Text = card.MOBTEL;
            textBox_telephone2.Text = card.DOPTEL;
            textBox_tabelNumber.Text = card.TABEL_NUM.ToString();
            textBox_dolzhnost.Text = card.JOB_POSITION.NAME;
            textBox_struct.Text = card.TABEL.PODRAZDELORG.NAME;
            comboBox_gender.Text = card.GENDER.NAME;

            comboBox_grazdan.Text = card.GRAZDAN.NAME;
            textBox_passportSerial.Text = card.SERPASSPORT;
            textBox_passportNumber.Text = card.NUMPASSPORT;
            richTextBox_vidan.Text = card.PLACE_VIDACHI_PASSPORT;
            dateTimePicker_dateVidan.Text = card.PASSPORTGETDATE.ToString();

            dateTimePicker_birthday.Text = card.BIRTHDATE.ToString();
            richTextBox_birthdayPlace.Text = card.PLACEBIRTH;

            textBox_inn.Text = card.INN;
            textBox_strah.Text = card.SNILS;
            comboBobx_brak.Text = card.MARTIAL_STATUS.NAME;

            dataGridView_family.Rows.Clear();
            foreach (var member in card.FAMILY_MEMBER)
            {
                dataGridView_family.Rows.Add(member.SURNAME + " " + member.NAME + " " + member.MIDDLENAME,
                    member.BIRTHYEAR);
            }

            dataGridView_languages.Rows.Add(card.LANGUAGE.NAME, card.LANGUAGE.LANGUAGE_LVL.NAME);

            comboBox_profession.Text = card.PROFESSION.NAME;

            dataGridView_education.Rows.Clear();
            foreach (var edu in card.ONE_EDU)
            {
                dataGridView_education.Rows.Add(
                    edu.NUMDOC,
                    edu.TYPE_EDU.NAME,
                    edu.PLACE_EDU.NAME,
                    edu.SPECIALTY.NAME,
                    edu.ENDDATE
                );
            }
            
            textBox_doljnost2.Text =  card.JOB_POSITION.NAME;
            textBox_structOtdel.Text = card.TABEL.PODRAZDELORG.NAME;
            textBox_workType.Text = card.TYPE_WORK.NAME;
            textBox_workCharacter.Text = card.CHARACTER_WORK.NAME;

            dataGridView_job.Rows.Clear();
            foreach (var perevod in card.PEREVOD)
            {
                dataGridView_job.Rows.Add(
                    perevod.STARTWORKDATE,
                    perevod.ENDWORKDATE,
                    perevod.PODRAZDELORG.NAME,
                    perevod.JOB_POSITION.NAME,
                    perevod.JOB_POSITION1.STR_SHTAT_RASP.First().TARIFF,
                    perevod.PERSONCARD.CHARACTER_WORK.NAME,
                    perevod.JOB_POSITION1,
                    perevod.REASON
                );
            }

            dataGridView_comand.Rows.Clear();
            foreach (var trip in card.TRIP)
            {
                dataGridView_comand.Rows.Add(
                    trip.STARTDATE,
                    trip.ENDDATE,
                    trip.PLACE_TRIP.First().NAME,
                    trip.GOAL
                    );
            }

            richTextBox_dopSved.Text = card.DOPINFO;

            textBox_dateUval.Text = card.UVALDATE.ToString();
            textBox_uvalWorkerJob.Text = card.UVAL.First().JOB_POSITION.NAME;
            //todo фио уволившего найти хз где
            textBox_orderNumber.Text = card.UVAL.First().NUMWORKDOGOVOR;
            textBox_orderDate.Text = card.UVAL.First().ENDWORKDOGOVORDATE.ToString();
        }
    }
}