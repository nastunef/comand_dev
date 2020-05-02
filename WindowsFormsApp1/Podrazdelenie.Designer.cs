﻿using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Podrazdelenie
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
            this.namePodrazdel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataCreate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCnt = new System.Windows.Forms.TextBox();
            this.totalZm = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.nameChoose = new System.Windows.Forms.Label();
            this.oklad = new System.Windows.Forms.Label();
            this.Podrazdels = new System.Windows.Forms.TreeView();
            this.dateUprazd = new System.Windows.Forms.Label();
            this.dateUprazdText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateCreateT = new System.Windows.Forms.Label();
            this.dateUprazdT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // namePodrazdel
            // 
            this.namePodrazdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.namePodrazdel.Location = new System.Drawing.Point(1, 18);
            this.namePodrazdel.Name = "namePodrazdel";
            this.namePodrazdel.Size = new System.Drawing.Size(437, 43);
            this.namePodrazdel.TabIndex = 0;
            this.namePodrazdel.Text = "Подразделение";
            this.namePodrazdel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(284, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(504, 246);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(284, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Должность";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(627, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол.шт.ед";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(720, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Зам.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataCreate
            // 
            this.dataCreate.Location = new System.Drawing.Point(636, 12);
            this.dataCreate.Name = "dataCreate";
            this.dataCreate.ReadOnly = true;
            this.dataCreate.Size = new System.Drawing.Size(160, 22);
            this.dataCreate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(473, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата создания";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(440, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Всего";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCnt
            // 
            this.totalCnt.Location = new System.Drawing.Point(539, 380);
            this.totalCnt.Name = "totalCnt";
            this.totalCnt.ReadOnly = true;
            this.totalCnt.Size = new System.Drawing.Size(126, 22);
            this.totalCnt.TabIndex = 8;
            // 
            // totalZm
            // 
            this.totalZm.Location = new System.Drawing.Point(665, 380);
            this.totalZm.Name = "totalZm";
            this.totalZm.ReadOnly = true;
            this.totalZm.Size = new System.Drawing.Size(122, 22);
            this.totalZm.TabIndex = 9;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(284, 480);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 23);
            this.label.TabIndex = 10;
            this.label.Text = "Оклад:";
            // 
            // nameChoose
            // 
            this.nameChoose.Location = new System.Drawing.Point(284, 435);
            this.nameChoose.Name = "nameChoose";
            this.nameChoose.Size = new System.Drawing.Size(512, 23);
            this.nameChoose.TabIndex = 11;
            // 
            // oklad
            // 
            this.oklad.Location = new System.Drawing.Point(440, 480);
            this.oklad.Name = "oklad";
            this.oklad.Size = new System.Drawing.Size(181, 23);
            this.oklad.TabIndex = 12;
            // 
            // Podrazdels
            // 
            this.Podrazdels.Location = new System.Drawing.Point(1, 106);
            this.Podrazdels.Name = "Podrazdels";
            this.Podrazdels.Size = new System.Drawing.Size(283, 462);
            this.Podrazdels.TabIndex = 13;
            this.Podrazdels.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Podrazdels_AfterSelect);
            // 
            // dateUprazd
            // 
            this.dateUprazd.Location = new System.Drawing.Point(473, 61);
            this.dateUprazd.Name = "dateUprazd";
            this.dateUprazd.Size = new System.Drawing.Size(148, 23);
            this.dateUprazd.TabIndex = 14;
            this.dateUprazd.Text = "Дата упразднения";
            // 
            // dateUprazdText
            // 
            this.dateUprazdText.Location = new System.Drawing.Point(636, 58);
            this.dateUprazdText.Name = "dateUprazdText";
            this.dateUprazdText.ReadOnly = true;
            this.dateUprazdText.Size = new System.Drawing.Size(160, 22);
            this.dateUprazdText.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(284, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата создания";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(284, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дата упразднения";
            // 
            // dateCreateT
            // 
            this.dateCreateT.Location = new System.Drawing.Point(440, 503);
            this.dateCreateT.Name = "dateCreateT";
            this.dateCreateT.Size = new System.Drawing.Size(172, 23);
            this.dateCreateT.TabIndex = 18;
            // 
            // dateUprazdT
            // 
            this.dateUprazdT.Location = new System.Drawing.Point(440, 526);
            this.dateUprazdT.Name = "dateUprazdT";
            this.dateUprazdT.Size = new System.Drawing.Size(172, 23);
            this.dateUprazdT.TabIndex = 19;
            // 
            // Podrazdelenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.dateUprazdT);
            this.Controls.Add(this.dateCreateT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateUprazdText);
            this.Controls.Add(this.dateUprazd);
            this.Controls.Add(this.Podrazdels);
            this.Controls.Add(this.oklad);
            this.Controls.Add(this.nameChoose);
            this.Controls.Add(this.label);
            this.Controls.Add(this.totalZm);
            this.Controls.Add(this.totalCnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.namePodrazdel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Podrazdelenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подразделение";
            this.Load += new System.EventHandler(this.Podrazdelenie_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.TextBox dataCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dateCreateT;
        private System.Windows.Forms.Label dateUprazd;
        private System.Windows.Forms.Label dateUprazdT;
        public System.Windows.Forms.TextBox dateUprazdText;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nameChoose;
        public System.Windows.Forms.Label namePodrazdel;
        public System.Windows.Forms.Label oklad;
        private System.Windows.Forms.TreeView Podrazdels;
        private System.Windows.Forms.TextBox totalCnt;
        private System.Windows.Forms.TextBox totalZm;

        #endregion
    }
}