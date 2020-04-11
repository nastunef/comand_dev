// using System.ComponentModel;
//
// namespace Komandirovki
// {
//     partial class AddPlaceKomandForm
//     {
//         /// <summary>
//         /// Required designer variable.
//         /// </summary>
//         private IContainer components = null;
//
//         /// <summary>
//         /// Clean up any resources being used.
//         /// </summary>
//         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//         protected override void Dispose(bool disposing)
//         {
//             if (disposing && (components != null))
//             {
//                 components.Dispose();
//             }
//
//             base.Dispose(disposing);
//         }
//
//         #region Windows Form Designer generated code
//
//         /// <summary>
//         /// Required method for Designer support - do not modify
//         /// the contents of this method with the code editor.
//         /// </summary>
//         private void InitializeComponent()
//         {
//             this.components = new System.ComponentModel.Container();
//             this.label1 = new System.Windows.Forms.Label();
//             this.CountryComboBox = new System.Windows.Forms.ComboBox();
//             this.label2 = new System.Windows.Forms.Label();
//             this.label3 = new System.Windows.Forms.Label();
//             this.OrganizationTextBox = new System.Windows.Forms.TextBox();
//             this.SaveButton = new System.Windows.Forms.Button();
//             this.ExitButton = new System.Windows.Forms.Button();
//             this.CityTextBox = new System.Windows.Forms.TextBox();
//             this.pLACETRIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
//             ((System.ComponentModel.ISupportInitialize)(this.pLACETRIPBindingSource)).BeginInit();
//             this.SuspendLayout();
//             // 
//             // label1
//             // 
//             this.label1.Location = new System.Drawing.Point(15, 14);
//             this.label1.Name = "label1";
//             this.label1.Size = new System.Drawing.Size(45, 14);
//             this.label1.TabIndex = 0;
//             this.label1.Text = "Страна:";
//             // 
//             // CountryComboBox
//             // 
//             this.CountryComboBox.FormattingEnabled = true;
//             this.CountryComboBox.Location = new System.Drawing.Point(120, 11);
//             this.CountryComboBox.Name = "CountryComboBox";
//             this.CountryComboBox.Size = new System.Drawing.Size(187, 21);
//             this.CountryComboBox.TabIndex = 1;
//             // 
//             // label2
//             // 
//             this.label2.Location = new System.Drawing.Point(15, 48);
//             this.label2.Name = "label2";
//             this.label2.Size = new System.Drawing.Size(45, 14);
//             this.label2.TabIndex = 2;
//             this.label2.Text = "Город:";
//             // 
//             // label3
//             // 
//             this.label3.Location = new System.Drawing.Point(15, 84);
//             this.label3.Name = "label3";
//             this.label3.Size = new System.Drawing.Size(76, 14);
//             this.label3.TabIndex = 4;
//             this.label3.Text = "Организация";
//             // 
//             // OrganizationTextBox
//             // 
//             this.OrganizationTextBox.Location = new System.Drawing.Point(120, 81);
//             this.OrganizationTextBox.Name = "OrganizationTextBox";
//             this.OrganizationTextBox.Size = new System.Drawing.Size(187, 20);
//             this.OrganizationTextBox.TabIndex = 5;
//             // 
//             // SaveButton
//             // 
//             this.SaveButton.Location = new System.Drawing.Point(21, 111);
//             this.SaveButton.Name = "SaveButton";
//             this.SaveButton.Size = new System.Drawing.Size(79, 22);
//             this.SaveButton.TabIndex = 6;
//             this.SaveButton.Text = "Сохранить";
//             this.SaveButton.UseVisualStyleBackColor = true;
//             this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
//             // 
//             // ExitButton
//             // 
//             this.ExitButton.Location = new System.Drawing.Point(148, 111);
//             this.ExitButton.Name = "ExitButton";
//             this.ExitButton.Size = new System.Drawing.Size(159, 22);
//             this.ExitButton.TabIndex = 7;
//             this.ExitButton.Text = "Выйти без сохранения";
//             this.ExitButton.UseVisualStyleBackColor = true;
//             // 
//             // CityTextBox
//             // 
//             this.CityTextBox.Location = new System.Drawing.Point(120, 45);
//             this.CityTextBox.Name = "CityTextBox";
//             this.CityTextBox.Size = new System.Drawing.Size(187, 20);
//             this.CityTextBox.TabIndex = 8;
//             // 
//             // pLACETRIPBindingSource
//             // 
//             this.pLACETRIPBindingSource.DataSource = typeof(WindowsFormsApp1.PLACE_TRIP);
//             // 
//             // AddPlaceKomandForm
//             // 
//             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//             this.ClientSize = new System.Drawing.Size(322, 140);
//             this.Controls.Add(this.CityTextBox);
//             this.Controls.Add(this.ExitButton);
//             this.Controls.Add(this.SaveButton);
//             this.Controls.Add(this.OrganizationTextBox);
//             this.Controls.Add(this.label3);
//             this.Controls.Add(this.label2);
//             this.Controls.Add(this.CountryComboBox);
//             this.Controls.Add(this.label1);
//             this.Name = "AddPlaceKomandForm";
//             this.Text = "Добавить место назначения";
//             this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPlaceKomandForm_FormClosing);
//             ((System.ComponentModel.ISupportInitialize)(this.pLACETRIPBindingSource)).EndInit();
//             this.ResumeLayout(false);
//             this.PerformLayout();
//
//         }
//
//         #endregion
//         private System.Windows.Forms.TextBox OrganizationTextBox;
//         private System.Windows.Forms.Label label3;
//         private System.Windows.Forms.Label label2;
//         private System.Windows.Forms.ComboBox CountryComboBox;
//         private System.Windows.Forms.Label label1;
//         private System.Windows.Forms.Button ExitButton;
//         private System.Windows.Forms.Button SaveButton;
//         private System.Windows.Forms.TextBox CityTextBox;
//         private System.Windows.Forms.BindingSource pLACETRIPBindingSource;
//     }
// }