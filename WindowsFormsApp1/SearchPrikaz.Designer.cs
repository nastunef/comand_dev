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
             this.fullname.Location = new System.Drawing.Point(57, 87);
             this.fullname.Name = "fullname";
             this.fullname.Size = new System.Drawing.Size(130, 20);
             this.fullname.TabIndex = 0;
             // 
             // firstname
             // 
             this.firstname.Location = new System.Drawing.Point(57, 134);
             this.firstname.Name = "firstname";
             this.firstname.Size = new System.Drawing.Size(130, 20);
             this.firstname.TabIndex = 1;
             // 
             // otchestvo
             // 
             this.otchestvo.Location = new System.Drawing.Point(57, 182);
             this.otchestvo.Name = "otchestvo";
             this.otchestvo.Size = new System.Drawing.Size(130, 20);
             this.otchestvo.TabIndex = 2;
             // 
             // dataGridView_family
             // 
             this.dataGridView_family.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
             this.dataGridView_family.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Column1, this.Column2, this.Column3, this.Column4});
             this.dataGridView_family.Location = new System.Drawing.Point(57, 245);
             this.dataGridView_family.Name = "dataGridView_family";
             this.dataGridView_family.Size = new System.Drawing.Size(507, 257);
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
             this.Column2.Width = 96;
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
             this.label1.Location = new System.Drawing.Point(57, 110);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(129, 23);
             this.label1.TabIndex = 20;
             this.label1.Text = "Фамилия";
             // 
             // label2
             // 
             this.label2.Location = new System.Drawing.Point(57, 158);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(129, 23);
             this.label2.TabIndex = 21;
             this.label2.Text = "Имя";
             // 
             // label3
             // 
             this.label3.Location = new System.Drawing.Point(57, 205);
             this.label3.Name = "label3";
             this.label3.Size = new System.Drawing.Size(129, 23);
             this.label3.TabIndex = 22;
             this.label3.Text = "Отчество";
             // 
             // label4
             // 
             this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label4.Location = new System.Drawing.Point(57, 19);
             this.label4.Name = "label4";
             this.label4.Size = new System.Drawing.Size(183, 42);
             this.label4.TabIndex = 23;
             this.label4.Text = "Поиск приказов";
             // 
             // button1
             // 
             this.button1.Location = new System.Drawing.Point(691, 205);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(67, 23);
             this.button1.TabIndex = 24;
             this.button1.Text = "поиск";
             this.button1.UseVisualStyleBackColor = true;
             this.button1.Click += new System.EventHandler(this.button1_Click);
             // 
             // button2
             // 
             this.button2.Location = new System.Drawing.Point(641, 456);
             this.button2.Name = "button2";
             this.button2.Size = new System.Drawing.Size(117, 47);
             this.button2.TabIndex = 28;
             this.button2.Text = "Перейти к выбранному приказу";
             this.button2.UseVisualStyleBackColor = true;
             this.button2.Click += new System.EventHandler(this.button2_Click);
             // 
             // checkBoxPriem
             // 
             this.checkBoxPriem.Location = new System.Drawing.Point(221, 81);
             this.checkBoxPriem.Name = "checkBoxPriem";
             this.checkBoxPriem.Size = new System.Drawing.Size(169, 42);
             this.checkBoxPriem.TabIndex = 29;
             this.checkBoxPriem.Text = "Приказ о приеме на работу";
             this.checkBoxPriem.UseVisualStyleBackColor = true;
             // 
             // checkBoxDelWork
             // 
             this.checkBoxDelWork.Location = new System.Drawing.Point(221, 172);
             this.checkBoxDelWork.Name = "checkBoxDelWork";
             this.checkBoxDelWork.Size = new System.Drawing.Size(181, 42);
             this.checkBoxDelWork.TabIndex = 30;
             this.checkBoxDelWork.Text = "Приказ об увольнении с работы";
             this.checkBoxDelWork.UseVisualStyleBackColor = true;
             // 
             // checkBoxKomand
             // 
             this.checkBoxKomand.Location = new System.Drawing.Point(221, 123);
             this.checkBoxKomand.Name = "checkBoxKomand";
             this.checkBoxKomand.Size = new System.Drawing.Size(149, 42);
             this.checkBoxKomand.TabIndex = 31;
             this.checkBoxKomand.Text = "Приказ о командировке";
             this.checkBoxKomand.UseVisualStyleBackColor = true;
             // 
             // dateTimePickerOt
             // 
             this.dateTimePickerOt.Location = new System.Drawing.Point(454, 114);
             this.dateTimePickerOt.Name = "dateTimePickerOt";
             this.dateTimePickerOt.Size = new System.Drawing.Size(109, 20);
             this.dateTimePickerOt.TabIndex = 32;
             // 
             // dateTimePickerDo
             // 
             this.dateTimePickerDo.Location = new System.Drawing.Point(454, 144);
             this.dateTimePickerDo.Name = "dateTimePickerDo";
             this.dateTimePickerDo.Size = new System.Drawing.Size(109, 20);
             this.dateTimePickerDo.TabIndex = 33;
             // 
             // label5
             // 
             this.label5.Location = new System.Drawing.Point(421, 117);
             this.label5.Name = "label5";
             this.label5.Size = new System.Drawing.Size(19, 16);
             this.label5.TabIndex = 34;
             this.label5.Text = "от";
             // 
             // label6
             // 
             this.label6.Location = new System.Drawing.Point(422, 144);
             this.label6.Name = "label6";
             this.label6.Size = new System.Drawing.Size(19, 16);
             this.label6.TabIndex = 35;
             this.label6.Text = "до";
             // 
             // checkBox_Confirm
             // 
             this.checkBox_Confirm.Location = new System.Drawing.Point(462, 194);
             this.checkBox_Confirm.Name = "checkBox_Confirm";
             this.checkBox_Confirm.Size = new System.Drawing.Size(101, 19);
             this.checkBox_Confirm.TabIndex = 36;
             this.checkBox_Confirm.Text = "Подтвержден";
             this.checkBox_Confirm.UseVisualStyleBackColor = true;
             // 
             // label7
             // 
             this.label7.Location = new System.Drawing.Point(453, 82);
             this.label7.Name = "label7";
             this.label7.Size = new System.Drawing.Size(109, 23);
             this.label7.TabIndex = 37;
             this.label7.Text = "Дата составления";
             // 
             // buttonBack
             // 
             this.buttonBack.Location = new System.Drawing.Point(1060, 1);
             this.buttonBack.Name = "buttonBack";
             this.buttonBack.Size = new System.Drawing.Size(97, 24);
             this.buttonBack.TabIndex = 45;
             this.buttonBack.Text = "назад";
             this.buttonBack.UseVisualStyleBackColor = true;
             this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
             // 
             // SearchPrikaz
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(1157, 632);
             this.Controls.Add(this.buttonBack);
             this.Controls.Add(this.label7);
             this.Controls.Add(this.checkBox_Confirm);
             this.Controls.Add(this.label6);
             this.Controls.Add(this.label5);
             this.Controls.Add(this.dateTimePickerDo);
             this.Controls.Add(this.dateTimePickerOt);
             this.Controls.Add(this.checkBoxKomand);
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
             this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
             this.Name = "SearchPrikaz";
             this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
             this.Text = "MainPrikaz";
             this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
             ((System.ComponentModel.ISupportInitialize) (this.dataGridView_family)).EndInit();
             this.ResumeLayout(false);
             this.PerformLayout();
         }

         private System.Windows.Forms.Button button1;
         private System.Windows.Forms.Button button2;
         private System.Windows.Forms.Button buttonBack;
         private System.Windows.Forms.CheckBox checkBox_Confirm;
         private System.Windows.Forms.CheckBox checkBoxDelWork;
         private System.Windows.Forms.CheckBox checkBoxKomand;
         private System.Windows.Forms.CheckBox checkBoxPriem;
         private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
         private WindowsFormsApp1.CalendarColumn Column2;
         private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
         private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
         private System.Windows.Forms.DataGridView dataGridView_family;
         private System.Windows.Forms.DateTimePicker dateTimePickerDo;
         private System.Windows.Forms.DateTimePicker dateTimePickerOt;
         private System.Windows.Forms.TextBox firstname;
         private System.Windows.Forms.TextBox fullname;
         private System.Windows.Forms.Label label1;
         private System.Windows.Forms.Label label2;
         private System.Windows.Forms.Label label3;
         private System.Windows.Forms.Label label4;
         private System.Windows.Forms.Label label5;
         private System.Windows.Forms.Label label6;
         private System.Windows.Forms.Label label7;
         private System.Windows.Forms.TextBox otchestvo;

         #endregion

         private System.Windows.Forms.DataGridViewTextBoxColumn TabNumber;

         private System.Collections.ArrayList _list;
    }
}