﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Drawing;
  using System.IO;
  using System.Linq;
  using System.Net;
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
        private static Model1 model = new Model1();
        //ПК_Штатки
        private int PK_ST;
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
        //Руководитель кадровой службы
        private string FIORuc;
        
        //Если понадобится добавить новое штатное
        private SHTAT_RASP newShtat = null;
        //Его строки
        private STR_SHTAT_RASP newStr = null;
        //Подразделение -> его ПК
        private Dictionary<string,int> podrazd_pk = new Dictionary<string,int>();
        //Должность -> ПК
        private Dictionary<string,int> dolg_pk = new Dictionary<string, int>();
        
        private Workbook excelappworkbooks;

        private Application exApp;
        private int countShtat;
        private int countShtatRaspAfter;
        
        public Shtatka()
        {
            InitializeComponent();
            countShtatRaspAfter = 0;
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
        {
            
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

            podrazdelenie.keyST = PK_ST;
            podrazdelenie.dataCreate.Text = dataCreate;
            podrazdelenie.Show();
        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            exApp = new Application();
            exApp.Visible = false;
            string PATH_TO_SHTATKA = "Shtatnoe\\shtatnoeraspisanie.xls";
            if (!Directory.Exists("Shtatnoe"))
                Directory.CreateDirectory("Shtatnoe");
            if (!File.Exists(PATH_TO_SHTATKA))
            {
                new WebClient().DownloadFile(new Uri("https://github.com/Th3Ch3shir3Cat/comand_dev/raw/master/shtatnoeraspisanie.xls"), PATH_TO_SHTATKA);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "Shtatnoe\\";
            openFileDialog.RestoreDirectory = true;
            var filePath = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            
            try
            {
                excelappworkbooks = exApp.Workbooks.Open(filePath, Type.Missing, true, Type.Missing, Type.Missing,
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

            await Run();
            
            
            if (countShtatRaspAfter == 0)
            {
                var result = MessageBox.Show("Желаете добавить?","Такого документа нет в базе",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    IQueryable<STR_SHTAT_RASP> queryForStrShtatRasp = model.STR_SHTAT_RASP;
                    int countStrInST = queryForStrShtatRasp.Count()+2;
                    MessageBox.Show(" Строк в штатке" + countStrInST);
                    newShtat = new SHTAT_RASP();
                    newShtat.PK_SHTAT_RASP = countShtat+1;
                    newShtat.number = numberDoc.Text;
                    newShtat.CREATEDATE = DateTime.Parse(dataCreate.Text);
                    model.SHTAT_RASP.Add(newShtat);
                    model.SaveChanges();
                    IQueryable<PODRAZDELORG> queryForPodr = model.PODRAZDELORG;
                    foreach (PODRAZDELORG podrazdelorg in queryForPodr)
                    {
                        if(!podrazdelorg.NAME.Equals("Наименование органа управления / структурного подразделения"))
                        try
                        {
                            podrazd_pk.Add(podrazdelorg.NAME, Convert.ToInt32(podrazdelorg.PK_PODRAZDEL));
                        }
                        catch (ArgumentException)
                        {
                        }
                    }

                    IQueryable<JOB_POSITION> queryForJob = model.JOB_POSITION;
                    foreach (JOB_POSITION job in queryForJob)
                    {
                        try
                        {
                            dolg_pk.Add(job.NAME, Convert.ToInt32(job.PK_JOB_POS));
                        }
                        catch (ArgumentException)
                        {
                        }
                    }
                    for (int i = 0; i < strginShtatRasps.Count(); i++)
                    {
                        newStr = new STR_SHTAT_RASP();
                        newStr.PK_STROKA = countStrInST++;
                        try
                        {
                            newStr.PK_PODRAZDEL = Convert.ToInt32(podrazd_pk[strginShtatRasps[i].stringName]);
                        }
                        catch (KeyNotFoundException)
                        {
                            MessageBox.Show("Подразделения " + strginShtatRasps[i].stringName + " не найдено");
                        }

                        try
                        {
                            newStr.PK_JOB_POS = Convert.ToInt32(dolg_pk[strginShtatRasps[i].stringDolgnost]);
                        }catch (KeyNotFoundException)
                        {
                            MessageBox.Show("Подразделения " + strginShtatRasps[i].stringDolgnost + " не найдено");
                        }

                        newStr.COUNT_STUFF = Convert.ToInt32(strginShtatRasps[i].stringKolEd);
                        newStr.TARIFF = Convert.ToInt32(strginShtatRasps[i].stringoklad);
                        newStr.NADBAVKA1 = (Decimal)strginShtatRasps[i].stringNad1;
                        newStr.NADBAVKA2 = (Decimal)strginShtatRasps[i].stringNad2;
                        newStr.NADBAVKA3 = (Decimal)strginShtatRasps[i].stringNad3;
                        newStr.NOTE = strginShtatRasps[i].stringPrim;
                        newStr.SHTAT_RASP_PK_SHTAT_RASP = countShtat + 1;
                        model.STR_SHTAT_RASP.Add(newStr);
                    }
                    model.SaveChanges();
                    MessageBox.Show("Добавленно");
                }
                
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SearchPodrazdel searchPodrazdel = new SearchPodrazdel(this);
            searchPodrazdel.keySt = PK_ST;
            searchPodrazdel.Show();
        }

        private async Task Run()
        {
            var form = new Donloading();
            form.Show();
            strginShtatRasps = new List<StringShtatRasp>();
             Worksheet excelsheets = excelappworkbooks.Worksheets.Item[1];
            nameOrganization.Text = ((excelsheets.Cells[5, 1]).Value ?? string.Empty).ToString();
            numberDoc.Text = ((excelsheets.Cells[9, 69]).Value ?? string.Empty).ToString();
            dataCreate.Text = ((excelsheets.Cells[9, 87]).Value ?? string.Empty).ToString();
            period.Text = ((excelsheets.Cells[11, 36]).Value ?? string.Empty).ToString();
            day.Text = ((excelsheets.Cells[11, 52]).Value ?? string.Empty).ToString();
            month.Text = ((excelsheets.Cells[11, 57]).Value ?? string.Empty).ToString();
            year.Text = ((excelsheets.Cells[11, 69]).Value ?? string.Empty).ToString();
            textBox22.Text = ((excelsheets.Cells[5, 152]).Value ?? string.Empty).ToString();
            textBox25.Text = ((excelsheets.Cells[9, 87]).Value ?? string.Empty).ToString();
            mainDolgnost.Text = ((excelsheets.Cells[151, 36]).Value ?? string.Empty).ToString();
            rashPodpis.Text = ((excelsheets.Cells[151, 109]).Value ?? string.Empty).ToString();
            rashPodBuh.Text = ((excelsheets.Cells[154, 62]).Value ?? string.Empty).ToString();
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
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns["stringId"].Visible = false;
            
            IQueryable<SHTAT_RASP> query = model.SHTAT_RASP;
            countShtat = query.Count();
            query = query.Where(rasp => rasp.number == numberDoc.Text);
            countShtatRaspAfter = query.Count();
            if (countShtatRaspAfter != 0)
            {
                foreach (SHTAT_RASP shtat in query)
                {
                    PK_ST = Convert.ToInt32(shtat.PK_SHTAT_RASP);
                }
            }
            form.Close();
            MessageBox.Show("Данные загружены","", MessageBoxButtons.OK);
        }
        
    }
}
