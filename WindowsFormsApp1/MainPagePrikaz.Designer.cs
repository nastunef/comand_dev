using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class MainPagePrikaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.createPrikaz = new System.Windows.Forms.Button();
            this.searchPrikaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модуль работы с приказами";
            // 
            // createPrikaz
            // 
            this.createPrikaz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.createPrikaz.Location = new System.Drawing.Point(190, 151);
            this.createPrikaz.Name = "createPrikaz";
            this.createPrikaz.Size = new System.Drawing.Size(274, 73);
            this.createPrikaz.TabIndex = 1;
            this.createPrikaz.Text = "Составление приказов";
            this.createPrikaz.UseVisualStyleBackColor = true;
            this.createPrikaz.Click += new System.EventHandler(this.createPrikaz_Click);
            // 
            // searchPrikaz
            // 
            this.searchPrikaz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.searchPrikaz.Location = new System.Drawing.Point(770, 151);
            this.searchPrikaz.Name = "searchPrikaz";
            this.searchPrikaz.Size = new System.Drawing.Size(274, 73);
            this.searchPrikaz.TabIndex = 2;
            this.searchPrikaz.Text = "Поиск приказов";
            this.searchPrikaz.UseVisualStyleBackColor = true;
            this.searchPrikaz.Click += new System.EventHandler(this.searchPrikaz_Click);
            // 
            // MainPagePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1455, 738);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            this.Controls.Add(this.searchPrikaz);
            this.Controls.Add(this.createPrikaz);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainPagePrikaz";
            this.Text = "Приказы";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button createPrikaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPrikaz;

        #endregion

        private WindowsFormsApp1.SearchPrikaz _searchPrikaz;
        private WindowsFormsApp1.MainPrikaz _mainPrikaz;
    }
}