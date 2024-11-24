namespace NTierArchitecture.UI.Forms
{
    partial class EmployeeForm
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
            txtName = new TextBox();
            lstListe = new ListBox();
            label1 = new Label();
            label3 = new Label();
            txtSurname = new TextBox();
            txtCountry = new TextBox();
            label2 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            chkAktif = new CheckBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 13);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 39);
            txtName.TabIndex = 11;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 32;
            lstListe.Location = new Point(465, 14);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(389, 260);
            lstListe.TabIndex = 10;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 7;
            label1.Text = "Adınız        : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 62);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 12;
            label3.Text = "Soyadınız  : ";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(167, 58);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(278, 39);
            txtSurname.TabIndex = 13;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(167, 117);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(278, 39);
            txtCountry.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 121);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 14;
            label2.Text = "Ülkeniz      : ";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(167, 162);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(278, 39);
            txtCity.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 167);
            label4.Name = "label4";
            label4.Size = new Size(146, 32);
            label4.TabIndex = 16;
            label4.Text = "Şehriniz     : ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(167, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 39);
            txtPhone.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 213);
            label5.Name = "label5";
            label5.Size = new Size(147, 32);
            label5.TabIndex = 18;
            label5.Text = "Telefon      : ";
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.Location = new Point(155, 266);
            chkAktif.Name = "chkAktif";
            chkAktif.Size = new Size(153, 36);
            chkAktif.TabIndex = 20;
            chkAktif.Text = "Aktif / Pasif";
            chkAktif.UseVisualStyleBackColor = true;
            chkAktif.CheckedChanged += chkAktif_CheckedChanged;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 533);
            Controls.Add(chkAktif);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtCountry);
            Controls.Add(label2);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(lstListe);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(12, 15, 12, 15);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtSurname, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtCountry, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtCity, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(chkAktif, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private ListBox lstListe;
        private Label label1;
        private Label label3;
        private TextBox txtSurname;
        private TextBox txtCountry;
        private Label label2;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private CheckBox chkAktif;
    }
}