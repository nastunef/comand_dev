using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Objects.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SearchPersonCard : Form
    {
        public SearchPersonCard()
        {
            InitializeComponent();
            initCatalogs();

            comboBox_birthCmp.SelectedIndex = 0;
            comboBox_eduCmp.SelectedIndex = 0;
            comboBox_genderCmp.SelectedIndex = 0;
            comboBox_grazdanCmp.SelectedIndex = 0;
            comboBox_innCmp.SelectedIndex = 0;
            comboBox_maritalCmp.SelectedIndex = 0;
            comboBox_mobtelCmp.SelectedIndex = 0;
            comboBox_nameCmp.SelectedIndex = 0;
            comboBox_middleNameCmp.SelectedIndex = 0;
            comboBox_secondNameCmp.SelectedIndex = 0;
            comboBox_professionCmp.SelectedIndex = 0;
            comboBox_tabelnumCmp.SelectedIndex = 0;
            comboBox_typeworkCmp.SelectedIndex = 0;
            comboBox_snilsCmp.SelectedIndex = 0;
            comboBox_uvalCmp.SelectedIndex = 0;
        }

        private void initCatalogs()
        {
            Model1 model = new Model1();
            comboBox_genderValue.Items.AddRange(model.GENDER.Select(g => g.NAME).ToArray());
			comboBox_maritalValue.Items.AddRange(model.MARTIAL_STATUS.Select(m => m.NAME).ToArray());
			comboBox_typeworkValue.Items.AddRange(model.TYPE_WORK.Select(w => w.NAME).ToArray());
			comboBox_eduValue.Items.AddRange(model.PLACE_EDU.Select(e => e.NAME).ToArray());
        }

        private void find()
        {
            Model1 model1 = new Model1();
            var resultSet = model1.PERSONCARD.Where(personcard => true);

            if (checkBox_nameQuery.Checked)
            {
                switch (comboBox_nameCmp.Text)
                {
                    case "=":
                        resultSet = resultSet.Where(card => 
                            card.NAME == textBox_nameValue.Text);
                        break;
                    case "!=":
                        resultSet = resultSet.Where(card => 
                            card.NAME != textBox_nameValue.Text);
                        break;
                    case ">":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.NAME, textBox_nameValue.Text, StringComparison.Ordinal) > 0);
                        break;
                    case ">=":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.NAME, textBox_nameValue.Text, StringComparison.Ordinal) >= 0);
                        break;
                    case "<":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.NAME, textBox_nameValue.Text, StringComparison.Ordinal) < 0);
                        break;
                    case "<=":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.NAME, textBox_nameValue.Text, StringComparison.Ordinal) <= 0);
                        break;
                }
                /*resultSet = resultSet.Where(card => 
                    compare(card.NAME, comboBox_nameCmp.Text, textBox_nameValue.Text));*/
            }

            if (checkBox_secondNameQuery.Checked)
            {
                switch (comboBox_secondNameCmp.Text)
                {
                    case "=":
                        resultSet = resultSet.Where(card => 
                            card.SURNAME == textBox_secondNameValue.Text);
                        break;
                    case "!=":
                        resultSet = resultSet.Where(card => 
                            card.SURNAME != textBox_secondNameValue.Text);
                        break;
                    case ">":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.SURNAME, textBox_secondNameValue.Text, StringComparison.Ordinal) > 0);
                        break;
                    case ">=":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.SURNAME, textBox_secondNameValue.Text, StringComparison.Ordinal) >= 0);
                        break;
                    case "<":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.SURNAME, textBox_secondNameValue.Text, StringComparison.Ordinal) < 0);
                        break;
                    case "<=":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.SURNAME, textBox_secondNameValue.Text, StringComparison.Ordinal) <= 0);
                        break;
                }
                /*resultSet = resultSet.Where(card => 
                    compare(card.SURNAME, comboBox_secondNameCmp.Text, textBox_secondNameValue.Text));*/
            }

            if (checkBox_middleNameQuery.Checked)
            {
                switch (comboBox_middleNameCmp.Text)
                {
                    case "=":
                        resultSet = resultSet.Where(card => 
                            card.MIDDLENAME == textBox_middleNameValue.Text);
                        break;
                    case "!=":
                        resultSet = resultSet.Where(card => 
                            card.MIDDLENAME != textBox_middleNameValue.Text);
                        break;
                    case ">":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.MIDDLENAME, textBox_middleNameValue.Text, StringComparison.Ordinal) > 0);
                        break;
                    case ">=":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.MIDDLENAME, textBox_middleNameValue.Text, StringComparison.Ordinal) >= 0);
                        break;
                    case "<":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.MIDDLENAME, textBox_middleNameValue.Text, StringComparison.Ordinal) < 0);
                        break;
                    case "<=":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.MIDDLENAME, textBox_middleNameValue.Text, StringComparison.Ordinal) <= 0);
                        break;
                }
                /*resultSet = resultSet.Where(card => 
                    compare(card.MIDDLENAME, comboBox_middleNameCmp.Text, textBox_middleNameValue.Text));*/
            }

            if (checkBox_genderQuery.Checked)
            {
                switch (comboBox_genderCmp.Text)
                {
                    case "=":
                        resultSet = resultSet.Where(card => 
                            card.GENDER.NAME == comboBox_genderValue.Text);
                        break;
                    case "!=":
                        resultSet = resultSet.Where(card => 
                            card.GENDER.NAME != comboBox_genderValue.Text);
                        break;
                    case ">":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.GENDER.NAME, comboBox_genderValue.Text, StringComparison.Ordinal) > 0);
                        break;
                    case ">=":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.GENDER.NAME, comboBox_genderValue.Text, StringComparison.Ordinal) >= 0);
                        break;
                    case "<":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.GENDER.NAME, comboBox_genderValue.Text, StringComparison.Ordinal) < 0);
                        break;
                    case "<=":
                        resultSet = resultSet.Where(card => 
                            String.Compare(card.GENDER.NAME, comboBox_genderValue.Text, StringComparison.Ordinal) <= 0);
                        break;
                }
                /*resultSet = resultSet.Where(card => 
                    compare(card.GENDER.NAME, comboBox_genderCmp.Text, comboBox_genderValue.Text));*/
            }

			if (checkBox_grazdanQuery.Checked)
			{
				switch (comboBox_grazdanCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.GRAZDAN.NAME == textBox_grazdanValue.Text);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.GRAZDAN.NAME != textBox_grazdanValue.Text);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							String.Compare(card.GRAZDAN.NAME, textBox_grazdanValue.Text, StringComparison.Ordinal) > 0);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.GRAZDAN.NAME, textBox_grazdanValue.Text, StringComparison.Ordinal) >= 0);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							String.Compare(card.GRAZDAN.NAME, textBox_grazdanValue.Text, StringComparison.Ordinal) < 0);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.GRAZDAN.NAME, textBox_grazdanValue.Text, StringComparison.Ordinal) <= 0);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.GRAZDAN.NAME, comboBox_grazdanCmp.Text, textBox_grazdanValue.Text));*/
			}

			if (checkBox_mobtelQuery.Checked)
			{
				switch (comboBox_mobtelCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.MOBTEL == textBox_mobtelValue.Text);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.MOBTEL != textBox_mobtelValue.Text);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							String.Compare(card.MOBTEL, textBox_mobtelValue.Text, StringComparison.Ordinal) > 0);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.MOBTEL, textBox_mobtelValue.Text, StringComparison.Ordinal) >= 0);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							String.Compare(card.MOBTEL, textBox_mobtelValue.Text, StringComparison.Ordinal) < 0);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.MOBTEL, textBox_mobtelValue.Text, StringComparison.Ordinal) <= 0);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.MOBTEL, comboBox_mobtelCmp.Text, textBox_mobtelValue.Text));*/
			}

			if (checkBox_professionQuery.Checked)
			{
				switch (comboBox_professionCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.PROFESSION.NAME == textBox_professionValue.Text);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.PROFESSION.NAME != textBox_professionValue.Text);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							String.Compare(card.PROFESSION.NAME, textBox_professionValue.Text, StringComparison.Ordinal) > 0);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.PROFESSION.NAME, textBox_professionValue.Text, StringComparison.Ordinal) >= 0);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							String.Compare(card.PROFESSION.NAME, textBox_professionValue.Text, StringComparison.Ordinal) < 0);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.PROFESSION.NAME, textBox_professionValue.Text, StringComparison.Ordinal) <= 0);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.PROFESSION.NAME, comboBox_professionCmp.Text, textBox_professionValue.Text));*/
			}

			if (checkBox_innQuery.Checked)
			{
				switch (comboBox_innCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.INN == textBox_innValue.Text);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.INN != textBox_innValue.Text);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							String.Compare(card.INN, textBox_innValue.Text, StringComparison.Ordinal) > 0);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.INN, textBox_innValue.Text, StringComparison.Ordinal) >= 0);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							String.Compare(card.INN, textBox_innValue.Text, StringComparison.Ordinal) < 0);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.INN, textBox_innValue.Text, StringComparison.Ordinal) <= 0);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.INN, comboBox_innCmp.Text, textBox_innValue.Text));*/
			}

			if (checkBox_snilsQuery.Checked)
			{
				switch (comboBox_snilsCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.SNILS == textBox_snilsValue.Text);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.SNILS != textBox_snilsValue.Text);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							String.Compare(card.SNILS, textBox_snilsValue.Text, StringComparison.Ordinal) > 0);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.SNILS, textBox_snilsValue.Text, StringComparison.Ordinal) >= 0);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							String.Compare(card.SNILS, textBox_snilsValue.Text, StringComparison.Ordinal) < 0);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.SNILS, textBox_snilsValue.Text, StringComparison.Ordinal) <= 0);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.SNILS, comboBox_snilsCmp.Text, textBox_snilsValue.Text));*/
			}

			if (checkBox_maritalQuery.Checked)
			{
				switch (comboBox_maritalCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.MARTIAL_STATUS.NAME == comboBox_maritalValue.Text);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.MARTIAL_STATUS.NAME != comboBox_maritalValue.Text);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							String.Compare(card.MARTIAL_STATUS.NAME, comboBox_maritalValue.Text, StringComparison.Ordinal) > 0);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.MARTIAL_STATUS.NAME, comboBox_maritalValue.Text, StringComparison.Ordinal) >= 0);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							String.Compare(card.MARTIAL_STATUS.NAME, comboBox_maritalValue.Text, StringComparison.Ordinal) < 0);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.MARTIAL_STATUS.NAME, comboBox_maritalValue.Text, StringComparison.Ordinal) <= 0);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.MARTIAL_STATUS.NAME, comboBox_maritalCmp.Text, comboBox_maritalValue.Text));*/
			}
			
			if (checkBox_tabelnumQuery.Checked)
			{
				Decimal tabelNumVal = Convert.ToDecimal(textBox_tabelnumValue.Text);
				switch (comboBox_tabelnumCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.TABEL_NUM == tabelNumVal);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.TABEL_NUM != tabelNumVal);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							card.TABEL_NUM >  tabelNumVal);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							card.TABEL_NUM >=  tabelNumVal);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							card.TABEL_NUM < tabelNumVal);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							card.TABEL_NUM <= tabelNumVal);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(SqlFunctions.StringConvert(card.TABEL_NUM.Value), comboBox_tabelnumCmp.Text, textBox_tabelnumValue.Text));*/
			}

			if (checkBox_uvalQuery.Checked)
			{
				switch (comboBox_uvalCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.REASON_UVAL == textBox_uvalValue.Text);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.REASON_UVAL != textBox_uvalValue.Text);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							String.Compare(card.REASON_UVAL, textBox_uvalValue.Text, StringComparison.Ordinal) > 0);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.REASON_UVAL, textBox_uvalValue.Text, StringComparison.Ordinal) >= 0);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							String.Compare(card.REASON_UVAL, textBox_uvalValue.Text, StringComparison.Ordinal) < 0);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.REASON_UVAL, textBox_uvalValue.Text, StringComparison.Ordinal) <= 0);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.REASON_UVAL, comboBox_uvalCmp.Text, textBox_uvalValue.Text));*/
			}

			if (checkBox_typeworkQuery.Checked)
			{
				switch (comboBox_typeworkCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.TYPE_WORK.NAME == comboBox_typeworkValue.Text);
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.TYPE_WORK.NAME != comboBox_typeworkValue.Text);
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							String.Compare(card.TYPE_WORK.NAME, comboBox_typeworkValue.Text, StringComparison.Ordinal) > 0);
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.TYPE_WORK.NAME, comboBox_typeworkValue.Text, StringComparison.Ordinal) >= 0);
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							String.Compare(card.TYPE_WORK.NAME, comboBox_typeworkValue.Text, StringComparison.Ordinal) < 0);
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							String.Compare(card.TYPE_WORK.NAME, comboBox_typeworkValue.Text, StringComparison.Ordinal) <= 0);
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.TYPE_WORK.NAME, comboBox_typeworkCmp.Text, comboBox_typeworkValue.Text));*/
			}

			if (checkBox_birthQuery.Checked)
			{
				switch (comboBox_birthCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.BIRTHDATE == DbFunctions.TruncateTime(dateTimePicker_birthValue.Value));
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.BIRTHDATE != DbFunctions.TruncateTime(dateTimePicker_birthValue.Value));
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							card.BIRTHDATE > DbFunctions.TruncateTime(dateTimePicker_birthValue.Value));
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							card.BIRTHDATE >= DbFunctions.TruncateTime(dateTimePicker_birthValue.Value));
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							card.BIRTHDATE < DbFunctions.TruncateTime(dateTimePicker_birthValue.Value));
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							card.BIRTHDATE <= DbFunctions.TruncateTime(dateTimePicker_birthValue.Value));
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card.BIRTHDATE, comboBox_birthCmp.Text, DbFunctions.TruncateTime(Convert.ToDateTime(textBox_birthValue.Text))););*/
			}

			if (checkBox_eduQuery.Checked)
			{
				switch (comboBox_eduCmp.Text)
				{
					case "=":
						resultSet = resultSet.Where(card =>
							card.ONE_EDU.Any(edu => edu.PLACE_EDU.NAME == comboBox_eduValue.Text));
						break;
					case "!=":
						resultSet = resultSet.Where(card =>
							card.ONE_EDU.Any(edu => edu.PLACE_EDU.NAME != comboBox_eduValue.Text));
						break;
					case ">":
						resultSet = resultSet.Where(card =>
							card.ONE_EDU.Any(edu => String.Compare(edu.PLACE_EDU.NAME, comboBox_eduValue.Text, StringComparison.Ordinal) > 0));
						break;
					case ">=":
						resultSet = resultSet.Where(card =>
							card.ONE_EDU.Any(edu => String.Compare(edu.PLACE_EDU.NAME, comboBox_eduValue.Text, StringComparison.Ordinal) >= 0));
						break;
					case "<":
						resultSet = resultSet.Where(card =>
							card.ONE_EDU.Any(edu => String.Compare(edu.PLACE_EDU.NAME, comboBox_eduValue.Text, StringComparison.Ordinal) < 0));
						break;
					case "<=":
						resultSet = resultSet.Where(card =>
							card.ONE_EDU.Any(edu => String.Compare(edu.PLACE_EDU.NAME, comboBox_eduValue.Text, StringComparison.Ordinal) <= 0));
						break;
				}
				/*resultSet = resultSet.Where(card => 
					compare(card., comboBox_eduCmp.Text, comboBox_eduValue.Text));*/
			}

			if (textBox_innValue.TextLength != 12 && textBox_innValue.TextLength != 0)
			{
				MessageBox.Show("ИНН должен содержать ровно 12 цифр!");
				textBox_innValue.Focus();
				return;
			}

			if (textBox_snilsValue.TextLength != 11 && textBox_snilsValue.TextLength != 0)
			{
				MessageBox.Show("СНИЛС должен содержать ровно 11 цифр!");
				textBox_snilsValue.Focus();
				return;
			}

			printResult(resultSet);
        }

        private DataGridViewColumn createColumn(String name)
        {
            var column = new DataGridViewTextBoxColumn();
            column.ReadOnly = true;
            column.HeaderText = name;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            return column;
        }
        
        private DataGridViewColumn createHidenColumn()
        {
	        var column = new DataGridViewTextBoxColumn();
	        column.ReadOnly = true;
	        column.Visible = false;
	        return column;
        }

        private void printResult(IQueryable<PERSONCARD> resultSet)
        {
            dataGridView_result.Columns.Clear();
            label_resultCount.Text = resultSet.Count().ToString();
            List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
			bool isChecked = false;
			
			columns.Add(createHidenColumn());
			
            if (checkBox_nameResult.Checked)
            {
				isChecked = true;
                columns.Add(createColumn("Имя"));
            }

            if (checkBox_secondNameResult.Checked)
            {
				isChecked = true;
                columns.Add(createColumn("Фамилия"));
            }

            if (checkBox_middleNameResult.Checked)
            {
				isChecked = true;
                columns.Add(createColumn("Отчество"));
            }

            if (checkBox_genderResult.Checked)
            {
				isChecked = true;
                columns.Add(createColumn("Пол"));
            }

			if (checkBox_grazdanResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Гражданство"));
			}

			if (checkBox_mobtelResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Телефон"));
			}

			if (checkBox_professionResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Профессия"));
			}

			if (checkBox_innResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("ИНН"));
			}

			if (checkBox_snilsResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("СНИЛС"));
			}

			if (checkBox_maritalResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Семейный статус"));
			}

			if (checkBox_tabelnumResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Табельный номер"));
			}

			if (checkBox_uvalResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Причина увольнения"));
			}

			if (checkBox_typeworkResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Тип работы"));
			}

			if (checkBox_birthResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Дата рождения"));
			}

			if (checkBox_eduResult.Checked)
			{
				isChecked = true;
				columns.Add(createColumn("Место образования"));
			}

			if (!isChecked)
			{
				MessageBox.Show("Необходимо использовать в результате хотя бы одно поле!");
				return;
			}

			dataGridView_result.Columns.AddRange(columns.ToArray());

            foreach (var row in resultSet)
            {
                List<object> rowValues = new List<object>();

                rowValues.Add(row.PK_PERSONCARD);
                
                if (checkBox_nameResult.Checked)
                {
                    rowValues.Add(row.NAME);
                }

                if (checkBox_secondNameResult.Checked)
                {
                    rowValues.Add(row.SURNAME);
                }

                if (checkBox_middleNameResult.Checked)
                {
                    rowValues.Add(row.MIDDLENAME);
                }

                if (checkBox_genderResult.Checked)
                {
                    rowValues.Add(row.GENDER.NAME);
                }

				if (checkBox_grazdanResult.Checked)
				{
					rowValues.Add(row.GRAZDAN.NAME);
				}

				if (checkBox_mobtelResult.Checked)
				{
					rowValues.Add(row.MOBTEL);
				}

				if (checkBox_professionResult.Checked)
				{
					rowValues.Add(row.PROFESSION.NAME);
				}

				if (checkBox_innResult.Checked)
				{
					rowValues.Add(row.INN);
				}

				if (checkBox_snilsResult.Checked)
				{
					rowValues.Add(row.SNILS);
				}

				if (checkBox_maritalResult.Checked)
				{
					rowValues.Add(row.MARTIAL_STATUS.NAME);
				}

				if (checkBox_tabelnumResult.Checked)
				{
					rowValues.Add(row.TABEL_NUM);
				}

				if (checkBox_uvalResult.Checked)
				{
					rowValues.Add(row.REASON_UVAL);
				}

				if (checkBox_typeworkResult.Checked)
				{
					rowValues.Add(row.TYPE_WORK.NAME);
				}

				if (checkBox_birthResult.Checked)
				{
					rowValues.Add(row.BIRTHDATE);
				}

				if (checkBox_eduResult.Checked)
				{
					String result = "";
					foreach (var edu in row.ONE_EDU)
					{
						result += edu.PLACE_EDU.NAME + "\n";
					}
					rowValues.Add(result);
				}

                dataGridView_result.Rows.Add(rowValues.ToArray());
            }
        }


        private void button_run_Click(object sender, EventArgs e)
        {
            find();
        }

		private void textBox_innValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
			{
				e.Handled = true;
			}
		}

		private void textBox_snilsValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
			{
				e.Handled = true;
			}
		}

		private void dataGridView_result_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = dataGridView_result.Rows[e.RowIndex];
			decimal pk = Convert.ToDecimal(row.Cells[0].Value);
			
			Form personalCard = new PersonalCard(pk);
			personalCard.Show();
			
		}
    }
}