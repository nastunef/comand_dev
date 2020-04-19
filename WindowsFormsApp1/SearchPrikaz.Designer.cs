using System.Collections;
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
             this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
             this.label5 = new System.Windows.Forms.Label();
             this.label6 = new System.Windows.Forms.Label();
             this.checkBox_Confirm = new System.Windows.Forms.CheckBox();
             this.label7 = new System.Windows.Forms.Label();
             this.buttonBack = new System.Windows.Forms.Button();
             ((System.ComponentModel.ISupportInitialize) (this.dataGridView_family)).BeginInit();
             this.SuspendLayout();
             // 
             // fullname
             // 
             this.fullname.Location = new System.Drawing.Point(66, 100);
             this.fullname.Name = "fullname";
             this.fullname.Size = new System.Drawing.Size(151, 23);
             this.fullname.TabIndex = 0;
             // 
             // firstname
             // 
             this.firstname.Location = new System.Drawing.Point(66, 155);
             this.firstname.Name = "firstname";
             this.firstname.Size = new System.Drawing.Size(151, 23);
             this.firstname.TabIndex = 1;
             // 
             // otchestvo
             // 
             this.otchestvo.Location = new System.Drawing.Point(66, 210);
             this.otchestvo.Name = "otchestvo";
             this.otchestvo.Size = new System.Drawing.Size(151, 23);
             this.otchestvo.TabIndex = 2;
             // 
             // dataGridView_family
             // 
             this.dataGridView_family.ColumnHeadersHeightSizeMode =
                 System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
             this.dataGridView_family.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                 {this.Column1, this.Column2, this.Column3, this.Column4});
             this.dataGridView_family.Location = new System.Drawing.Point(66, 283);
             this.dataGridView_family.Name = "dataGridView_family";
             this.dataGridView_family.Size = new System.Drawing.Size(591, 297);
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
             this.label1.Location = new System.Drawing.Point(66, 127);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(150, 27);
             this.label1.TabIndex = 20;
             this.label1.Text = "Фамилия";
             // 
             // label2
             // 
             this.label2.Location = new System.Drawing.Point(66, 182);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(150, 27);
             this.label2.TabIndex = 21;
             this.label2.Text = "Имя";
             // 
             // label3
             // 
             this.label3.Location = new System.Drawing.Point(66, 237);
             this.label3.Name = "label3";
             this.label3.Size = new System.Drawing.Size(150, 27);
             this.label3.TabIndex = 22;
             this.label3.Text = "Отчество";
             // 
             // label4
             // 
             this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                 System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label4.Location = new System.Drawing.Point(66, 22);
             this.label4.Name = "label4";
             this.label4.Size = new System.Drawing.Size(213, 48);
             this.label4.TabIndex = 23;
             this.label4.Text = "Поиск приказов";
             // 
             // button1
             // 
             this.button1.Location = new System.Drawing.Point(806, 237);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(78, 27);
             this.button1.TabIndex = 24;
             this.button1.Text = "поиск";
             this.button1.UseVisualStyleBackColor = true;
             this.button1.Click += new System.EventHandler(this.button1_Click);
             // 
             // button2
             // 
             this.button2.Location = new System.Drawing.Point(748, 526);
             this.button2.Name = "button2";
             this.button2.Size = new System.Drawing.Size(136, 54);
             this.button2.TabIndex = 28;
             this.button2.Text = "Перейти к выбранному приказу";
             this.button2.UseVisualStyleBackColor = true;
             this.button2.Click += new System.EventHandler(this.button2_Click);
             // 
             // checkBoxPriem
             // 
             this.checkBoxPriem.Location = new System.Drawing.Point(258, 63);
             this.checkBoxPriem.Name = "checkBoxPriem";
             this.checkBoxPriem.Size = new System.Drawing.Size(197, 48);
             this.checkBoxPriem.TabIndex = 29;
             this.checkBoxPriem.Text = "Приказ о приеме на работу";
             this.checkBoxPriem.UseVisualStyleBackColor = true;
             // 
             // checkBoxDelWork
             // 
             this.checkBoxDelWork.Location = new System.Drawing.Point(258, 168);
             this.checkBoxDelWork.Name = "checkBoxDelWork";
             this.checkBoxDelWork.Size = new System.Drawing.Size(211, 48);
             this.checkBoxDelWork.TabIndex = 30;
             this.checkBoxDelWork.Text = "Приказ об увольнении с работы";
             this.checkBoxDelWork.UseVisualStyleBackColor = true;
             // 
             // checkBoxKomand
             // 
             this.checkBoxKomand.Location = new System.Drawing.Point(258, 112);
             this.checkBoxKomand.Name = "checkBoxKomand";
             this.checkBoxKomand.Size = new System.Drawing.Size(174, 48);
             this.checkBoxKomand.TabIndex = 31;
             this.checkBoxKomand.Text = "Приказ о командировке";
             this.checkBoxKomand.UseVisualStyleBackColor = true;
             // 
             // checkBoxPerevod
             // 
             this.checkBoxPerevod.Location = new System.Drawing.Point(258, 224);
             this.checkBoxPerevod.Name = "checkBoxPerevod";
             this.checkBoxPerevod.Size = new System.Drawing.Size(174, 48);
             this.checkBoxPerevod.TabIndex = 32;
             this.checkBoxPerevod.Text = "Приказ о переводе";
             this.checkBoxPerevod.UseVisualStyleBackColor = true;
             // 
             // dateTimePickerOt
             // 
             this.dateTimePickerOt.Location = new System.Drawing.Point(530, 132);
             this.dateTimePickerOt.Name = "dateTimePickerOt";
             this.dateTimePickerOt.Size = new System.Drawing.Size(126, 23);
             this.dateTimePickerOt.TabIndex = 32;
             // 
             // dateTimePickerDo
             // 
             this.dateTimePickerDo.Location = new System.Drawing.Point(530, 166);
             this.dateTimePickerDo.Name = "dateTimePickerDo";
             this.dateTimePickerDo.Size = new System.Drawing.Size(126, 23);
             this.dateTimePickerDo.TabIndex = 33;
             // 
             // label5
             // 
             this.label5.Location = new System.Drawing.Point(491, 135);
             this.label5.Name = "label5";
             this.label5.Size = new System.Drawing.Size(22, 18);
             this.label5.TabIndex = 34;
             this.label5.Text = "от";
             // 
             // label6
             // 
             this.label6.Location = new System.Drawing.Point(492, 166);
             this.label6.Name = "label6";
             this.label6.Size = new System.Drawing.Size(22, 18);
             this.label6.TabIndex = 35;
             this.label6.Text = "до";
             // 
             // checkBox_Confirm
             // 
             this.checkBox_Confirm.Location = new System.Drawing.Point(539, 224);
             this.checkBox_Confirm.Name = "checkBox_Confirm";
             this.checkBox_Confirm.Size = new System.Drawing.Size(118, 22);
             this.checkBox_Confirm.TabIndex = 36;
             this.checkBox_Confirm.Text = "Подтвержден";
             this.checkBox_Confirm.UseVisualStyleBackColor = true;
             // 
             // label7
             // 
             this.label7.Location = new System.Drawing.Point(528, 95);
             this.label7.Name = "label7";
             this.label7.Size = new System.Drawing.Size(127, 27);
             this.label7.TabIndex = 37;
             this.label7.Text = "Дата составления";
             // 
             // buttonBack
             // 
             this.buttonBack.Location = new System.Drawing.Point(1237, 1);
             this.buttonBack.Name = "buttonBack";
             this.buttonBack.Size = new System.Drawing.Size(113, 28);
             this.buttonBack.TabIndex = 45;
             this.buttonBack.Text = "назад";
             this.buttonBack.UseVisualStyleBackColor = true;
             this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
             // 
             // SearchPrikaz
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(1350, 729);
             this.Controls.Add(this.buttonBack);
             this.Controls.Add(this.label7);
             this.Controls.Add(this.checkBox_Confirm);
             this.Controls.Add(this.label6);
             this.Controls.Add(this.label5);
             this.Controls.Add(this.dateTimePickerDo);
             this.Controls.Add(this.dateTimePickerOt);
             this.Controls.Add(this.checkBoxKomand);
             this.Controls.Add(this.checkBoxPerevod);
             this.Controls.Add(this.checkBoxDelWork);
             this.Controls.Add(this.checkBoxPriem);
             this.Controls.Add(this.button2);
             this.Controls.Add(this.button1);
             this.Controls.Add(this.label4);
             this.Controls.Add(this.label3);
             this.Controls.Add(this.label2);
             this.Controls.Add(this.label1);
             this.Controls.Add(this.dataGridView_family);
             this.Controls.Add(this.otchestvo);
             this.Controls.Add(this.firstname);
             this.Controls.Add(this.fullname);
             this.Name = "SearchPrikaz";
             this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
             this.Text = "MainPrikaz";
             this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
             ((System.ComponentModel.ISupportInitialize) (this.dataGridView_family)).EndInit();
             this.ResumeLayout(false);
             this.PerformLayout();
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
        private System.Windows.Forms.Label label5;
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
    }
}