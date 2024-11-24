namespace NTierArchitecture.UI.Forms
{
    partial class CustomerForm
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
            lstListe = new ListBox();
            txtCountry = new TextBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label1 = new Label();
            label6 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            chkAktif = new CheckBox();
            SuspendLayout();
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(716, 29);
            lstListe.Margin = new Padding(6);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(432, 284);
            lstListe.TabIndex = 1;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(221, 104);
            txtCountry.Margin = new Padding(6);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(478, 47);
            txtCountry.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 110);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 41);
            label2.TabIndex = 25;
            label2.Text = "Ülke               :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(223, 29);
            txtCustomerName.Margin = new Padding(6);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(478, 47);
            txtCustomerName.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 41);
            label1.TabIndex = 23;
            label1.Text = "Ad / Soyad     :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 327);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(249, 41);
            label6.TabIndex = 34;
            label6.Text = "Aktif Kullanıcı Mı?";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(221, 171);
            txtCity.Margin = new Padding(6);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(478, 47);
            txtCity.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 176);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 41);
            label3.TabIndex = 35;
            label3.Text = "Şehir              :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(223, 238);
            txtPhone.Margin = new Padding(6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(478, 47);
            txtPhone.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 243);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(201, 41);
            label4.TabIndex = 37;
            label4.Text = "Telefon          :";
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.Location = new Point(528, 323);
            chkAktif.Margin = new Padding(6);
            chkAktif.Name = "chkAktif";
            chkAktif.Size = new Size(169, 45);
            chkAktif.TabIndex = 39;
            chkAktif.Text = "Aktif/Pasif";
            chkAktif.UseVisualStyleBackColor = true;
            chkAktif.CheckedChanged += chkAktif_Checked;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 549);
            Controls.Add(chkAktif);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txtCountry);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Controls.Add(lstListe);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(15, 18, 15, 18);
            Name = "CustomerForm";
            Text = "Customer";
            Load += Customer_Load;
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCustomerName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtCountry, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtCity, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(chkAktif, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstListe;
        private TextBox txtCountry;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label1;
        private Label label6;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private CheckBox chkAktif;
    }
}