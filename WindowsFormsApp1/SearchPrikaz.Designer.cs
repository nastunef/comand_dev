﻿using System.Collections;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class SearchPrikaz
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
             this.fullname = new System.Windows.Forms.TextBox();
             this.firstname = new System.Windows.Forms.TextBox();
             this.otchestvo = new System.Windows.Forms.TextBox();
             this.dataGridView_family = new System.Windows.Forms.DataGridView();
             this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.Column2 = new WindowsFormsApp1.CalendarColumn();
             this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
             this.label1 = new System.Windows.Forms.Label();
             this.label2 = new System.Windows.Forms.Label();
             this.label3 = new System.Windows.Forms.Label();
             this.label4 = new System.Windows.Forms.Label();
             this.button1 = new System.Windows.Forms.Button();
             this.button2 = new System.Windows.Forms.Button();
             this.checkBoxPriem = new System.Windows.Forms.CheckBox();
             this.checkBoxDelWork = new System.Windows.Forms.CheckBox();
             this.checkBoxKomand = new System.Windows.Forms.CheckBox();
             this.checkBoxPerevod = new System.Windows.Forms.CheckBox();
             this.dateTimePickerOt = new System.Windows.Forms.DateTimePicker();
             this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
             this.label6 = new System.Windows.Forms.Label();
             this.checkBox_Confirm = new System.Windows.Forms.CheckBox();
             this.label7 = new System.Windows.Forms.Label();
             this.buttonBack = new System.Windows.Forms.Button();
             this.label9 = new System.Windows.Forms.Label();
             this.panel1 = new System.Windows.Forms.Panel();
             this.label11 = new System.Windows.Forms.Label();
             this.label10 = new System.Windows.Forms.Label();
             this.label8 = new System.Windows.Forms.Label();
             this.label5 = new System.Windows.Forms.Label();
             ((System.ComponentModel.ISupportInitialize) (this.dataGridView_family)).BeginInit();
             this.panel1.SuspendLayout();
             this.SuspendLayout();
             // 
             // fullname
             // 
             this.fullname.Location = new System.Drawing.Point(36, 76);
             this.fullname.Margin = new System.Windows.Forms.Padding(2);
             this.fullname.Name = "fullname";
             this.fullname.Size = new System.Drawing.Size(177, 23);
             this.fullname.TabIndex = 0;
             // 
             // firstname
             // 
             this.firstname.Location = new System.Drawing.Point(227, 76);
             this.firstname.Margin = new System.Windows.Forms.Padding(2);
             this.firstname.Name = "firstname";
             this.firstname.Size = new System.Drawing.Size(171, 23);
             this.firstname.TabIndex = 1;
             // 
             // otchestvo
             // 
             this.otchestvo.Location = new System.Drawing.Point(422, 76);
             this.otchestvo.Margin = new System.Windows.Forms.Padding(2);
             this.otchestvo.Name = "otchestvo";
             this.otchestvo.Size = new System.Drawing.Size(175, 23);
             this.otchestvo.TabIndex = 2;
             // 
             // dataGridView_family
             // 
             this.dataGridView_family.ColumnHeadersHeightSizeMode =
                 System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
             this.dataGridView_family.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                 {this.Column1, this.Column2, this.Column3, this.Column4});
             this.dataGridView_family.Location = new System.Drawing.Point(657, 96);
             this.dataGridView_family.Margin = new System.Windows.Forms.Padding(2);
             this.dataGridView_family.Name = "dataGridView_family";
             this.dataGridView_family.Size = new System.Drawing.Size(694, 436);
             this.dataGridView_family.TabIndex = 19;
             // 
             // Column1
             // 
             this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
             this.Column1.HeaderText = "ФИО";
             this.Column1.Name = "Column1";
             // 
             // Column2
             // 
             this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
             this.Column2.HeaderText = "Дата составления";
             this.Column2.Name = "Column2";
             this.Column2.Width = 99;
             // 
             // Column3
             // 
             this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
             this.Column3.HeaderText = "Тип приказа";
             this.Column3.Name = "Column3";
             // 
             // Column4
             // 
             this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
             this.Column4.HeaderText = "Подтвержден";
             this.Column4.Name = "Column4";
             // 
             // label1
             // 
             this.label1.Location = new System.Drawing.Point(36, 47);
             this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(140, 25);
             this.label1.TabIndex = 20;
             this.label1.Text = "Фамилия";
             // 
             // label2
             // 
             this.label2.Location = new System.Drawing.Point(236, 47);
             this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(131, 27);
             this.label2.TabIndex = 21;
             this.label2.Text = "Имя";
             // 
             // label3
             // 
             this.label3.Location = new System.Drawing.Point(422, 47);
             this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
             this.label3.Name = "label3";
             this.label3.Size = new System.Drawing.Size(150, 25);
             this.label3.TabIndex = 22;
             this.label3.Text = "Отчество";
             // 
             // label4
             // 
             this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label4.Location = new System.Drawing.Point(248, 57);
             this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
             this.label4.Name = "label4";
             this.label4.Size = new System.Drawing.Size(266, 36);
             this.label4.TabIndex = 23;
             this.label4.Text = "Критерии поиска";
             // 
             // button1
             // 
             this.button1.Location = new System.Drawing.Point(252, 369);
             this.button1.Margin = new System.Windows.Forms.Padding(2);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(128, 33);
             this.button1.TabIndex = 24;
             this.button1.Text = "поиск";
             this.button1.UseVisualStyleBackColor = true;
             this.button1.Click += new System.EventHandler(this.button1_Click);
             // 
             // button2
             // 
             this.button2.Location = new System.Drawing.Point(889, 546);
             this.button2.Margin = new System.Windows.Forms.Padding(2);
             this.button2.Name = "button2";
             this.button2.Size = new System.Drawing.Size(220, 42);
             this.button2.TabIndex = 28;
             this.button2.Text = "Перейти к выбранному приказу";
             this.button2.UseVisualStyleBackColor = true;
             this.button2.Click += new System.EventHandler(this.button2_Click);
             // 
             // checkBoxPriem
             // 
             this.checkBoxPriem.Location = new System.Drawing.Point(38, 282);
             this.checkBoxPriem.Margin = new System.Windows.Forms.Padding(2);
             this.checkBoxPriem.Name = "checkBoxPriem";
             this.checkBoxPriem.Size = new System.Drawing.Size(148, 60);
             this.checkBoxPriem.TabIndex = 29;
             this.checkBoxPriem.Text = "Приказ о приеме на работу";
             this.checkBoxPriem.UseVisualStyleBackColor = true;
             // 
             // checkBoxDelWork
             // 
             this.checkBoxDelWork.Location = new System.Drawing.Point(324, 273);
             this.checkBoxDelWork.Margin = new System.Windows.Forms.Padding(2);
             this.checkBoxDelWork.Name = "checkBoxDelWork";
             this.checkBoxDelWork.Size = new System.Drawing.Size(141, 76);
             this.checkBoxDelWork.TabIndex = 30;
             this.checkBoxDelWork.Text = "Приказ об увольнении с работы";
             this.checkBoxDelWork.UseVisualStyleBackColor = true;
             // 
             // checkBoxKomand
             // 
             this.checkBoxKomand.Location = new System.Drawing.Point(191, 282);
             this.checkBoxKomand.Margin = new System.Windows.Forms.Padding(2);
             this.checkBoxKomand.Name = "checkBoxKomand";
             this.checkBoxKomand.Size = new System.Drawing.Size(131, 60);
             this.checkBoxKomand.TabIndex = 31;
             this.checkBoxKomand.Text = "Приказ о командировке";
             this.checkBoxKomand.UseVisualStyleBackColor = true;
             // 
             // checkBoxPerevod
             // 
             this.checkBoxPerevod.Location = new System.Drawing.Point(469, 279);
             this.checkBoxPerevod.Margin = new System.Windows.Forms.Padding(2);
             this.checkBoxPerevod.Name = "checkBoxPerevod";
             this.checkBoxPerevod.Size = new System.Drawing.Size(128, 67);
             this.checkBoxPerevod.TabIndex = 32;
             this.checkBoxPerevod.Text = "Приказ о переводе";
             this.checkBoxPerevod.UseVisualStyleBackColor = true;
             // 
             // dateTimePickerOt
             // 
             this.dateTimePickerOt.Location = new System.Drawing.Point(180, 159);
             this.dateTimePickerOt.Margin = new System.Windows.Forms.Padding(2);
             this.dateTimePickerOt.Name = "dateTimePickerOt";
             this.dateTimePickerOt.Size = new System.Drawing.Size(175, 23);
             this.dateTimePickerOt.TabIndex = 32;
             // 
             // dateTimePickerDo
             // 
             this.dateTimePickerDo.Location = new System.Drawing.Point(409, 159);
             this.dateTimePickerDo.Margin = new System.Windows.Forms.Padding(2);
             this.dateTimePickerDo.Name = "dateTimePickerDo";
             this.dateTimePickerDo.Size = new System.Drawing.Size(175, 23);
             this.dateTimePickerDo.TabIndex = 33;
             // 
             // label6
             // 
             this.label6.Location = new System.Drawing.Point(371, 159);
             this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
             this.label6.Name = "label6";
             this.label6.Size = new System.Drawing.Size(35, 23);
             this.label6.TabIndex = 35;
             this.label6.Text = "до";
             // 
             // checkBox_Confirm
             // 
             this.checkBox_Confirm.Location = new System.Drawing.Point(180, 204);
             this.checkBox_Confirm.Margin = new System.Windows.Forms.Padding(2);
             this.checkBox_Confirm.Name = "checkBox_Confirm";
             this.checkBox_Confirm.Size = new System.Drawing.Size(142, 22);
             this.checkBox_Confirm.TabIndex = 36;
             this.checkBox_Confirm.Text = "Подтвержден";
             this.checkBox_Confirm.UseVisualStyleBackColor = true;
             // 
             // label7
             // 
             this.label7.Location = new System.Drawing.Point(36, 165);
             this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
             this.label7.Name = "label7";
             this.label7.Size = new System.Drawing.Size(140, 25);
             this.label7.TabIndex = 37;
             this.label7.Text = "Дата составления от";
             // 
             // buttonBack
             // 
             this.buttonBack.Location = new System.Drawing.Point(1227, 666);
             this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
             this.buttonBack.Name = "buttonBack";
             this.buttonBack.Size = new System.Drawing.Size(124, 37);
             this.buttonBack.TabIndex = 45;
             this.buttonBack.Text = "назад";
             this.buttonBack.UseVisualStyleBackColor = true;
             this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
             // 
             // label9
             // 
             this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label9.Location = new System.Drawing.Point(901, 57);
             this.label9.Name = "label9";
             this.label9.Size = new System.Drawing.Size(181, 23);
             this.label9.TabIndex = 48;
             this.label9.Text = "Результаты поиска";
             // 
             // panel1
             // 
             this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
             this.panel1.Controls.Add(this.label11);
             this.panel1.Controls.Add(this.label10);
             this.panel1.Controls.Add(this.label8);
             this.panel1.Controls.Add(this.label5);
             this.panel1.Controls.Add(this.label7);
             this.panel1.Controls.Add(this.checkBox_Confirm);
             this.panel1.Controls.Add(this.label6);
             this.panel1.Controls.Add(this.dateTimePickerDo);
             this.panel1.Controls.Add(this.button1);
             this.panel1.Controls.Add(this.dateTimePickerOt);
             this.panel1.Controls.Add(this.checkBoxKomand);
             this.panel1.Controls.Add(this.checkBoxPerevod);
             this.panel1.Controls.Add(this.checkBoxDelWork);
             this.panel1.Controls.Add(this.checkBoxPriem);
             this.panel1.Controls.Add(this.label3);
             this.panel1.Controls.Add(this.label2);
             this.panel1.Controls.Add(this.label1);
             this.panel1.Controls.Add(this.otchestvo);
             this.panel1.Controls.Add(this.firstname);
             this.panel1.Controls.Add(this.fullname);
             this.panel1.Location = new System.Drawing.Point(19, 96);
             this.panel1.Name = "panel1";
             this.panel1.Size = new System.Drawing.Size(628, 436);
             this.panel1.TabIndex = 49;
             // 
             // label11
             // 
             this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label11.Location = new System.Drawing.Point(36, 243);
             this.label11.Name = "label11";
             this.label11.Size = new System.Drawing.Size(548, 23);
             this.label11.TabIndex = 41;
             this.label11.Text = "Выберите среди каких приказов искать (один или более)\r\n";
             // 
             // label10
             // 
             this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label10.Location = new System.Drawing.Point(36, 203);
             this.label10.Name = "label10";
             this.label10.Size = new System.Drawing.Size(100, 23);
             this.label10.TabIndex = 40;
             this.label10.Text = "Статус приказа:\r\n";
             // 
             // label8
             // 
             this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label8.Location = new System.Drawing.Point(36, 123);
             this.label8.Name = "label8";
             this.label8.Size = new System.Drawing.Size(169, 23);
             this.label8.TabIndex = 39;
             this.label8.Text = "Данные о приказе:\r\n";
             // 
             // label5
             // 
             this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                 System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label5.Location = new System.Drawing.Point(36, 12);
             this.label5.Name = "label5";
             this.label5.Size = new System.Drawing.Size(177, 23);
             this.label5.TabIndex = 38;
             this.label5.Text = "Данные о сотруднике:\r\n";
             // 
             // SearchPrikaz
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.BackColor = System.Drawing.SystemColors.ControlLight;
             this.ClientSize = new System.Drawing.Size(1373, 714);
             this.Controls.Add(this.panel1);
             this.Controls.Add(this.label9);
             this.Controls.Add(this.buttonBack);
             this.Controls.Add(this.button2);
             this.Controls.Add(this.label4);
             this.Controls.Add(this.dataGridView_family);
             this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
             this.Margin = new System.Windows.Forms.Padding(2);
             this.Name = "SearchPrikaz";
             this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
             this.Text = "Поиск приказов";
             ((System.ComponentModel.ISupportInitialize) (this.dataGridView_family)).EndInit();
             this.panel1.ResumeLayout(false);
             this.panel1.PerformLayout();
             this.ResumeLayout(false);
         }

         #endregion

        private WindowsFormsApp1.CalendarColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TabNumber;

        private System.Windows.Forms.DataGridView dataGridView_family;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox otchestvo;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_Confirm;
        private System.Windows.Forms.DateTimePicker dateTimePickerOt;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.CheckBox checkBoxPriem;
        private System.Windows.Forms.CheckBox checkBoxDelWork;
        private System.Windows.Forms.CheckBox checkBoxKomand;
        private System.Windows.Forms.CheckBox checkBoxPerevod;
        private System.Windows.Forms.Label label7;
        private System.Collections.ArrayList _list;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}