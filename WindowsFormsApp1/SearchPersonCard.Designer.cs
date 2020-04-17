using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class SearchPersonCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
	        this.panel1 = new System.Windows.Forms.Panel();
	        this.comboBox_eduValue = new System.Windows.Forms.ComboBox();
	        this.dateTimePicker_birthValue = new System.Windows.Forms.DateTimePicker();
	        this.comboBox_eduCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_eduQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_eduResult = new System.Windows.Forms.CheckBox();
	        this.label21 = new System.Windows.Forms.Label();
	        this.comboBox_birthCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_birthQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_birthResult = new System.Windows.Forms.CheckBox();
	        this.label20 = new System.Windows.Forms.Label();
	        this.comboBox_typeworkValue = new System.Windows.Forms.ComboBox();
	        this.comboBox_typeworkCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_typeworkQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_typeworkResult = new System.Windows.Forms.CheckBox();
	        this.label19 = new System.Windows.Forms.Label();
	        this.textBox_uvalValue = new System.Windows.Forms.TextBox();
	        this.comboBox_uvalCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_uvalQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_uvalResult = new System.Windows.Forms.CheckBox();
	        this.label18 = new System.Windows.Forms.Label();
	        this.textBox_tabelnumValue = new System.Windows.Forms.TextBox();
	        this.comboBox_tabelnumCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_tabelnumQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_tabelnumResult = new System.Windows.Forms.CheckBox();
	        this.label17 = new System.Windows.Forms.Label();
	        this.comboBox_maritalValue = new System.Windows.Forms.ComboBox();
	        this.comboBox_maritalCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_maritalQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_maritalResult = new System.Windows.Forms.CheckBox();
	        this.label16 = new System.Windows.Forms.Label();
	        this.textBox_professionValue = new System.Windows.Forms.TextBox();
	        this.textBox_innValue = new System.Windows.Forms.TextBox();
	        this.textBox_snilsValue = new System.Windows.Forms.TextBox();
	        this.comboBox_professionCmp = new System.Windows.Forms.ComboBox();
	        this.comboBox_innCmp = new System.Windows.Forms.ComboBox();
	        this.comboBox_snilsCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_professionResult = new System.Windows.Forms.CheckBox();
	        this.checkBox_innResult = new System.Windows.Forms.CheckBox();
	        this.checkBox_snilsResult = new System.Windows.Forms.CheckBox();
	        this.checkBox_professionQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_innQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_snilsQuery = new System.Windows.Forms.CheckBox();
	        this.label15 = new System.Windows.Forms.Label();
	        this.label14 = new System.Windows.Forms.Label();
	        this.label13 = new System.Windows.Forms.Label();
	        this.textBox_mobtelValue = new System.Windows.Forms.TextBox();
	        this.textBox_grazdanValue = new System.Windows.Forms.TextBox();
	        this.comboBox_mobtelCmp = new System.Windows.Forms.ComboBox();
	        this.comboBox_grazdanCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_mobtelQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_grazdanQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_mobtelResult = new System.Windows.Forms.CheckBox();
	        this.checkBox_grazdanResult = new System.Windows.Forms.CheckBox();
	        this.label12 = new System.Windows.Forms.Label();
	        this.label10 = new System.Windows.Forms.Label();
	        this.comboBox_genderValue = new System.Windows.Forms.ComboBox();
	        this.comboBox_genderCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_genderQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_genderResult = new System.Windows.Forms.CheckBox();
	        this.label11 = new System.Windows.Forms.Label();
	        this.textBox_middleNameValue = new System.Windows.Forms.TextBox();
	        this.textBox_nameValue = new System.Windows.Forms.TextBox();
	        this.textBox_secondNameValue = new System.Windows.Forms.TextBox();
	        this.comboBox_middleNameCmp = new System.Windows.Forms.ComboBox();
	        this.comboBox_nameCmp = new System.Windows.Forms.ComboBox();
	        this.comboBox_secondNameCmp = new System.Windows.Forms.ComboBox();
	        this.checkBox_middleNameQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_nameQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_secondNameQuery = new System.Windows.Forms.CheckBox();
	        this.checkBox_middleNameResult = new System.Windows.Forms.CheckBox();
	        this.checkBox_nameResult = new System.Windows.Forms.CheckBox();
	        this.checkBox_secondNameResult = new System.Windows.Forms.CheckBox();
	        this.label8 = new System.Windows.Forms.Label();
	        this.label7 = new System.Windows.Forms.Label();
	        this.label6 = new System.Windows.Forms.Label();
	        this.label5 = new System.Windows.Forms.Label();
	        this.label4 = new System.Windows.Forms.Label();
	        this.label3 = new System.Windows.Forms.Label();
	        this.label2 = new System.Windows.Forms.Label();
	        this.label1 = new System.Windows.Forms.Label();
	        this.panel3 = new System.Windows.Forms.Panel();
	        this.dataGridView_result = new System.Windows.Forms.DataGridView();
	        this.label_resultCount = new System.Windows.Forms.Label();
	        this.label9 = new System.Windows.Forms.Label();
	        this.button_run = new System.Windows.Forms.Button();
	        this.panel1.SuspendLayout();
	        this.panel3.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.dataGridView_result)).BeginInit();
	        this.SuspendLayout();
	        // 
	        // panel1
	        // 
	        this.panel1.AutoScroll = true;
	        this.panel1.Controls.Add(this.comboBox_eduValue);
	        this.panel1.Controls.Add(this.dateTimePicker_birthValue);
	        this.panel1.Controls.Add(this.comboBox_eduCmp);
	        this.panel1.Controls.Add(this.checkBox_eduQuery);
	        this.panel1.Controls.Add(this.checkBox_eduResult);
	        this.panel1.Controls.Add(this.label21);
	        this.panel1.Controls.Add(this.comboBox_birthCmp);
	        this.panel1.Controls.Add(this.checkBox_birthQuery);
	        this.panel1.Controls.Add(this.checkBox_birthResult);
	        this.panel1.Controls.Add(this.label20);
	        this.panel1.Controls.Add(this.comboBox_typeworkValue);
	        this.panel1.Controls.Add(this.comboBox_typeworkCmp);
	        this.panel1.Controls.Add(this.checkBox_typeworkQuery);
	        this.panel1.Controls.Add(this.checkBox_typeworkResult);
	        this.panel1.Controls.Add(this.label19);
	        this.panel1.Controls.Add(this.textBox_uvalValue);
	        this.panel1.Controls.Add(this.comboBox_uvalCmp);
	        this.panel1.Controls.Add(this.checkBox_uvalQuery);
	        this.panel1.Controls.Add(this.checkBox_uvalResult);
	        this.panel1.Controls.Add(this.label18);
	        this.panel1.Controls.Add(this.textBox_tabelnumValue);
	        this.panel1.Controls.Add(this.comboBox_tabelnumCmp);
	        this.panel1.Controls.Add(this.checkBox_tabelnumQuery);
	        this.panel1.Controls.Add(this.checkBox_tabelnumResult);
	        this.panel1.Controls.Add(this.label17);
	        this.panel1.Controls.Add(this.comboBox_maritalValue);
	        this.panel1.Controls.Add(this.comboBox_maritalCmp);
	        this.panel1.Controls.Add(this.checkBox_maritalQuery);
	        this.panel1.Controls.Add(this.checkBox_maritalResult);
	        this.panel1.Controls.Add(this.label16);
	        this.panel1.Controls.Add(this.textBox_professionValue);
	        this.panel1.Controls.Add(this.textBox_innValue);
	        this.panel1.Controls.Add(this.textBox_snilsValue);
	        this.panel1.Controls.Add(this.comboBox_professionCmp);
	        this.panel1.Controls.Add(this.comboBox_innCmp);
	        this.panel1.Controls.Add(this.comboBox_snilsCmp);
	        this.panel1.Controls.Add(this.checkBox_professionResult);
	        this.panel1.Controls.Add(this.checkBox_innResult);
	        this.panel1.Controls.Add(this.checkBox_snilsResult);
	        this.panel1.Controls.Add(this.checkBox_professionQuery);
	        this.panel1.Controls.Add(this.checkBox_innQuery);
	        this.panel1.Controls.Add(this.checkBox_snilsQuery);
	        this.panel1.Controls.Add(this.label15);
	        this.panel1.Controls.Add(this.label14);
	        this.panel1.Controls.Add(this.label13);
	        this.panel1.Controls.Add(this.textBox_mobtelValue);
	        this.panel1.Controls.Add(this.textBox_grazdanValue);
	        this.panel1.Controls.Add(this.comboBox_mobtelCmp);
	        this.panel1.Controls.Add(this.comboBox_grazdanCmp);
	        this.panel1.Controls.Add(this.checkBox_mobtelQuery);
	        this.panel1.Controls.Add(this.checkBox_grazdanQuery);
	        this.panel1.Controls.Add(this.checkBox_mobtelResult);
	        this.panel1.Controls.Add(this.checkBox_grazdanResult);
	        this.panel1.Controls.Add(this.label12);
	        this.panel1.Controls.Add(this.label10);
	        this.panel1.Controls.Add(this.comboBox_genderValue);
	        this.panel1.Controls.Add(this.comboBox_genderCmp);
	        this.panel1.Controls.Add(this.checkBox_genderQuery);
	        this.panel1.Controls.Add(this.checkBox_genderResult);
	        this.panel1.Controls.Add(this.label11);
	        this.panel1.Controls.Add(this.textBox_middleNameValue);
	        this.panel1.Controls.Add(this.textBox_nameValue);
	        this.panel1.Controls.Add(this.textBox_secondNameValue);
	        this.panel1.Controls.Add(this.comboBox_middleNameCmp);
	        this.panel1.Controls.Add(this.comboBox_nameCmp);
	        this.panel1.Controls.Add(this.comboBox_secondNameCmp);
	        this.panel1.Controls.Add(this.checkBox_middleNameQuery);
	        this.panel1.Controls.Add(this.checkBox_nameQuery);
	        this.panel1.Controls.Add(this.checkBox_secondNameQuery);
	        this.panel1.Controls.Add(this.checkBox_middleNameResult);
	        this.panel1.Controls.Add(this.checkBox_nameResult);
	        this.panel1.Controls.Add(this.checkBox_secondNameResult);
	        this.panel1.Controls.Add(this.label8);
	        this.panel1.Controls.Add(this.label7);
	        this.panel1.Controls.Add(this.label6);
	        this.panel1.Controls.Add(this.label5);
	        this.panel1.Controls.Add(this.label4);
	        this.panel1.Controls.Add(this.label3);
	        this.panel1.Controls.Add(this.label2);
	        this.panel1.Controls.Add(this.label1);
	        this.panel1.Location = new System.Drawing.Point(12, 12);
	        this.panel1.Name = "panel1";
	        this.panel1.Size = new System.Drawing.Size(591, 628);
	        this.panel1.TabIndex = 0;
	        // 
	        // comboBox_eduValue
	        // 
	        this.comboBox_eduValue.FormattingEnabled = true;
	        this.comboBox_eduValue.Location = new System.Drawing.Point(416, 488);
	        this.comboBox_eduValue.Name = "comboBox_eduValue";
	        this.comboBox_eduValue.Size = new System.Drawing.Size(165, 23);
	        this.comboBox_eduValue.TabIndex = 82;
	        // 
	        // dateTimePicker_birthValue
	        // 
	        this.dateTimePicker_birthValue.Location = new System.Drawing.Point(416, 448);
	        this.dateTimePicker_birthValue.Name = "dateTimePicker_birthValue";
	        this.dateTimePicker_birthValue.Size = new System.Drawing.Size(165, 23);
	        this.dateTimePicker_birthValue.TabIndex = 81;
	        // 
	        // comboBox_eduCmp
	        // 
	        this.comboBox_eduCmp.FormattingEnabled = true;
	        this.comboBox_eduCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_eduCmp.Location = new System.Drawing.Point(321, 488);
	        this.comboBox_eduCmp.Name = "comboBox_eduCmp";
	        this.comboBox_eduCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_eduCmp.TabIndex = 79;
	        // 
	        // checkBox_eduQuery
	        // 
	        this.checkBox_eduQuery.Location = new System.Drawing.Point(267, 485);
	        this.checkBox_eduQuery.Name = "checkBox_eduQuery";
	        this.checkBox_eduQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_eduQuery.TabIndex = 78;
	        this.checkBox_eduQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_eduResult
	        // 
	        this.checkBox_eduResult.Location = new System.Drawing.Point(133, 488);
	        this.checkBox_eduResult.Name = "checkBox_eduResult";
	        this.checkBox_eduResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_eduResult.TabIndex = 77;
	        this.checkBox_eduResult.UseVisualStyleBackColor = true;
	        // 
	        // label21
	        // 
	        this.label21.Location = new System.Drawing.Point(3, 488);
	        this.label21.Name = "label21";
	        this.label21.Size = new System.Drawing.Size(89, 35);
	        this.label21.TabIndex = 76;
	        this.label21.Text = "Место образования";
	        this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // comboBox_birthCmp
	        // 
	        this.comboBox_birthCmp.FormattingEnabled = true;
	        this.comboBox_birthCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_birthCmp.Location = new System.Drawing.Point(321, 448);
	        this.comboBox_birthCmp.Name = "comboBox_birthCmp";
	        this.comboBox_birthCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_birthCmp.TabIndex = 74;
	        // 
	        // checkBox_birthQuery
	        // 
	        this.checkBox_birthQuery.Location = new System.Drawing.Point(267, 448);
	        this.checkBox_birthQuery.Name = "checkBox_birthQuery";
	        this.checkBox_birthQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_birthQuery.TabIndex = 73;
	        this.checkBox_birthQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_birthResult
	        // 
	        this.checkBox_birthResult.Location = new System.Drawing.Point(133, 448);
	        this.checkBox_birthResult.Name = "checkBox_birthResult";
	        this.checkBox_birthResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_birthResult.TabIndex = 72;
	        this.checkBox_birthResult.UseVisualStyleBackColor = true;
	        // 
	        // label20
	        // 
	        this.label20.Location = new System.Drawing.Point(3, 445);
	        this.label20.Name = "label20";
	        this.label20.Size = new System.Drawing.Size(89, 35);
	        this.label20.TabIndex = 71;
	        this.label20.Text = "Дата рождения";
	        this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // comboBox_typeworkValue
	        // 
	        this.comboBox_typeworkValue.FormattingEnabled = true;
	        this.comboBox_typeworkValue.Location = new System.Drawing.Point(416, 413);
	        this.comboBox_typeworkValue.Name = "comboBox_typeworkValue";
	        this.comboBox_typeworkValue.Size = new System.Drawing.Size(165, 23);
	        this.comboBox_typeworkValue.TabIndex = 70;
	        // 
	        // comboBox_typeworkCmp
	        // 
	        this.comboBox_typeworkCmp.FormattingEnabled = true;
	        this.comboBox_typeworkCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_typeworkCmp.Location = new System.Drawing.Point(321, 413);
	        this.comboBox_typeworkCmp.Name = "comboBox_typeworkCmp";
	        this.comboBox_typeworkCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_typeworkCmp.TabIndex = 69;
	        // 
	        // checkBox_typeworkQuery
	        // 
	        this.checkBox_typeworkQuery.Location = new System.Drawing.Point(267, 413);
	        this.checkBox_typeworkQuery.Name = "checkBox_typeworkQuery";
	        this.checkBox_typeworkQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_typeworkQuery.TabIndex = 68;
	        this.checkBox_typeworkQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_typeworkResult
	        // 
	        this.checkBox_typeworkResult.Location = new System.Drawing.Point(133, 413);
	        this.checkBox_typeworkResult.Name = "checkBox_typeworkResult";
	        this.checkBox_typeworkResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_typeworkResult.TabIndex = 67;
	        this.checkBox_typeworkResult.UseVisualStyleBackColor = true;
	        // 
	        // label19
	        // 
	        this.label19.Location = new System.Drawing.Point(3, 417);
	        this.label19.Name = "label19";
	        this.label19.Size = new System.Drawing.Size(89, 23);
	        this.label19.TabIndex = 66;
	        this.label19.Text = "Тип работы";
	        this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // textBox_uvalValue
	        // 
	        this.textBox_uvalValue.Location = new System.Drawing.Point(416, 378);
	        this.textBox_uvalValue.Name = "textBox_uvalValue";
	        this.textBox_uvalValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_uvalValue.TabIndex = 65;
	        // 
	        // comboBox_uvalCmp
	        // 
	        this.comboBox_uvalCmp.FormattingEnabled = true;
	        this.comboBox_uvalCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_uvalCmp.Location = new System.Drawing.Point(321, 378);
	        this.comboBox_uvalCmp.Name = "comboBox_uvalCmp";
	        this.comboBox_uvalCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_uvalCmp.TabIndex = 64;
	        // 
	        // checkBox_uvalQuery
	        // 
	        this.checkBox_uvalQuery.Location = new System.Drawing.Point(267, 378);
	        this.checkBox_uvalQuery.Name = "checkBox_uvalQuery";
	        this.checkBox_uvalQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_uvalQuery.TabIndex = 63;
	        this.checkBox_uvalQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_uvalResult
	        // 
	        this.checkBox_uvalResult.Location = new System.Drawing.Point(133, 378);
	        this.checkBox_uvalResult.Name = "checkBox_uvalResult";
	        this.checkBox_uvalResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_uvalResult.TabIndex = 62;
	        this.checkBox_uvalResult.UseVisualStyleBackColor = true;
	        // 
	        // label18
	        // 
	        this.label18.Location = new System.Drawing.Point(3, 376);
	        this.label18.Name = "label18";
	        this.label18.Size = new System.Drawing.Size(89, 35);
	        this.label18.TabIndex = 61;
	        this.label18.Text = "Причина увольнения";
	        this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // textBox_tabelnumValue
	        // 
	        this.textBox_tabelnumValue.Location = new System.Drawing.Point(418, 338);
	        this.textBox_tabelnumValue.Name = "textBox_tabelnumValue";
	        this.textBox_tabelnumValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_tabelnumValue.TabIndex = 60;
	        // 
	        // comboBox_tabelnumCmp
	        // 
	        this.comboBox_tabelnumCmp.FormattingEnabled = true;
	        this.comboBox_tabelnumCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_tabelnumCmp.Location = new System.Drawing.Point(321, 338);
	        this.comboBox_tabelnumCmp.Name = "comboBox_tabelnumCmp";
	        this.comboBox_tabelnumCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_tabelnumCmp.TabIndex = 59;
	        // 
	        // checkBox_tabelnumQuery
	        // 
	        this.checkBox_tabelnumQuery.Location = new System.Drawing.Point(267, 338);
	        this.checkBox_tabelnumQuery.Name = "checkBox_tabelnumQuery";
	        this.checkBox_tabelnumQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_tabelnumQuery.TabIndex = 58;
	        this.checkBox_tabelnumQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_tabelnumResult
	        // 
	        this.checkBox_tabelnumResult.Location = new System.Drawing.Point(133, 338);
	        this.checkBox_tabelnumResult.Name = "checkBox_tabelnumResult";
	        this.checkBox_tabelnumResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_tabelnumResult.TabIndex = 57;
	        this.checkBox_tabelnumResult.UseVisualStyleBackColor = true;
	        // 
	        // label17
	        // 
	        this.label17.Location = new System.Drawing.Point(3, 336);
	        this.label17.Name = "label17";
	        this.label17.Size = new System.Drawing.Size(89, 35);
	        this.label17.TabIndex = 56;
	        this.label17.Text = "Табельный номер";
	        this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // comboBox_maritalValue
	        // 
	        this.comboBox_maritalValue.FormattingEnabled = true;
	        this.comboBox_maritalValue.Location = new System.Drawing.Point(416, 298);
	        this.comboBox_maritalValue.Name = "comboBox_maritalValue";
	        this.comboBox_maritalValue.Size = new System.Drawing.Size(165, 23);
	        this.comboBox_maritalValue.TabIndex = 55;
	        // 
	        // comboBox_maritalCmp
	        // 
	        this.comboBox_maritalCmp.FormattingEnabled = true;
	        this.comboBox_maritalCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_maritalCmp.Location = new System.Drawing.Point(321, 298);
	        this.comboBox_maritalCmp.Name = "comboBox_maritalCmp";
	        this.comboBox_maritalCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_maritalCmp.TabIndex = 54;
	        // 
	        // checkBox_maritalQuery
	        // 
	        this.checkBox_maritalQuery.Location = new System.Drawing.Point(267, 298);
	        this.checkBox_maritalQuery.Name = "checkBox_maritalQuery";
	        this.checkBox_maritalQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_maritalQuery.TabIndex = 53;
	        this.checkBox_maritalQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_maritalResult
	        // 
	        this.checkBox_maritalResult.Location = new System.Drawing.Point(133, 298);
	        this.checkBox_maritalResult.Name = "checkBox_maritalResult";
	        this.checkBox_maritalResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_maritalResult.TabIndex = 52;
	        this.checkBox_maritalResult.UseVisualStyleBackColor = true;
	        // 
	        // label16
	        // 
	        this.label16.Location = new System.Drawing.Point(3, 295);
	        this.label16.Name = "label16";
	        this.label16.Size = new System.Drawing.Size(89, 35);
	        this.label16.TabIndex = 51;
	        this.label16.Text = "Семейный статус";
	        this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // textBox_professionValue
	        // 
	        this.textBox_professionValue.Location = new System.Drawing.Point(416, 205);
	        this.textBox_professionValue.Name = "textBox_professionValue";
	        this.textBox_professionValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_professionValue.TabIndex = 50;
	        // 
	        // textBox_innValue
	        // 
	        this.textBox_innValue.Location = new System.Drawing.Point(418, 234);
	        this.textBox_innValue.MaxLength = 12;
	        this.textBox_innValue.Name = "textBox_innValue";
	        this.textBox_innValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_innValue.TabIndex = 49;
	        this.textBox_innValue.KeyPress +=
		        new System.Windows.Forms.KeyPressEventHandler(this.textBox_innValue_KeyPress);
	        // 
	        // textBox_snilsValue
	        // 
	        this.textBox_snilsValue.Location = new System.Drawing.Point(416, 263);
	        this.textBox_snilsValue.MaxLength = 11;
	        this.textBox_snilsValue.Name = "textBox_snilsValue";
	        this.textBox_snilsValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_snilsValue.TabIndex = 48;
	        this.textBox_snilsValue.KeyPress +=
		        new System.Windows.Forms.KeyPressEventHandler(this.textBox_snilsValue_KeyPress);
	        // 
	        // comboBox_professionCmp
	        // 
	        this.comboBox_professionCmp.FormattingEnabled = true;
	        this.comboBox_professionCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_professionCmp.Location = new System.Drawing.Point(322, 205);
	        this.comboBox_professionCmp.Name = "comboBox_professionCmp";
	        this.comboBox_professionCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_professionCmp.TabIndex = 47;
	        // 
	        // comboBox_innCmp
	        // 
	        this.comboBox_innCmp.FormattingEnabled = true;
	        this.comboBox_innCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_innCmp.Location = new System.Drawing.Point(322, 234);
	        this.comboBox_innCmp.Name = "comboBox_innCmp";
	        this.comboBox_innCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_innCmp.TabIndex = 46;
	        // 
	        // comboBox_snilsCmp
	        // 
	        this.comboBox_snilsCmp.FormattingEnabled = true;
	        this.comboBox_snilsCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_snilsCmp.Location = new System.Drawing.Point(322, 263);
	        this.comboBox_snilsCmp.Name = "comboBox_snilsCmp";
	        this.comboBox_snilsCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_snilsCmp.TabIndex = 45;
	        // 
	        // checkBox_professionResult
	        // 
	        this.checkBox_professionResult.Location = new System.Drawing.Point(133, 205);
	        this.checkBox_professionResult.Name = "checkBox_professionResult";
	        this.checkBox_professionResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_professionResult.TabIndex = 44;
	        this.checkBox_professionResult.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_innResult
	        // 
	        this.checkBox_innResult.Location = new System.Drawing.Point(133, 234);
	        this.checkBox_innResult.Name = "checkBox_innResult";
	        this.checkBox_innResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_innResult.TabIndex = 43;
	        this.checkBox_innResult.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_snilsResult
	        // 
	        this.checkBox_snilsResult.Location = new System.Drawing.Point(133, 263);
	        this.checkBox_snilsResult.Name = "checkBox_snilsResult";
	        this.checkBox_snilsResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_snilsResult.TabIndex = 42;
	        this.checkBox_snilsResult.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_professionQuery
	        // 
	        this.checkBox_professionQuery.Location = new System.Drawing.Point(267, 205);
	        this.checkBox_professionQuery.Name = "checkBox_professionQuery";
	        this.checkBox_professionQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_professionQuery.TabIndex = 41;
	        this.checkBox_professionQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_innQuery
	        // 
	        this.checkBox_innQuery.Location = new System.Drawing.Point(267, 234);
	        this.checkBox_innQuery.Name = "checkBox_innQuery";
	        this.checkBox_innQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_innQuery.TabIndex = 40;
	        this.checkBox_innQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_snilsQuery
	        // 
	        this.checkBox_snilsQuery.Location = new System.Drawing.Point(267, 263);
	        this.checkBox_snilsQuery.Name = "checkBox_snilsQuery";
	        this.checkBox_snilsQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_snilsQuery.TabIndex = 39;
	        this.checkBox_snilsQuery.UseVisualStyleBackColor = true;
	        // 
	        // label15
	        // 
	        this.label15.Location = new System.Drawing.Point(3, 238);
	        this.label15.Name = "label15";
	        this.label15.Size = new System.Drawing.Size(89, 23);
	        this.label15.TabIndex = 38;
	        this.label15.Text = "ИНН";
	        this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label14
	        // 
	        this.label14.Location = new System.Drawing.Point(3, 267);
	        this.label14.Name = "label14";
	        this.label14.Size = new System.Drawing.Size(89, 23);
	        this.label14.TabIndex = 37;
	        this.label14.Text = "СНИЛС";
	        this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label13
	        // 
	        this.label13.Location = new System.Drawing.Point(3, 209);
	        this.label13.Name = "label13";
	        this.label13.Size = new System.Drawing.Size(89, 23);
	        this.label13.TabIndex = 36;
	        this.label13.Text = "Профессия";
	        this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // textBox_mobtelValue
	        // 
	        this.textBox_mobtelValue.Location = new System.Drawing.Point(416, 177);
	        this.textBox_mobtelValue.Name = "textBox_mobtelValue";
	        this.textBox_mobtelValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_mobtelValue.TabIndex = 35;
	        // 
	        // textBox_grazdanValue
	        // 
	        this.textBox_grazdanValue.Location = new System.Drawing.Point(418, 148);
	        this.textBox_grazdanValue.Name = "textBox_grazdanValue";
	        this.textBox_grazdanValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_grazdanValue.TabIndex = 34;
	        // 
	        // comboBox_mobtelCmp
	        // 
	        this.comboBox_mobtelCmp.FormattingEnabled = true;
	        this.comboBox_mobtelCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_mobtelCmp.Location = new System.Drawing.Point(322, 177);
	        this.comboBox_mobtelCmp.Name = "comboBox_mobtelCmp";
	        this.comboBox_mobtelCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_mobtelCmp.TabIndex = 33;
	        // 
	        // comboBox_grazdanCmp
	        // 
	        this.comboBox_grazdanCmp.FormattingEnabled = true;
	        this.comboBox_grazdanCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_grazdanCmp.Location = new System.Drawing.Point(322, 148);
	        this.comboBox_grazdanCmp.Name = "comboBox_grazdanCmp";
	        this.comboBox_grazdanCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_grazdanCmp.TabIndex = 32;
	        // 
	        // checkBox_mobtelQuery
	        // 
	        this.checkBox_mobtelQuery.Location = new System.Drawing.Point(267, 177);
	        this.checkBox_mobtelQuery.Name = "checkBox_mobtelQuery";
	        this.checkBox_mobtelQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_mobtelQuery.TabIndex = 31;
	        this.checkBox_mobtelQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_grazdanQuery
	        // 
	        this.checkBox_grazdanQuery.Location = new System.Drawing.Point(267, 148);
	        this.checkBox_grazdanQuery.Name = "checkBox_grazdanQuery";
	        this.checkBox_grazdanQuery.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_grazdanQuery.TabIndex = 30;
	        this.checkBox_grazdanQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_mobtelResult
	        // 
	        this.checkBox_mobtelResult.Location = new System.Drawing.Point(133, 177);
	        this.checkBox_mobtelResult.Name = "checkBox_mobtelResult";
	        this.checkBox_mobtelResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_mobtelResult.TabIndex = 29;
	        this.checkBox_mobtelResult.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_grazdanResult
	        // 
	        this.checkBox_grazdanResult.Location = new System.Drawing.Point(133, 148);
	        this.checkBox_grazdanResult.Name = "checkBox_grazdanResult";
	        this.checkBox_grazdanResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_grazdanResult.TabIndex = 28;
	        this.checkBox_grazdanResult.UseVisualStyleBackColor = true;
	        // 
	        // label12
	        // 
	        this.label12.Location = new System.Drawing.Point(3, 180);
	        this.label12.Name = "label12";
	        this.label12.Size = new System.Drawing.Size(89, 23);
	        this.label12.TabIndex = 27;
	        this.label12.Text = "Телефон";
	        this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label10
	        // 
	        this.label10.Location = new System.Drawing.Point(3, 151);
	        this.label10.Name = "label10";
	        this.label10.Size = new System.Drawing.Size(89, 23);
	        this.label10.TabIndex = 26;
	        this.label10.Text = "Гражданство";
	        this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // comboBox_genderValue
	        // 
	        this.comboBox_genderValue.FormattingEnabled = true;
	        this.comboBox_genderValue.Location = new System.Drawing.Point(416, 119);
	        this.comboBox_genderValue.Name = "comboBox_genderValue";
	        this.comboBox_genderValue.Size = new System.Drawing.Size(165, 23);
	        this.comboBox_genderValue.TabIndex = 25;
	        // 
	        // comboBox_genderCmp
	        // 
	        this.comboBox_genderCmp.FormattingEnabled = true;
	        this.comboBox_genderCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_genderCmp.Location = new System.Drawing.Point(323, 119);
	        this.comboBox_genderCmp.Name = "comboBox_genderCmp";
	        this.comboBox_genderCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_genderCmp.TabIndex = 24;
	        // 
	        // checkBox_genderQuery
	        // 
	        this.checkBox_genderQuery.Location = new System.Drawing.Point(267, 119);
	        this.checkBox_genderQuery.Name = "checkBox_genderQuery";
	        this.checkBox_genderQuery.Size = new System.Drawing.Size(28, 24);
	        this.checkBox_genderQuery.TabIndex = 23;
	        this.checkBox_genderQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_genderResult
	        // 
	        this.checkBox_genderResult.Location = new System.Drawing.Point(133, 119);
	        this.checkBox_genderResult.Name = "checkBox_genderResult";
	        this.checkBox_genderResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_genderResult.TabIndex = 22;
	        this.checkBox_genderResult.UseVisualStyleBackColor = true;
	        // 
	        // label11
	        // 
	        this.label11.Location = new System.Drawing.Point(3, 122);
	        this.label11.Name = "label11";
	        this.label11.Size = new System.Drawing.Size(89, 23);
	        this.label11.TabIndex = 21;
	        this.label11.Text = "Пол";
	        this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // textBox_middleNameValue
	        // 
	        this.textBox_middleNameValue.Location = new System.Drawing.Point(416, 90);
	        this.textBox_middleNameValue.Name = "textBox_middleNameValue";
	        this.textBox_middleNameValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_middleNameValue.TabIndex = 20;
	        // 
	        // textBox_nameValue
	        // 
	        this.textBox_nameValue.Location = new System.Drawing.Point(416, 61);
	        this.textBox_nameValue.Name = "textBox_nameValue";
	        this.textBox_nameValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_nameValue.TabIndex = 19;
	        // 
	        // textBox_secondNameValue
	        // 
	        this.textBox_secondNameValue.Location = new System.Drawing.Point(416, 32);
	        this.textBox_secondNameValue.Name = "textBox_secondNameValue";
	        this.textBox_secondNameValue.Size = new System.Drawing.Size(165, 23);
	        this.textBox_secondNameValue.TabIndex = 18;
	        // 
	        // comboBox_middleNameCmp
	        // 
	        this.comboBox_middleNameCmp.FormattingEnabled = true;
	        this.comboBox_middleNameCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_middleNameCmp.Location = new System.Drawing.Point(323, 90);
	        this.comboBox_middleNameCmp.Name = "comboBox_middleNameCmp";
	        this.comboBox_middleNameCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_middleNameCmp.TabIndex = 17;
	        // 
	        // comboBox_nameCmp
	        // 
	        this.comboBox_nameCmp.FormattingEnabled = true;
	        this.comboBox_nameCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_nameCmp.Location = new System.Drawing.Point(322, 61);
	        this.comboBox_nameCmp.Name = "comboBox_nameCmp";
	        this.comboBox_nameCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_nameCmp.TabIndex = 16;
	        // 
	        // comboBox_secondNameCmp
	        // 
	        this.comboBox_secondNameCmp.FormattingEnabled = true;
	        this.comboBox_secondNameCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
	        this.comboBox_secondNameCmp.Location = new System.Drawing.Point(323, 32);
	        this.comboBox_secondNameCmp.Name = "comboBox_secondNameCmp";
	        this.comboBox_secondNameCmp.Size = new System.Drawing.Size(88, 23);
	        this.comboBox_secondNameCmp.TabIndex = 15;
	        // 
	        // checkBox_middleNameQuery
	        // 
	        this.checkBox_middleNameQuery.Location = new System.Drawing.Point(267, 90);
	        this.checkBox_middleNameQuery.Name = "checkBox_middleNameQuery";
	        this.checkBox_middleNameQuery.Size = new System.Drawing.Size(28, 24);
	        this.checkBox_middleNameQuery.TabIndex = 14;
	        this.checkBox_middleNameQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_nameQuery
	        // 
	        this.checkBox_nameQuery.Location = new System.Drawing.Point(267, 61);
	        this.checkBox_nameQuery.Name = "checkBox_nameQuery";
	        this.checkBox_nameQuery.Size = new System.Drawing.Size(28, 24);
	        this.checkBox_nameQuery.TabIndex = 13;
	        this.checkBox_nameQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_secondNameQuery
	        // 
	        this.checkBox_secondNameQuery.Location = new System.Drawing.Point(267, 32);
	        this.checkBox_secondNameQuery.Name = "checkBox_secondNameQuery";
	        this.checkBox_secondNameQuery.Size = new System.Drawing.Size(28, 24);
	        this.checkBox_secondNameQuery.TabIndex = 12;
	        this.checkBox_secondNameQuery.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_middleNameResult
	        // 
	        this.checkBox_middleNameResult.Location = new System.Drawing.Point(133, 90);
	        this.checkBox_middleNameResult.Name = "checkBox_middleNameResult";
	        this.checkBox_middleNameResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_middleNameResult.TabIndex = 11;
	        this.checkBox_middleNameResult.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_nameResult
	        // 
	        this.checkBox_nameResult.Location = new System.Drawing.Point(133, 61);
	        this.checkBox_nameResult.Name = "checkBox_nameResult";
	        this.checkBox_nameResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_nameResult.TabIndex = 10;
	        this.checkBox_nameResult.UseVisualStyleBackColor = true;
	        // 
	        // checkBox_secondNameResult
	        // 
	        this.checkBox_secondNameResult.Location = new System.Drawing.Point(133, 32);
	        this.checkBox_secondNameResult.Name = "checkBox_secondNameResult";
	        this.checkBox_secondNameResult.Size = new System.Drawing.Size(20, 24);
	        this.checkBox_secondNameResult.TabIndex = 9;
	        this.checkBox_secondNameResult.UseVisualStyleBackColor = true;
	        // 
	        // label8
	        // 
	        this.label8.Location = new System.Drawing.Point(3, 93);
	        this.label8.Name = "label8";
	        this.label8.Size = new System.Drawing.Size(89, 23);
	        this.label8.TabIndex = 8;
	        this.label8.Text = "Отчество";
	        this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label7
	        // 
	        this.label7.Location = new System.Drawing.Point(3, 65);
	        this.label7.Name = "label7";
	        this.label7.Size = new System.Drawing.Size(89, 23);
	        this.label7.TabIndex = 7;
	        this.label7.Text = "Имя";
	        this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label6
	        // 
	        this.label6.Location = new System.Drawing.Point(3, 36);
	        this.label6.Name = "label6";
	        this.label6.Size = new System.Drawing.Size(89, 23);
	        this.label6.TabIndex = 6;
	        this.label6.Text = "Фамилия";
	        this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label5
	        // 
	        this.label5.Location = new System.Drawing.Point(416, 0);
	        this.label5.Name = "label5";
	        this.label5.Size = new System.Drawing.Size(87, 36);
	        this.label5.TabIndex = 5;
	        this.label5.Text = "Значение";
	        this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label4
	        // 
	        this.label4.Location = new System.Drawing.Point(323, 0);
	        this.label4.Name = "label4";
	        this.label4.Size = new System.Drawing.Size(87, 36);
	        this.label4.TabIndex = 4;
	        this.label4.Text = "Знак сравнения";
	        this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label3
	        // 
	        this.label3.Location = new System.Drawing.Point(226, 0);
	        this.label3.Name = "label3";
	        this.label3.Size = new System.Drawing.Size(90, 36);
	        this.label3.TabIndex = 3;
	        this.label3.Text = "Использовать в запросе";
	        this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label2
	        // 
	        this.label2.Location = new System.Drawing.Point(98, -3);
	        this.label2.Name = "label2";
	        this.label2.Size = new System.Drawing.Size(100, 36);
	        this.label2.TabIndex = 2;
	        this.label2.Text = "Использовать в результате";
	        this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // label1
	        // 
	        this.label1.Location = new System.Drawing.Point(3, 0);
	        this.label1.Name = "label1";
	        this.label1.Size = new System.Drawing.Size(89, 36);
	        this.label1.TabIndex = 1;
	        this.label1.Text = "Название поля";
	        this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // panel3
	        // 
	        this.panel3.Controls.Add(this.dataGridView_result);
	        this.panel3.Controls.Add(this.label_resultCount);
	        this.panel3.Controls.Add(this.label9);
	        this.panel3.Location = new System.Drawing.Point(640, 12);
	        this.panel3.Name = "panel3";
	        this.panel3.Size = new System.Drawing.Size(612, 657);
	        this.panel3.TabIndex = 2;
	        // 
	        // dataGridView_result
	        // 
	        this.dataGridView_result.ColumnHeadersHeightSizeMode =
		        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	        this.dataGridView_result.Location = new System.Drawing.Point(3, 27);
	        this.dataGridView_result.Name = "dataGridView_result";
	        this.dataGridView_result.Size = new System.Drawing.Size(605, 628);
	        this.dataGridView_result.TabIndex = 2;
	        this.dataGridView_result.CellDoubleClick +=
		        new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_result_CellDoubleClick);
	        // 
	        // label_resultCount
	        // 
	        this.label_resultCount.Location = new System.Drawing.Point(157, 0);
	        this.label_resultCount.Name = "label_resultCount";
	        this.label_resultCount.Size = new System.Drawing.Size(100, 23);
	        this.label_resultCount.TabIndex = 1;
	        // 
	        // label9
	        // 
	        this.label9.Location = new System.Drawing.Point(3, 0);
	        this.label9.Name = "label9";
	        this.label9.Size = new System.Drawing.Size(149, 23);
	        this.label9.TabIndex = 0;
	        this.label9.Text = "Количество результатов: ";
	        // 
	        // button_run
	        // 
	        this.button_run.Location = new System.Drawing.Point(12, 646);
	        this.button_run.Name = "button_run";
	        this.button_run.Size = new System.Drawing.Size(92, 23);
	        this.button_run.TabIndex = 3;
	        this.button_run.Text = "Выполнить";
	        this.button_run.UseVisualStyleBackColor = true;
	        this.button_run.Click += new System.EventHandler(this.button_run_Click);
	        // 
	        // SearchPersonCard
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(1263, 681);
	        this.Controls.Add(this.button_run);
	        this.Controls.Add(this.panel3);
	        this.Controls.Add(this.panel1);
	        this.Name = "SearchPersonCard";
	        this.Text = "SearchPersonCard";
	        this.panel1.ResumeLayout(false);
	        this.panel1.PerformLayout();
	        this.panel3.ResumeLayout(false);
	        ((System.ComponentModel.ISupportInitialize) (this.dataGridView_result)).EndInit();
	        this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.DataGridView dataGridView_result;
        private System.Windows.Forms.Label label_resultCount;
        private System.Windows.Forms.CheckBox checkBox_secondNameQuery;
        private System.Windows.Forms.CheckBox checkBox_secondNameResult;
        private System.Windows.Forms.TextBox textBox_secondNameValue;
        private System.Windows.Forms.TextBox textBox_middleNameValue;
        private System.Windows.Forms.TextBox textBox_nameValue;
        private System.Windows.Forms.ComboBox comboBox_middleNameCmp;
        private System.Windows.Forms.ComboBox comboBox_nameCmp;
        private System.Windows.Forms.ComboBox comboBox_secondNameCmp;
        private System.Windows.Forms.CheckBox checkBox_middleNameQuery;
        private System.Windows.Forms.CheckBox checkBox_nameQuery;
        private System.Windows.Forms.CheckBox checkBox_middleNameResult;
        private System.Windows.Forms.CheckBox checkBox_nameResult;
        private System.Windows.Forms.CheckBox checkBox_genderResult;
        private System.Windows.Forms.CheckBox checkBox_genderQuery;
        private System.Windows.Forms.ComboBox comboBox_genderCmp;
        private System.Windows.Forms.ComboBox comboBox_genderValue;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox checkBox_grazdanResult;
		private System.Windows.Forms.CheckBox checkBox_mobtelQuery;
		private System.Windows.Forms.CheckBox checkBox_grazdanQuery;
		private System.Windows.Forms.CheckBox checkBox_mobtelResult;
		private System.Windows.Forms.TextBox textBox_mobtelValue;
		private System.Windows.Forms.TextBox textBox_grazdanValue;
		private System.Windows.Forms.ComboBox comboBox_mobtelCmp;
		private System.Windows.Forms.ComboBox comboBox_grazdanCmp;
		private System.Windows.Forms.TextBox textBox_professionValue;
		private System.Windows.Forms.TextBox textBox_snilsValue;
		private System.Windows.Forms.ComboBox comboBox_professionCmp;
		private System.Windows.Forms.ComboBox comboBox_innCmp;
		private System.Windows.Forms.ComboBox comboBox_snilsCmp;
		private System.Windows.Forms.CheckBox checkBox_professionResult;
		private System.Windows.Forms.CheckBox checkBox_innResult;
		private System.Windows.Forms.CheckBox checkBox_professionQuery;
		private System.Windows.Forms.CheckBox checkBox_innQuery;
		private System.Windows.Forms.CheckBox checkBox_snilsQuery;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox checkBox_snilsResult;
		private System.Windows.Forms.TextBox textBox_innValue;
		private System.Windows.Forms.ComboBox comboBox_maritalCmp;
		private System.Windows.Forms.CheckBox checkBox_maritalQuery;
		private System.Windows.Forms.CheckBox checkBox_maritalResult;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox comboBox_maritalValue;
		private System.Windows.Forms.TextBox textBox_tabelnumValue;
		private System.Windows.Forms.ComboBox comboBox_tabelnumCmp;
		private System.Windows.Forms.CheckBox checkBox_tabelnumQuery;
		private System.Windows.Forms.CheckBox checkBox_tabelnumResult;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox_uvalValue;
		private System.Windows.Forms.ComboBox comboBox_uvalCmp;
		private System.Windows.Forms.CheckBox checkBox_uvalQuery;
		private System.Windows.Forms.CheckBox checkBox_uvalResult;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox comboBox_typeworkCmp;
		private System.Windows.Forms.CheckBox checkBox_typeworkQuery;
		private System.Windows.Forms.CheckBox checkBox_typeworkResult;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox comboBox_typeworkValue;
		private System.Windows.Forms.ComboBox comboBox_birthCmp;
		private System.Windows.Forms.CheckBox checkBox_birthQuery;
		private System.Windows.Forms.CheckBox checkBox_birthResult;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox comboBox_eduCmp;
		private System.Windows.Forms.CheckBox checkBox_eduQuery;
		private System.Windows.Forms.CheckBox checkBox_eduResult;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.DateTimePicker dateTimePicker_birthValue;
		private System.Windows.Forms.ComboBox comboBox_eduValue;
    }
}