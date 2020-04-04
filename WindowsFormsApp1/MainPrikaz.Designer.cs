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
            this.deletework = new System.Windows.Forms.RadioButton();
            this.comandirovka = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
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
            this.firstname.Location = new System.Drawing.Point(289, 100);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(151, 23);
            this.firstname.TabIndex = 1;
            // 
            // otchestvo
            // 
            this.otchestvo.Location = new System.Drawing.Point(507, 100);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(151, 23);
            this.otchestvo.TabIndex = 2;
            // 
            // dataGridView_family
            // 
            this.dataGridView_family.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_family.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.Column1, this.Column2, this.Column3});
            this.dataGridView_family.Location = new System.Drawing.Point(66, 177);
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
            this.label1.Location = new System.Drawing.Point(66, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(289, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(507, 127);
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
            this.label4.Text = "Поиск сотрудника";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priem
            // 
            this.priem.Checked = true;
            this.priem.Location = new System.Drawing.Point(932, 90);
            this.priem.Name = "priem";
            this.priem.Size = new System.Drawing.Size(196, 52);
            this.priem.TabIndex = 25;
            this.priem.TabStop = true;
            this.priem.Text = "Приказ о приеме на работу";
            this.priem.UseVisualStyleBackColor = true;
            // 
            // deletework
            // 
            this.deletework.Location = new System.Drawing.Point(932, 137);
            this.deletework.Name = "deletework";
            this.deletework.Size = new System.Drawing.Size(211, 52);
            this.deletework.TabIndex = 26;
            this.deletework.Text = "Приказ об увольнении с работы";
            this.deletework.UseVisualStyleBackColor = true;
            // 
            // comandirovka
            // 
            this.comandirovka.Location = new System.Drawing.Point(932, 181);
            this.comandirovka.Name = "comandirovka";
            this.comandirovka.Size = new System.Drawing.Size(211, 52);
            this.comandirovka.TabIndex = 27;
            this.comandirovka.Text = "Приказ о командировке";
            this.comandirovka.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(992, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 54);
            this.button2.TabIndex = 28;
            this.button2.Text = "Перейти к формированию приказа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1238, 1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 28);
            this.buttonBack.TabIndex = 45;
            this.buttonBack.Text = "назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MainPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comandirovka);
            this.Controls.Add(this.deletework);
            this.Controls.Add(this.priem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_family);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.fullname);
            this.Name = "MainPrikaz";
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
        private System.Windows.Forms.RadioButton comandirovka;
        private System.Windows.Forms.RadioButton deletework;
        private System.Windows.Forms.RadioButton priem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBack;
    }
}