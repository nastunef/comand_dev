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
            this.SuspendLayout();
            // 
            // NameJobPosition
            // 
            this.NameJobPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.NameJobPosition.Location = new System.Drawing.Point(25, 22);
            this.NameJobPosition.Name = "NameJobPosition";
            this.NameJobPosition.Size = new System.Drawing.Size(472, 62);
            this.NameJobPosition.TabIndex = 0;
            this.NameJobPosition.Text = "Наименование";
            this.NameJobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codeJob
            // 
            this.codeJob.Location = new System.Drawing.Point(286, 118);
            this.codeJob.Name = "codeJob";
            this.codeJob.Size = new System.Drawing.Size(141, 22);
            this.codeJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(120, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddJobPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 287);
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
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label NameJobPosition;

        #endregion
    }
}