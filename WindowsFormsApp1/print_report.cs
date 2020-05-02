﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
	public partial class print_report : Form
	{
		public print_report()
		{
			InitializeComponent();
			initCatalogs();
		}

		private void initCatalogs()
		{
			Model1 model = new Model1();
			String[] sorted_surname = model.PERSONCARD.OrderBy(p => p.SURNAME).Select(p => p.SURNAME).Distinct().ToArray();
			String[] sorted_name = model.PERSONCARD.OrderBy(p => p.NAME).Select(p => p.NAME).Distinct().ToArray();
			String[] sorted_middlename = model.PERSONCARD.OrderBy(p => p.MIDDLENAME).Select(p => p.MIDDLENAME).Distinct().ToArray();
			comboBox_surnameValue.Items.AddRange(sorted_surname);
			comboBox_nameValue.Items.AddRange(sorted_name);
			comboBox_middlenameValue.Items.AddRange(sorted_middlename);
		}
		
		private void button_run_Click(object sender, EventArgs e)
		{
			using (StreamWriter writer = new StreamWriter(File.Create(Path.Combine(System.IO.Directory.GetCurrentDirectory(), "report.txt"))))
			{
				Model1 model = new Model1();
				writer.WriteLine("Общество с ограниченной ответственностью {0}", model.OUR_ORG.FirstOrDefault().NAME);
				writer.WriteLine(model.OUR_ORG.FirstOrDefault().ADDRESS);
				writer.WriteLine("тел. 8(822)13-80-22");
				writer.WriteLine("ИНН {0}, ОГРН {1}\n", model.OUR_ORG.FirstOrDefault().INN, model.OUR_ORG.FirstOrDefault().OGRN);
				writer.WriteLine("от {0}г.", DateTime.Now.ToString().Substring(0, 10)); //todo дату в текущий момент времени
				writer.WriteLine("СПРАВКА");
				PERSONCARD finded = model.PERSONCARD.FirstOrDefault(p => (p.NAME == comboBox_nameValue.Text &&
						p.SURNAME == comboBox_surnameValue.Text &&
							p.MIDDLENAME == comboBox_middlenameValue.Text));
				if (finded == null)
					MessageBox.Show("Сотрудник с указанными ФИО не найден!");
				else
				{
					STR_SHTAT_RASP some_tariff = model.STR_SHTAT_RASP.Where(p => p.PK_PODRAZDEL == finded.TABEL.PK_PODRAZDEL).FirstOrDefault();
					Decimal? end_tariff = some_tariff.TARIFF + some_tariff.NADBAVKA1;
					//Decimal? some_stub = finded.TABEL.PK_PODRAZDEL;
					writer.Write("{0} {1} {2}, {3} г.р., ", finded.SURNAME, finded.NAME, finded.MIDDLENAME, finded.BIRTHDATE.ToString().Substring(0, 10));
					writer.WriteLine("работает в ООО {0} в должности ", model.OUR_ORG.FirstOrDefault().NAME);
					writer.WriteLine("{0} с {1} г. ", finded.JOB_POSITION.NAME, finded.DATECREATE.ToString().Substring(0, 10));
					writer.Write("по настоящее время, имеет оклад {0} рублей в месяц.", end_tariff);
					//writer.Write("по настоящее время, имеет оклад {0} рублей в месяц. {1}", end_tariff, some_stub);
					MessageBox.Show("Справка создана!");
					writer.Close();
				}
				using (FileStream fs = File.OpenRead(Path.Combine(Directory.GetCurrentDirectory(), "report.txt")))
				{
					PrintForm ownedForm = new PrintForm();
					ownedForm.Show();
				}

			}
		}

		private void print_report_Load(object sender, EventArgs e)
		{

		}
	}
}
