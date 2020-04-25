using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class MainPrikaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.priem = new System.Windows.Forms.RadioButton();
            this.perevod = new System.Windows.Forms.RadioButton();
            this.deletework = new System.Windows.Forms.RadioButton();
            this.comandirovka = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_family)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(23, 48);
            this.fullname.Margin = new System.Windows.Forms.Padding(2);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(172, 23);
            this.fullname.TabIndex = 0;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(218, 48);
            this.firstname.Margin = new System.Windows.Forms.Padding(2);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(163, 23);
            this.firstname.TabIndex = 1;
            // 
            // otchestvo
            // 
            this.otchestvo.Location = new System.Drawing.Point(408, 48);
            this.otchestvo.Margin = new System.Windows.Forms.Padding(2);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(168, 23);
            this.otchestvo.TabIndex = 2;
            // 
            // dataGridView_family
            // 
            this.dataGridView_family.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_family.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.Column1, this.Column2, this.Column3});
            this.dataGridView_family.Location = new System.Drawing.Point(24, 117);
            this.dataGridView_family.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_family.Name = "dataGridView_family";
            this.dataGridView_family.Size = new System.Drawing.Size(554, 278);
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
            this.Column2.HeaderText = "Дата рождения";
            this.Column2.Name = "Column2";
            this.Column2.Width = 86;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Табельный номер";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(219, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(408, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(23, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "*Введите данные для поиска сотрудника";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priem
            // 
            this.priem.Checked = true;
            this.priem.Location = new System.Drawing.Point(815, 84);
            this.priem.Margin = new System.Windows.Forms.Padding(2);
            this.priem.Name = "priem";
            this.priem.Size = new System.Drawing.Size(171, 48);
            this.priem.TabIndex = 25;
            this.priem.TabStop = true;
            this.priem.Text = "Приказ о приеме на работу";
            this.priem.UseVisualStyleBackColor = true;
            // 
            // perevod
            // 
            this.perevod.Location = new System.Drawing.Point(815, 211);
            this.perevod.Margin = new System.Windows.Forms.Padding(2);
            this.perevod.Name = "perevod";
            this.perevod.Size = new System.Drawing.Size(184, 48);
            this.perevod.TabIndex = 27;
            this.perevod.Text = "Приказ о переводе";
            this.perevod.UseVisualStyleBackColor = true;
            // 
            // deletework
            // 
            this.deletework.Location = new System.Drawing.Point(815, 128);
            this.deletework.Margin = new System.Windows.Forms.Padding(2);
            this.deletework.Name = "deletework";
            this.deletework.Size = new System.Drawing.Size(184, 48);
            this.deletework.TabIndex = 26;
            this.deletework.Text = "Приказ об увольнении с работы";
            this.deletework.UseVisualStyleBackColor = true;
            // 
            // comandirovka
            // 
            this.comandirovka.Location = new System.Drawing.Point(815, 170);
            this.comandirovka.Margin = new System.Windows.Forms.Padding(2);
            this.comandirovka.Name = "comandirovka";
            this.comandirovka.Size = new System.Drawing.Size(184, 48);
            this.comandirovka.TabIndex = 27;
            this.comandirovka.Text = "Приказ о командировке";
            this.comandirovka.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(815, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Перейти к формированию приказа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(836, 417);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 27);
            this.buttonBack.TabIndex = 45;
            this.buttonBack.Text = "назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_family);
            this.panel1.Controls.Add(this.otchestvo);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.fullname);
            this.panel1.Location = new System.Drawing.Point(34, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 440);
            this.panel1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "*Выберите сотруднка для формирования приказа";
            // 
            // MainPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1042, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comandirovka);
            this.Controls.Add(this.perevod);
            this.Controls.Add(this.deletework);
            this.Controls.Add(this.priem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPrikaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование приказа";
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
        private System.Windows.Forms.RadioButton comandirovka;
        private System.Windows.Forms.RadioButton deletework;
        private System.Windows.Forms.RadioButton priem;
        private System.Windows.Forms.RadioButton perevod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}