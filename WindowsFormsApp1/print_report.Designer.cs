using System.ComponentModel;

namespace WindowsFormsApp1
{
	partial class print_report
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
			this.comboBox_middlenameValue = new System.Windows.Forms.ComboBox();
			this.comboBox_nameValue = new System.Windows.Forms.ComboBox();
			this.comboBox_surnameValue = new System.Windows.Forms.ComboBox();
			this.button_run = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.comboBox_middlenameValue);
			this.panel1.Controls.Add(this.comboBox_nameValue);
			this.panel1.Controls.Add(this.comboBox_surnameValue);
			this.panel1.Controls.Add(this.button_run);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(10, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(510, 215);
			this.panel1.TabIndex = 0;
			// 
			// comboBox_middlenameValue
			// 
			this.comboBox_middlenameValue.FormattingEnabled = true;
			this.comboBox_middlenameValue.Location = new System.Drawing.Point(113, 70);
			this.comboBox_middlenameValue.Name = "comboBox_middlenameValue";
			this.comboBox_middlenameValue.Size = new System.Drawing.Size(180, 21);
			this.comboBox_middlenameValue.Sorted = true;
			this.comboBox_middlenameValue.TabIndex = 87;
			// 
			// comboBox_nameValue
			// 
			this.comboBox_nameValue.FormattingEnabled = true;
			this.comboBox_nameValue.Location = new System.Drawing.Point(115, 40);
			this.comboBox_nameValue.Name = "comboBox_nameValue";
			this.comboBox_nameValue.Size = new System.Drawing.Size(180, 21);
			this.comboBox_nameValue.Sorted = true;
			this.comboBox_nameValue.TabIndex = 86;
			// 
			// comboBox_surnameValue
			// 
			this.comboBox_surnameValue.FormattingEnabled = true;
			this.comboBox_surnameValue.Location = new System.Drawing.Point(115, 10);
			this.comboBox_surnameValue.Name = "comboBox_surnameValue";
			this.comboBox_surnameValue.Size = new System.Drawing.Size(180, 21);
			this.comboBox_surnameValue.Sorted = true;
			this.comboBox_surnameValue.TabIndex = 85;
			// 
			// button_run
			// 
			this.button_run.Location = new System.Drawing.Point(15, 98);
			this.button_run.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.button_run.Name = "button_run";
			this.button_run.Size = new System.Drawing.Size(232, 35);
			this.button_run.TabIndex = 84;
			this.button_run.Text = "Выполнить";
			this.button_run.UseVisualStyleBackColor = true;
			this.button_run.Click += new System.EventHandler(this.button_run_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(10, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 25);
			this.label5.TabIndex = 80;
			this.label5.Text = "Имя";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(10, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 25);
			this.label4.TabIndex = 79;
			this.label4.Text = "Отчество";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(10, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 25);
			this.label3.TabIndex = 78;
			this.label3.Text = "Фамилия";
			// 
			// print_report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 237);
			this.Controls.Add(this.panel1);
			this.Name = "print_report";
			this.Text = "Распечатка отчета";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button_run;
		private System.Windows.Forms.ComboBox comboBox_middlenameValue;
		private System.Windows.Forms.ComboBox comboBox_nameValue;
		private System.Windows.Forms.ComboBox comboBox_surnameValue;
	}
}