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

        private bool compare(String value, String cmp, String target)
        {
            switch (cmp)
            {
                case "=":
                    return value == target;
                case "!=":
                    return value != target;
                case ">":
                    return value.CompareTo(target) > 0;
                case ">=":
                    return value.CompareTo(target) >= 0;
                case "<":
                    return value.CompareTo(target) < 0;
                case "<=":
                    return value.CompareTo(target) <= 0;
                default:
                    return false;
            }
        }

        private bool compare(int value, String cmp, int target)
        {
            switch (cmp)
            {
                case "=":
                    return value == target;
                case "!=":
                    return value != target;
                case ">":
                    return value > target;
                case ">=":
                    return value >= target;
                case "<":
                    return value < target;
                case "<=":
                    return value <= target;
                default:
                    return false;
            }
        }

        private bool compare(DateTime value, String cmp, DateTime target)
        {
            switch (cmp)
            {
                case "=":
                    return value == target;
                case "!=":
                    return value != target;
                case ">":
                    return value > target;
                case ">=":
                    return value >= target;
                case "<":
                    return value < target;
                case "<=":
                    return value <= target;
                default:
                    return false;
            }
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
                }
                /*resultSet = resultSet.Where(card => 
                    compare(card.NAME, comboBox_nameCmp.Text, textBox_nameValue.Text));*/
            }

            if (checkBox_secondNameQuery.Checked)
            {
                resultSet = resultSet.Where(card => 
                    compare(card.SURNAME, comboBox_secondNameCmp.Text, textBox_secondNameValue.Text));
            }

            if (checkBox_middleNameQuery.Checked)
            {
                resultSet = resultSet.Where(card => 
                    compare(card.MIDDLENAME, comboBox_middleNameCmp.Text, textBox_middleNameValue.Text));
            }

            if (checkBox_genderQuery.Checked)
            {
                resultSet = resultSet.Where(card => 
                    compare(card.GENDER.NAME, comboBox_genderCmp.Text, comboBox_genderValue.Text));
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