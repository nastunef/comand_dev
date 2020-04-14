using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class About
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Наш репозиторий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[]
            {
                "HDR version1.0 (64-разрядная)", "Авторские права © 2020", "Группа ПИ-62", "Издатель: ПИ-62",
                "Локализация: ПИ-62", "Расширенная лицензия", "", "Благодарности:", "Всем кто принял ",
                "участие в разработке ", "данного проекта.", "А также отдельная благодарность ",
                "Александре Васильевне Астаховой."
            });
            this.listBox1.Location = new System.Drawing.Point(30, 51);
            this.listBox1.MaximumSize = new System.Drawing.Size(229, 244);
            this.listBox1.MinimumSize = new System.Drawing.Size(229, 244);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 244);
            this.listBox1.TabIndex = 3;
     
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 335);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "About";
            this.Text = "О программе";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}