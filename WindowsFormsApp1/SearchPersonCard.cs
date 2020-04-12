using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchPersonCard : Form
    {
        public SearchPersonCard()
        {
            InitializeComponent();
            initCatalogs();
        }

        private void initCatalogs()
        {
            Model1 model = new Model1();
            comboBox_genderValue.Items.AddRange(model.GENDER.Select(g => g.NAME).ToArray());
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

            printResult(resultSet);
        }

        private DataGridViewColumn createColumn(String name)
        {
            var column = new DataGridViewTextBoxColumn();
            column.ReadOnly = true;
            column.HeaderText = name;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return column;
        }

        private void printResult(IQueryable<PERSONCARD> resultSet)
        {
            dataGridView_result.Columns.Clear();
            label_resultCount.Text = resultSet.Count().ToString();
            List<DataGridViewColumn> columns = new List<DataGridViewColumn>();

            if (checkBox_nameResult.Checked)
            {
                columns.Add(createColumn("Имя"));
            }

            if (checkBox_secondNameResult.Checked)
            {
                columns.Add(createColumn("Фамилия"));
            }

            if (checkBox_middleNameResult.Checked)
            {
                columns.Add(createColumn("Отчество"));
            }

            if (checkBox_genderResult.Checked)
            {
                columns.Add(createColumn("Пол"));
            }

            dataGridView_result.Columns.AddRange(columns.ToArray());

            foreach (var row in resultSet)
            {
                List<object> rowValues = new List<object>();

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

                dataGridView_result.Rows.Add(rowValues.ToArray());
            }
        }


        private void button_run_Click(object sender, EventArgs e)
        {
            find();
        }
    }
}