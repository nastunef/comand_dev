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
        private decimal id = -1;

        public PersonalCard()
        {
            InitializeComponent();
            initCatalogs();
            richTextBox_dopSved.ReadOnly = true;
            button3.Enabled = false;
        }

        public PersonalCard(decimal id)
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

            Column_educationType.Items.AddRange(model.TYPE_EDU.Select(type => type.NAME).ToArray());
            Column_educationPlace.Items.AddRange(model.PLACE_EDU.Select(place => place.NAME).ToArray());
            Column_specialnost.Items.AddRange(model.SPECIALTY.Select(spec => spec.NAME).ToArray());
        }

        private void button_dopSved_Click(object sender, EventArgs e)
        {
            richTextBox_dopSved.ReadOnly = !richTextBox_dopSved.ReadOnly;
            button_dopSved.Text = richTextBox_dopSved.ReadOnly
                ? "Включить режим редактирования"
                : "Выключить режим редактирования";
        }

        private void initData(decimal id)
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

            foreach (var lang in card.UNION_LANGUAGE_PERSONCARD)
            {
                dataGridView_languages.Rows.Add(lang.LANGUAGE.NAME, lang.LANGUAGE_LVL.NAME);
            }

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

            textBox_doljnost2.Text = card.JOB_POSITION.NAME;
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

            showKomandirovki(card);

            richTextBox_dopSved.Text = card.DOPINFO;

            textBox_dateUval.Text = card.UVALDATE.ToString();
            try
            {
                textBox_uvalWorkerJob.Text = card.UVAL.First().JOB_POSITION.NAME;
                //todo фио уволившего найти хз где
                textBox_orderNumber.Text = card.UVAL.First().NUMWORKDOGOVOR;
                textBox_orderDate.Text = card.UVAL.First().ENDWORKDOGOVORDATE.ToString();
            }
            catch (Exception e)
            {
                // значит там наверное пусто и нам все равно
            }
        }

        // Отобразить командировки работника
        private void showKomandirovki(PERSONCARD card)
        {
            dataGridView_comand.Rows.Clear();
            try
            {
                foreach (var trip in card.PERSONCARD_IN_TRIP)
                {
                    dataGridView_comand.Rows.Add(
                        // Первичный ключ в скрытое поле, чтобы потом открыть подробную инфу
                        trip.PK,
                        trip.STARTDATE.Value.ToString("dd.MM.yyyy"),
                        trip.ENDDATE.Value.ToString("dd.MM.yyyy"),
                        trip.UPDTRIP.TRIP_ORG.Count != 0 ? trip.UPDTRIP.TRIP_ORG.First().PLACE_TRIP.NAME : "",
                        trip.GOAL
                    );
                }
            }
            catch (Exception e)
            {
                // ну нет и нет, чего бубнить то
            }
        }

        private void saveData()
        {
            try
            {

                Model1 model = new Model1();
                PERSONCARD personcard;
                if (id != -1)
                    personcard = model.PERSONCARD.First(x => x.PK_PERSONCARD == id);
                else
                    personcard = new PERSONCARD();

                personcard.NAME = textBox_name.Text;
                personcard.SURNAME = textBox_secondName.Text;
                personcard.ALPHABET = personcard.SURNAME[0].ToString();
                personcard.MIDDLENAME = textBox_otch.Text;
                personcard.MOBTEL = textBox_telephone.Text;
                personcard.DOPTEL = textBox_telephone2.Text;
                personcard.TABEL_NUM = Convert.ToInt32(textBox_tabelNumber.Text);

                personcard.DATECREATE = DateTime.Now;

                personcard.GENDER = model.GENDER.First(g => g.NAME == comboBox_gender.Text);

                personcard.GRAZDAN = model.GRAZDAN.First(g => g.NAME == comboBox_grazdan.Text);

                personcard.SERPASSPORT = textBox_passportSerial.Text;
                personcard.NUMPASSPORT = textBox_passportNumber.Text;
                personcard.PLACE_VIDACHI_PASSPORT = richTextBox_vidan.Text;
                personcard.PASSPORTGETDATE = Convert.ToDateTime(dateTimePicker_dateVidan.Text);

                personcard.BIRTHDATE = Convert.ToDateTime(dateTimePicker_birthday.Text);
                personcard.PLACEBIRTH = richTextBox_birthdayPlace.Text;

                personcard.PLACELIVE = richTextBox_livingPlace.Text;
                personcard.PLACEREGISTER = richTextBox_livingPlaceFact.Text;

                personcard.INN = textBox_inn.Text;
                personcard.SNILS = textBox_strah.Text;

                personcard.MARTIAL_STATUS = model.MARTIAL_STATUS.First(m => m.NAME == comboBobx_brak.Text);

                if (comboBox_profession.Text != "")
                    personcard.PROFESSION = model.PROFESSION.First(p => p.NAME == comboBox_profession.Text);

                saveFamily(personcard, model);
                saveEducation(personcard, model);
                saveLanguage(personcard, model);

                try
                {

                    if (id == -1)
                    {
                        personcard.PK_PERSONCARD = model.PERSONCARD.Max(p => p.PK_PERSONCARD) + 1;
                        model.PERSONCARD.Add(personcard);
                    }

                    personcard.TABEL_NUM = personcard.PK_PERSONCARD;
                    model.SaveChanges();
                    id = Convert.ToInt64(personcard.PK_PERSONCARD);
                    button3.Enabled = true;
                    textBox_tabelNumber.Text = personcard.TABEL_NUM.ToString();
                }
                catch (Exception e)
                {
                    DialogResult dialog = MessageBox.Show(
                        "Непредвиденная ошибка при сохранении личной карточки " + e.ToString(), "Ошибка",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                DialogResult dialog = MessageBox.Show(
                    "Ошибка при заполнении данных", "Ошибка",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void saveLanguage(PERSONCARD personcard, Model1 model)
        {
            decimal max = model.UNION_LANGUAGE_PERSONCARD.Max(u => u.PK_UNION);
            foreach (var lang in model.UNION_LANGUAGE_PERSONCARD.Where(m => m.PK_PERSONCARD == personcard.PK_PERSONCARD)
            )
            {
                model.UNION_LANGUAGE_PERSONCARD.Remove(lang);
            }

            for (int i = 0; i < dataGridView_languages.Rows.Count - 1; i++)
            {
                var row = dataGridView_languages.Rows[i];
                var lang = new UNION_LANGUAGE_PERSONCARD();
                lang.PK_UNION = ++max;
                lang.PERSONCARD = personcard;
                string name = row.Cells[0].Value.ToString();
                string lvl = row.Cells[1].Value.ToString();
                lang.LANGUAGE = model.LANGUAGE.First(l => l.NAME == name);
                lang.LANGUAGE_LVL = model.LANGUAGE_LVL.First(l => l.NAME == lvl);
                model.UNION_LANGUAGE_PERSONCARD.Add(lang);
            }
        }

        private void saveFamily(PERSONCARD personcard, Model1 model)
        {
            decimal max = model.FAMILY_MEMBER.Max(m => m.PK_MEMBER_FAMILY);
            foreach (var familyMember in model.FAMILY_MEMBER.Where(m => m.PK_PERSONCARD == personcard.PK_PERSONCARD))
            {
                model.FAMILY_MEMBER.Remove(familyMember);
            }

            for (int i = 0; i < dataGridView_family.Rows.Count - 1; i++)
            {
                String name = dataGridView_family.Rows[i].Cells[0].Value.ToString();
                FAMILY_MEMBER member = new FAMILY_MEMBER();
                member.PK_MEMBER_FAMILY = ++max;
                member.SURNAME = name.Split(' ')[0];
                member.NAME = name.Split(' ')[1];
                member.MIDDLENAME = name.Split(' ')[2];
                member.PERSONCARD = personcard;
                member.BIRTHYEAR = Convert.ToDateTime(dataGridView_family.Rows[i].Cells[1].Value);
                model.FAMILY_MEMBER.Add(member);
            }
        }

        private void saveEducation(PERSONCARD personcard, Model1 model)
        {
            decimal max = model.ONE_EDU.Max(e => e.PK_ONE_EDU);
            foreach (var edu in model.ONE_EDU.Where(m => m.PK_PERSONCARD == personcard.PK_PERSONCARD))
            {
                model.ONE_EDU.Remove(edu);
            }

            for (int i = 0; i < dataGridView_education.Rows.Count - 1; i++)
            {
                var row = dataGridView_education.Rows[i];
                ONE_EDU edu = new ONE_EDU();
                edu.PK_ONE_EDU = ++max;
                edu.NUMDOC = row.Cells[0].Value.ToString();
                edu.ENDDATE = Convert.ToDateTime(row.Cells[4].Value);
                edu.PERSONCARD = personcard;
                String type = row.Cells[1].Value.ToString(), place = row.Cells[2].Value.ToString(), specialyty = row.Cells[3].Value.ToString();
                edu.TYPE_EDU = model.TYPE_EDU.First(t => t.NAME == type);
                edu.PLACE_EDU = model.PLACE_EDU.First(t => t.NAME == place);
                edu.SPECIALTY = model.SPECIALTY.First(s => s.NAME == specialyty);
                model.ONE_EDU.Add(edu);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void dataGridView_education_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e);
        }

        /*
         * Показ командировки по даблклику на любую ячейку строки нужной командировки
         * **/
        private void dataGridView_comand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView_comand.Rows[e.RowIndex];
            decimal pk;
            // Пытаемся вытянуть 
            // Вдруг тыкнули по пустой строке или ещё что, поэтому try-catch
            try
            {
                pk = Convert.ToDecimal(row.Cells[0].Value);
                if (pk < 1)
                    throw new Exception();
            }
            catch (Exception except)
            {
                Console.Error.WriteLine("Не удалось вытянуть pk_personcard_in_trip с таблицы");
                return;
            }

            var pers = new Model1().PERSONCARD_IN_TRIP.Find(pk);
            if (pers == null)
            {
                Console.WriteLine("PERSONCARD_IN_TRIP не найдено для этой строки");
                return;
            }

            if (pers.PK_TRIP == null)
            {
                Console.WriteLine("Не указана командировка");
                return;
            }

            var form = new Komandirovki.KomandirovkaForm();
            form.SetTrip((decimal) pers.PK_TRIP);
            form.ShowDialog();
            //Обновляем
            showKomandirovki(new Model1().PERSONCARD.Find(pers.PK_PERSONCARD));
        }

        private void AddKomandButton_Click(object sender, EventArgs e)
        {
            if (id < 1){
                MyMsgBox.showError("Такого работника нет в базе.");
                return;
            }
            var form = new Komandirovki.KomandirovkaForm();
            form.SetOneWorker(id);
            form.ShowDialog();
            //Обновляем
            showKomandirovki(new Model1().PERSONCARD.Find(id));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id >= 0)
                initData(id);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (id >= 0)
                initData(id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (id >= 0)
                initData(id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 model = new Model1();
                var card = model.PERSONCARD.Find(id);
                DelWorkPrikaz delWorkPrikaz = new DelWorkPrikaz(card.TABEL_NUM.Value);
                delWorkPrikaz.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при создании приказа об увольнении для карточки с id={} {}", id, ex);
            }
        }
    }
}