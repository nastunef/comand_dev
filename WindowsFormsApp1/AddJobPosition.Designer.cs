using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class AddJobPosition
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
            this.NameJobPosition = new System.Windows.Forms.Label();
            this.codeJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateUprazd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // NameJobPosition
            // 
            this.NameJobPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.NameJobPosition.Location = new System.Drawing.Point(22, 9);
            this.NameJobPosition.Name = "NameJobPosition";
            this.NameJobPosition.Size = new System.Drawing.Size(472, 62);
            this.NameJobPosition.TabIndex = 0;
            this.NameJobPosition.Text = "Наименование";
            this.NameJobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codeJob
            // 
            this.codeJob.Location = new System.Drawing.Point(285, 88);
            this.codeJob.Name = "codeJob";
            this.codeJob.Size = new System.Drawing.Size(141, 22);
            this.codeJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(90, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(90, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата создания";
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(285, 127);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(170, 22);
            this.dateCreate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(90, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата упразднения";
            // 
            // dateUprazd
            // 
            this.dateUprazd.Location = new System.Drawing.Point(285, 172);
            this.dateUprazd.Name = "dateUprazd";
            this.dateUprazd.Size = new System.Drawing.Size(170, 22);
            this.dateUprazd.TabIndex = 7;
            // 
            // AddJobPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 287);
            this.Controls.Add(this.dateUprazd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeJob);
            this.Controls.Add(this.NameJobPosition);
            this.Name = "AddJobPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить должность";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codeJob;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.DateTimePicker dateUprazd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label NameJobPosition;

        #endregion
    }
}