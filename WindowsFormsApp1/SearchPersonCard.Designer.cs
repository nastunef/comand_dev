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
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_genderResult = new System.Windows.Forms.CheckBox();
            this.checkBox_genderQuery = new System.Windows.Forms.CheckBox();
            this.comboBox_genderCmp = new System.Windows.Forms.ComboBox();
            this.comboBox_genderValue = new System.Windows.Forms.ComboBox();
            this.button_run = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_result)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
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
            // textBox_middleNameValue
            // 
            this.textBox_middleNameValue.Location = new System.Drawing.Point(417, 78);
            this.textBox_middleNameValue.Name = "textBox_middleNameValue";
            this.textBox_middleNameValue.Size = new System.Drawing.Size(165, 23);
            this.textBox_middleNameValue.TabIndex = 20;
            // 
            // textBox_nameValue
            // 
            this.textBox_nameValue.Location = new System.Drawing.Point(417, 57);
            this.textBox_nameValue.Name = "textBox_nameValue";
            this.textBox_nameValue.Size = new System.Drawing.Size(165, 23);
            this.textBox_nameValue.TabIndex = 19;
            // 
            // textBox_secondNameValue
            // 
            this.textBox_secondNameValue.Location = new System.Drawing.Point(417, 33);
            this.textBox_secondNameValue.Name = "textBox_secondNameValue";
            this.textBox_secondNameValue.Size = new System.Drawing.Size(165, 23);
            this.textBox_secondNameValue.TabIndex = 18;
            // 
            // comboBox_middleNameCmp
            // 
            this.comboBox_middleNameCmp.FormattingEnabled = true;
            this.comboBox_middleNameCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
            this.comboBox_middleNameCmp.Location = new System.Drawing.Point(323, 78);
            this.comboBox_middleNameCmp.Name = "comboBox_middleNameCmp";
            this.comboBox_middleNameCmp.Size = new System.Drawing.Size(88, 23);
            this.comboBox_middleNameCmp.TabIndex = 17;
            // 
            // comboBox_nameCmp
            // 
            this.comboBox_nameCmp.FormattingEnabled = true;
            this.comboBox_nameCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
            this.comboBox_nameCmp.Location = new System.Drawing.Point(323, 57);
            this.comboBox_nameCmp.Name = "comboBox_nameCmp";
            this.comboBox_nameCmp.Size = new System.Drawing.Size(88, 23);
            this.comboBox_nameCmp.TabIndex = 16;
            // 
            // comboBox_secondNameCmp
            // 
            this.comboBox_secondNameCmp.FormattingEnabled = true;
            this.comboBox_secondNameCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
            this.comboBox_secondNameCmp.Location = new System.Drawing.Point(323, 33);
            this.comboBox_secondNameCmp.Name = "comboBox_secondNameCmp";
            this.comboBox_secondNameCmp.Size = new System.Drawing.Size(88, 23);
            this.comboBox_secondNameCmp.TabIndex = 15;
            // 
            // checkBox_middleNameQuery
            // 
            this.checkBox_middleNameQuery.Location = new System.Drawing.Point(267, 78);
            this.checkBox_middleNameQuery.Name = "checkBox_middleNameQuery";
            this.checkBox_middleNameQuery.Size = new System.Drawing.Size(28, 24);
            this.checkBox_middleNameQuery.TabIndex = 14;
            this.checkBox_middleNameQuery.UseVisualStyleBackColor = true;
            // 
            // checkBox_nameQuery
            // 
            this.checkBox_nameQuery.Location = new System.Drawing.Point(267, 55);
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
            this.checkBox_middleNameResult.Location = new System.Drawing.Point(133, 78);
            this.checkBox_middleNameResult.Name = "checkBox_middleNameResult";
            this.checkBox_middleNameResult.Size = new System.Drawing.Size(20, 24);
            this.checkBox_middleNameResult.TabIndex = 11;
            this.checkBox_middleNameResult.UseVisualStyleBackColor = true;
            // 
            // checkBox_nameResult
            // 
            this.checkBox_nameResult.Location = new System.Drawing.Point(133, 55);
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
            this.label8.Location = new System.Drawing.Point(3, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Отчество";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 59);
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
            this.label5.Location = new System.Drawing.Point(417, 0);
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
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Пол";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox_genderResult
            // 
            this.checkBox_genderResult.Location = new System.Drawing.Point(133, 101);
            this.checkBox_genderResult.Name = "checkBox_genderResult";
            this.checkBox_genderResult.Size = new System.Drawing.Size(20, 24);
            this.checkBox_genderResult.TabIndex = 22;
            this.checkBox_genderResult.UseVisualStyleBackColor = true;
            // 
            // checkBox_genderQuery
            // 
            this.checkBox_genderQuery.Location = new System.Drawing.Point(267, 101);
            this.checkBox_genderQuery.Name = "checkBox_genderQuery";
            this.checkBox_genderQuery.Size = new System.Drawing.Size(28, 24);
            this.checkBox_genderQuery.TabIndex = 23;
            this.checkBox_genderQuery.UseVisualStyleBackColor = true;
            // 
            // comboBox_genderCmp
            // 
            this.comboBox_genderCmp.FormattingEnabled = true;
            this.comboBox_genderCmp.Items.AddRange(new object[] {"=", "!=", ">", ">=", "<", "<="});
            this.comboBox_genderCmp.Location = new System.Drawing.Point(323, 101);
            this.comboBox_genderCmp.Name = "comboBox_genderCmp";
            this.comboBox_genderCmp.Size = new System.Drawing.Size(88, 23);
            this.comboBox_genderCmp.TabIndex = 24;
            // 
            // comboBox_genderValue
            // 
            this.comboBox_genderValue.FormattingEnabled = true;
            this.comboBox_genderValue.Location = new System.Drawing.Point(417, 102);
            this.comboBox_genderValue.Name = "comboBox_genderValue";
            this.comboBox_genderValue.Size = new System.Drawing.Size(165, 23);
            this.comboBox_genderValue.TabIndex = 25;
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
    }
}