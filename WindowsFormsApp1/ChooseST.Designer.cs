using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class ChooseST
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
            this.numerusST = new System.Windows.Forms.ComboBox();
            this.okey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(81, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер ШР";
            // 
            // numerusST
            // 
            this.numerusST.FormattingEnabled = true;
            this.numerusST.Location = new System.Drawing.Point(198, 51);
            this.numerusST.Name = "numerusST";
            this.numerusST.Size = new System.Drawing.Size(121, 24);
            this.numerusST.TabIndex = 1;
            // 
            // okey
            // 
            this.okey.Location = new System.Drawing.Point(117, 121);
            this.okey.Name = "okey";
            this.okey.Size = new System.Drawing.Size(159, 36);
            this.okey.TabIndex = 2;
            this.okey.Text = "Готово";
            this.okey.UseVisualStyleBackColor = true;
            this.okey.Click += new System.EventHandler(this.okey_Click);
            // 
            // ChooseST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 182);
            this.Controls.Add(this.okey);
            this.Controls.Add(this.numerusST);
            this.Controls.Add(this.label1);
            this.Name = "ChooseST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите";
            this.Load += new System.EventHandler(this.ChooseST_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox numerusST;
        private System.Windows.Forms.Button okey;

        #endregion
    }
}