namespace Komandirovki
{
    partial class KomandirovkaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.placesView = new System.Windows.Forms.DataGridView();
            this.Counrty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CityColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OrganizationColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PodrazdelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobPosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurposeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.finishDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.isSameDatesCheckBox = new System.Windows.Forms.CheckBox();
            this.PurposeCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PurposeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FinanceCheckBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FinanceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumPrikazTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DatePrikaz = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.DateReason = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.ReasonTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.AddPlaceButton = new System.Windows.Forms.Button();
            this.DeletePlaceButton = new System.Windows.Forms.Button();
            this.DeleteWorkerButton = new System.Windows.Forms.Button();
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.isDateReasonCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.placesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Места назначения";
            // 
            // placesView
            // 
            this.placesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.placesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Counrty,
            this.CityColumn,
            this.OrganizationColumn});
            this.placesView.Location = new System.Drawing.Point(9, 28);
            this.placesView.Name = "placesView";
            this.placesView.Size = new System.Drawing.Size(836, 105);
            this.placesView.TabIndex = 1;
            // 
            // Counrty
            // 
            this.Counrty.HeaderText = "Страна";
            this.Counrty.Items.AddRange(new object[] {
            "Казахстан",
            "Россия",
            "Украина"});
            this.Counrty.Name = "Counrty";
            this.Counrty.Sorted = true;
            this.Counrty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Counrty.Width = 200;
            // 
            // CityColumn
            // 
            this.CityColumn.HeaderText = "Город";
            this.CityColumn.Name = "CityColumn";
            this.CityColumn.Width = 200;
            // 
            // OrganizationColumn
            // 
            this.OrganizationColumn.HeaderText = "Организация";
            this.OrganizationColumn.Name = "OrganizationColumn";
            this.OrganizationColumn.Width = 200;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIOColumn,
            this.TabNumColumn,
            this.PodrazdelColumn,
            this.JobPosColumn,
            this.StartDateColumn,
            this.FinishDateColumn,
            this.PurposeColumn,
            this.FinanceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(8, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(936, 134);
            this.dataGridView1.TabIndex = 7;
            // 
            // FIOColumn
            // 
            this.FIOColumn.HeaderText = "ФИО";
            this.FIOColumn.Name = "FIOColumn";
            this.FIOColumn.ReadOnly = true;
            this.FIOColumn.Width = 59;
            // 
            // TabNumColumn
            // 
            this.TabNumColumn.HeaderText = "Таб.номер";
            this.TabNumColumn.Name = "TabNumColumn";
            this.TabNumColumn.ReadOnly = true;
            this.TabNumColumn.Width = 86;
            // 
            // PodrazdelColumn
            // 
            this.PodrazdelColumn.HeaderText = "Подразделение";
            this.PodrazdelColumn.Name = "PodrazdelColumn";
            this.PodrazdelColumn.ReadOnly = true;
            this.PodrazdelColumn.Width = 112;
            // 
            // JobPosColumn
            // 
            this.JobPosColumn.HeaderText = "Должность";
            this.JobPosColumn.Name = "JobPosColumn";
            this.JobPosColumn.ReadOnly = true;
            this.JobPosColumn.Width = 90;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.HeaderText = "Дата начала";
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.Width = 96;
            // 
            // FinishDateColumn
            // 
            this.FinishDateColumn.HeaderText = "Дата окончания";
            this.FinishDateColumn.Name = "FinishDateColumn";
            this.FinishDateColumn.Width = 114;
            // 
            // PurposeColumn
            // 
            this.PurposeColumn.HeaderText = "Цель";
            this.PurposeColumn.Name = "PurposeColumn";
            this.PurposeColumn.Width = 58;
            // 
            // FinanceColumn
            // 
            this.FinanceColumn.HeaderText = "За счёт средств";
            this.FinanceColumn.Name = "FinanceColumn";
            this.FinanceColumn.Width = 114;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Список работников";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.finishDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 73);
            this.panel1.TabIndex = 12;
            // 
            // finishDate
            // 
            this.finishDate.Location = new System.Drawing.Point(96, 41);
            this.finishDate.Name = "finishDate";
            this.finishDate.Size = new System.Drawing.Size(145, 20);
            this.finishDate.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата окончания:";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(96, 10);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(145, 20);
            this.startDate.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата начала:\r\n";
            // 
            // isSameDatesCheckBox
            // 
            this.isSameDatesCheckBox.Location = new System.Drawing.Point(9, 306);
            this.isSameDatesCheckBox.Name = "isSameDatesCheckBox";
            this.isSameDatesCheckBox.Size = new System.Drawing.Size(192, 16);
            this.isSameDatesCheckBox.TabIndex = 15;
            this.isSameDatesCheckBox.Text = "Дата окончания одна для всех\r\n";
            this.isSameDatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // PurposeCheckBox
            // 
            this.PurposeCheckBox.Location = new System.Drawing.Point(275, 306);
            this.PurposeCheckBox.Name = "PurposeCheckBox";
            this.PurposeCheckBox.Size = new System.Drawing.Size(192, 16);
            this.PurposeCheckBox.TabIndex = 17;
            this.PurposeCheckBox.Text = "Цель одна для всех";
            this.PurposeCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PurposeTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(274, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 73);
            this.panel2.TabIndex = 16;
            // 
            // PurposeTextBox
            // 
            this.PurposeTextBox.Location = new System.Drawing.Point(40, 7);
            this.PurposeTextBox.Multiline = true;
            this.PurposeTextBox.Name = "PurposeTextBox";
            this.PurposeTextBox.Size = new System.Drawing.Size(216, 59);
            this.PurposeTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цель:";
            // 
            // FinanceCheckBox
            // 
            this.FinanceCheckBox.Location = new System.Drawing.Point(580, 306);
            this.FinanceCheckBox.Name = "FinanceCheckBox";
            this.FinanceCheckBox.Size = new System.Drawing.Size(192, 16);
            this.FinanceCheckBox.TabIndex = 19;
            this.FinanceCheckBox.Text = "Источник средств один на всех";
            this.FinanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.FinanceTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(579, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 73);
            this.panel3.TabIndex = 18;
            // 
            // FinanceTextBox
            // 
            this.FinanceTextBox.Location = new System.Drawing.Point(102, 6);
            this.FinanceTextBox.Multiline = true;
            this.FinanceTextBox.Name = "FinanceTextBox";
            this.FinanceTextBox.Size = new System.Drawing.Size(216, 59);
            this.FinanceTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "За счёт средств:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Приказ №";
            // 
            // NumPrikazTextBox
            // 
            this.NumPrikazTextBox.Location = new System.Drawing.Point(79, 422);
            this.NumPrikazTextBox.Name = "NumPrikazTextBox";
            this.NumPrikazTextBox.Size = new System.Drawing.Size(84, 20);
            this.NumPrikazTextBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(178, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "от";
            // 
            // DatePrikaz
            // 
            this.DatePrikaz.Location = new System.Drawing.Point(197, 422);
            this.DatePrikaz.Name = "DatePrikaz";
            this.DatePrikaz.Size = new System.Drawing.Size(147, 20);
            this.DatePrikaz.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Основание (служебное задание, другое основание):\r\n";
            // 
            // DateReason
            // 
            this.DateReason.CausesValidation = false;
            this.DateReason.Checked = false;
            this.DateReason.Location = new System.Drawing.Point(876, 457);
            this.DateReason.Name = "DateReason";
            this.DateReason.Size = new System.Drawing.Size(139, 20);
            this.DateReason.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(822, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "от";
            // 
            // ReasonTextBox
            // 
            this.ReasonTextBox.Location = new System.Drawing.Point(278, 457);
            this.ReasonTextBox.Name = "ReasonTextBox";
            this.ReasonTextBox.Size = new System.Drawing.Size(540, 20);
            this.ReasonTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label11.Location = new System.Drawing.Point(808, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "(поставить галочку и указать при наличии)";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(11, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Примечание:";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(12, 512);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(1003, 62);
            this.NoteTextBox.TabIndex = 30;
            // 
            // AddPlaceButton
            // 
            this.AddPlaceButton.Location = new System.Drawing.Point(858, 28);
            this.AddPlaceButton.Name = "AddPlaceButton";
            this.AddPlaceButton.Size = new System.Drawing.Size(86, 35);
            this.AddPlaceButton.TabIndex = 32;
            this.AddPlaceButton.Text = "Добавить";
            this.AddPlaceButton.UseVisualStyleBackColor = true;
            this.AddPlaceButton.Click += new System.EventHandler(this.AddPlaceButton_Click);
            // 
            // DeletePlaceButton
            // 
            this.DeletePlaceButton.Location = new System.Drawing.Point(858, 68);
            this.DeletePlaceButton.Name = "DeletePlaceButton";
            this.DeletePlaceButton.Size = new System.Drawing.Size(86, 36);
            this.DeletePlaceButton.TabIndex = 33;
            this.DeletePlaceButton.Text = "Удалить выделенную";
            this.DeletePlaceButton.UseVisualStyleBackColor = true;
            // 
            // DeleteWorkerButton
            // 
            this.DeleteWorkerButton.Location = new System.Drawing.Point(949, 192);
            this.DeleteWorkerButton.Name = "DeleteWorkerButton";
            this.DeleteWorkerButton.Size = new System.Drawing.Size(82, 36);
            this.DeleteWorkerButton.TabIndex = 35;
            this.DeleteWorkerButton.Text = "Удалить выделенную";
            this.DeleteWorkerButton.UseVisualStyleBackColor = true;
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(949, 153);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(82, 35);
            this.AddWorkerButton.TabIndex = 34;
            this.AddWorkerButton.Text = "Добавить";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 588);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 36;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(93, 588);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(130, 25);
            this.ExportButton.TabIndex = 37;
            this.ExportButton.Text = "Экспорт в документ";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(228, 588);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 25);
            this.ExitButton.TabIndex = 38;
            this.ExitButton.Text = "Выйти без сохранения";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DeleteButton.Location = new System.Drawing.Point(885, 588);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 25);
            this.DeleteButton.TabIndex = 39;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // isDateReasonCheckBox
            // 
            this.isDateReasonCheckBox.Checked = true;
            this.isDateReasonCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDateReasonCheckBox.Location = new System.Drawing.Point(849, 457);
            this.isDateReasonCheckBox.Name = "isDateReasonCheckBox";
            this.isDateReasonCheckBox.Size = new System.Drawing.Size(21, 20);
            this.isDateReasonCheckBox.TabIndex = 40;
            this.isDateReasonCheckBox.UseVisualStyleBackColor = true;
            // 
            // KomandirovkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 633);
            this.Controls.Add(this.isDateReasonCheckBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteWorkerButton);
            this.Controls.Add(this.AddWorkerButton);
            this.Controls.Add(this.DeletePlaceButton);
            this.Controls.Add(this.AddPlaceButton);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ReasonTextBox);
            this.Controls.Add(this.DateReason);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DatePrikaz);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumPrikazTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FinanceCheckBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PurposeCheckBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.isSameDatesCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.placesView);
            this.Controls.Add(this.label1);
            this.Name = "KomandirovkaForm";
            this.Text = "Командировка";
            ((System.ComponentModel.ISupportInitialize)(this.placesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker finishDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView placesView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PodrazdelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TabNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOColumn;
        private System.Windows.Forms.CheckBox isSameDatesCheckBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn OrganizationColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CityColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Counrty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurposeColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinanceColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DeletePlaceButton;
        private System.Windows.Forms.Button AddPlaceButton;
        private System.Windows.Forms.Button AddWorkerButton;
        private System.Windows.Forms.Button DeleteWorkerButton;
        private System.Windows.Forms.CheckBox isDateReasonCheckBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.DateTimePicker DateReason;
        private System.Windows.Forms.TextBox ReasonTextBox;
        private System.Windows.Forms.DateTimePicker DatePrikaz;
        private System.Windows.Forms.TextBox NumPrikazTextBox;
        private System.Windows.Forms.CheckBox FinanceCheckBox;
        private System.Windows.Forms.TextBox FinanceTextBox;
        private System.Windows.Forms.TextBox PurposeTextBox;
        private System.Windows.Forms.CheckBox PurposeCheckBox;
    }
}