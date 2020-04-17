﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
  using Microsoft.Office.Interop.Excel;
  using Application = Microsoft.Office.Interop.Excel.Application;

  namespace ShtatnoeRasp
{
    public partial class Shtatka : Form
    {
        private Model1 model = new Model1();
        //Таблица со штаткой
        private List<StringShtatRasp> strginShtatRasps { get; set; }
        //Номер документа
        private string numDoc;
        //Дата составления
        private DateTime _dateTime;
        //Кол-во штатных единиц всего
        private int numerusPeople;
        //Наименование организации
        private string nameOraganization;
        //Код по ОКПО
        private string OKPO;
        //Руководитель кадровой службы
        private string FIORuc;
        
        public Shtatka()
        {
            InitializeComponent();
        }


        private StringShtatRasp setDataInString(StringShtatRasp str, int id ,string name, string kod, string dolgnost, string kolEd, double tariff, double nad1,
            double nad2, double nad3, string prim)
        {
            str.stringId = id;
            str.stringName = name;
            str.stringKod = kod;
            str.stringDolgnost = dolgnost;
            str.stringKolEd = kolEd;
            str.stringoklad = tariff;
            str.stringNad1 = nad1;
            str.stringNad2 = nad2;
            str.stringNad3 = nad3;
            str.stringTotal = Math.Round(tariff + nad1 + nad2 + nad3,2);
            str.stringPrim = prim;
            return str;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            numerusPeople = 0;
            FIORuc = "";
            //Запрос для таблицы
            IQueryable<STR_SHTAT_RASP> query = model.STR_SHTAT_RASP;
            
            
            
            //Запрос для заполнения полей номер документа и дата составления
            IQueryable<SHTAT_RASP> query1 = model.SHTAT_RASP;
            
            //Заполняем список для таблицы
            foreach (STR_SHTAT_RASP strShtatRasp in query)
            {
                strginShtatRasps.Add(setDataInString(new StringShtatRasp(), Convert.ToInt32(strShtatRasp.PK_STROKA),strShtatRasp.PODRAZDELORG.NAME,
                    strShtatRasp.PODRAZDELORG.CODE, strShtatRasp.JOB_POSITION.NAME, strShtatRasp.COUNT_STUFF.ToString(),
                    Convert.ToDouble(strShtatRasp.TARIFF), Convert.ToDouble(strShtatRasp.NADBAVKA1),Convert.ToDouble(strShtatRasp.NADBAVKA2),Convert.ToDouble(strShtatRasp.NADBAVKA3),
                    strShtatRasp.NOTE)
                    );
                numerusPeople += Convert.ToInt32(strShtatRasp.COUNT_STUFF);
            }
           */
            
            /*
            //Редачим чтобы нормально/чотко выводилось
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = strginShtatRasps;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 165;
            dataGridView1.Columns[4].Width = 72;
            dataGridView1.Columns[5].Width = 85;
            dataGridView1.Columns[6].Width = 92;
            dataGridView1.Columns[7].Width = 92;
            dataGridView1.Columns[8].Width = 92;
            dataGridView1.Columns[9].Width = 151;
            dataGridView1.Columns[10].Width = 145;
            //dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns["stringId"].Visible = false;
            /*
            //Заполняем поля номер документа и дата составления
            numDoc = "";
            _dateTime = new DateTime();
            foreach (SHTAT_RASP ourOrg in query1)
            {
                numDoc = ourOrg.number;
                _dateTime = Convert.ToDateTime(ourOrg.CREATEDATE);
            }

            textBox6.Text = numDoc;
            textBox7.Text = _dateTime.ToString();
            
            //Заполним нэйм организации
            IQueryable<OUR_ORG> query3 = model.OUR_ORG;
            
            List<OUR_ORG> ourOrgs = new List<OUR_ORG>();

            foreach (OUR_ORG ourOrg in query3)
            {
                ourOrgs.Add(ourOrg);
            }

            nameOraganization = ourOrgs[query3.Count() - 1].NAME;
            OKPO = ourOrgs[query3.Count() - 1].OKPO;
            textBox1.Text = nameOraganization;
            textBox3.Text = OKPO;
            textBox27.Text = numerusPeople.ToString();

            IQueryable<PERSONCARD> query4 = model.PERSONCARD;
            query4 = query4.Where(personcard => personcard.JOB_POSITION_PK_JOB_POS == 147);
            List<PERSONCARD> personcards = new List<PERSONCARD>();
            foreach (PERSONCARD personcard in query4)
            {
                personcards.Add(personcard);
            }

            FIORuc = personcards[0].SURNAME + " " + personcards[0].NAME + " " + personcards[0].MIDDLENAME;
            textBox22.Text = FIORuc;
            textBox20.Text = personcards[0].JOB_POSITION.NAME;
            personcards = new List<PERSONCARD>();
            query4 = model.PERSONCARD;
            query4 = query4.Where(personcard => personcard.JOB_POSITION_PK_JOB_POS == 91);
            foreach (PERSONCARD personcard in query4)
            {
                personcards.Add(personcard);
            }

            textBox24.Text = personcards[0].SURNAME + " " + personcards[0].NAME + " " + personcards[0].MIDDLENAME;
            */
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var selectedString = dataGridView1.SelectedRows[0].DataBoundItem as StringShtatRasp;
            Podrazdelenie podrazdelenie = new Podrazdelenie(this);
            podrazdelenie.namePodrazdel.Text = selectedString.stringName;
            IQueryable<PODRAZDELORG> query = model.PODRAZDELORG;
            query = query.Where(podrazdelorg => podrazdelorg.NAME == selectedString.stringName);
            string dataCreate = "";
            foreach (PODRAZDELORG podrazdelorg in query)
            {
                podrazdelenie.podrazdelorg = podrazdelorg;
                dataCreate = podrazdelorg.DATECREATE.ToString();
            }

            podrazdelenie.dataCreate.Text = dataCreate;
            
            podrazdelenie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strginShtatRasps = new List<StringShtatRasp>();
            Application exApp = new Application();
            exApp.Visible = false;
            string PATH_TO_ST = "C:\\Users\\Gerbert\\Documents\\GitHub\\comand_dev\\shtatnoeraspisanie.xlsx";
            Workbook excelappworkbooks;
            try
            {
                excelappworkbooks = exApp.Workbooks.Open(PATH_TO_ST, Type.Missing, true, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }catch (Exception except)
            {
                Console.Error.WriteLine(except.Message);
                MyMsgBox.showError("Не удалось открыть шаблон");
                return;
            }
            if (excelappworkbooks == null) {
                MyMsgBox.showError("Не удалось открыть шаблон");
                return;
            }

            Worksheet excelsheets = excelappworkbooks.Worksheets.Item[1];
            int indexRow = 16;
            for (int i = 0; i < 131; i++)
            {
                strginShtatRasps.Add(setDataInString(new StringShtatRasp(), i+1, 
                    excelsheets.Cells[indexRow,1].Value.ToString(), ((excelsheets.Cells[indexRow,21]).Value ?? string.Empty).ToString(),
                    ((excelsheets.Cells[indexRow,31]).Value ?? string.Empty).ToString(),excelsheets.Cells[indexRow,64].Value.ToString(),
                    Convert.ToDouble((excelsheets.Cells[indexRow,79]).Value ?? string.Empty),Convert.ToDouble((excelsheets.Cells[indexRow,94]).Value ?? string.Empty),
                    Convert.ToDouble((excelsheets.Cells[indexRow,105]).Value ?? string.Empty),Convert.ToDouble((excelsheets.Cells[indexRow,116]).Value ?? string.Empty),""));
                indexRow++;
            }
            excelappworkbooks.Close();
            exApp.Quit();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = strginShtatRasps;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 165;
            dataGridView1.Columns[4].Width = 72;
            dataGridView1.Columns[5].Width = 85;
            dataGridView1.Columns[6].Width = 92;
            dataGridView1.Columns[7].Width = 92;
            dataGridView1.Columns[8].Width = 92;
            dataGridView1.Columns[9].Width = 151;
            dataGridView1.Columns[10].Width = 145;
            //dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns["stringId"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchPodrazdel searchPodrazdel = new SearchPodrazdel();
            searchPodrazdel.Show();
        }
    }
}
