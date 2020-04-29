using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class AddPodrazdel
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
            this.NamePodrazdel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codePodrazdel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPodrazdel = new System.Windows.Forms.ComboBox();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateUprazd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // NamePodrazdel
            // 
            this.NamePodrazdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.NamePodrazdel.Location = new System.Drawing.Point(69, 19);
            this.NamePodrazdel.Name = "NamePodrazdel";
            this.NamePodrazdel.Size = new System.Drawing.Size(439, 36);
            this.NamePodrazdel.TabIndex = 0;
            this.NamePodrazdel.Text = "Наименование ";
            this.NamePodrazdel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(69, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код подразделения";
            // 
            // codePodrazdel
            // 
            this.codePodrazdel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codePodrazdel.Location = new System.Drawing.Point(330, 105);
            this.codePodrazdel.Name = "codePodrazdel";
            this.codePodrazdel.Size = new System.Drawing.Size(178, 22);
            this.codePodrazdel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(69, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата создания";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(69, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Главное подразделение";
            // 
            // mainPodrazdel
            // 
            this.mainPodrazdel.FormattingEnabled = true;
            this.mainPodrazdel.Location = new System.Drawing.Point(330, 238);
            this.mainPodrazdel.Name = "mainPodrazdel";
            this.mainPodrazdel.Size = new System.Drawing.Size(178, 24);
            this.mainPodrazdel.TabIndex = 5;
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(330, 153);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(178, 22);
            this.dateCreate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.Location = new System.Drawing.Point(195, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(69, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата упразднения";
            // 
            // dateUprazd
            // 
            this.dateUprazd.Location = new System.Drawing.Point(330, 193);
            this.dateUprazd.Name = "dateUprazd";
            this.dateUprazd.Size = new System.Drawing.Size(178, 22);
            this.dateUprazd.TabIndex = 11;
            // 
            // AddPodrazdel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 362);
            this.Controls.Add(this.dateUprazd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.mainPodrazdel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codePodrazdel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamePodrazdel);
            this.Name = "AddPodrazdel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить подразделение";
            this.Load += new System.EventHandler(this.AddPodrazdel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codePodrazdel;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.DateTimePicker dateUprazd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mainPodrazdel;
        public System.Windows.Forms.Label NamePodrazdel;

        #endregion
    }
}