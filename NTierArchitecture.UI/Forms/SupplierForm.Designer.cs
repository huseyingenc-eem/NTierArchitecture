namespace NTierArchitecture.UI.Forms
{
    partial class SupplierForm
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
            txtCompanyName = new TextBox();
            lstListe = new ListBox();
            chkAktif = new CheckBox();
            txtContactTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCountry = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Segoe UI", 15F);
            txtCompanyName.Location = new Point(169, 18);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(264, 34);
            txtCompanyName.TabIndex = 12;
            // 
            // lstListe
            // 
            lstListe.Font = new Font("Segoe UI", 15F);
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 28;
            lstListe.Location = new Point(454, 18);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(240, 284);
            lstListe.TabIndex = 11;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.Font = new Font("Segoe UI", 15F);
            chkAktif.Location = new Point(301, 219);
            chkAktif.Name = "chkAktif";
            chkAktif.Size = new Size(129, 32);
            chkAktif.TabIndex = 10;
            chkAktif.Text = "Aktif / Pasif";
            chkAktif.UseVisualStyleBackColor = true;
            chkAktif.CheckedChanged += chkAktif_CheckedChanged;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Font = new Font("Segoe UI", 15F);
            txtContactTitle.Location = new Point(167, 58);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(264, 34);
            txtContactTitle.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 8;
            label2.Text = "İletişim Ünvanı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 7;
            label1.Text = "Tedarikçi Adı     :";
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 15F);
            txtCountry.Location = new Point(166, 99);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(264, 34);
            txtCountry.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(11, 99);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 13;
            label3.Text = "Ülke                   :";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 15F);
            txtCity.Location = new Point(166, 139);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(264, 34);
            txtCity.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(11, 139);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 15;
            label4.Text = "Şehir                  :";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 15F);
            txtPhone.Location = new Point(166, 179);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(264, 34);
            txtPhone.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(11, 179);
            label5.Name = "label5";
            label5.Size = new Size(148, 28);
            label5.TabIndex = 17;
            label5.Text = "Telefon              :";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 508);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtCountry);
            Controls.Add(label3);
            Controls.Add(txtCompanyName);
            Controls.Add(lstListe);
            Controls.Add(chkAktif);
            Controls.Add(txtContactTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(13, 17, 13, 17);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtContactTitle, 0);
            Controls.SetChildIndex(chkAktif, 0);
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(txtCompanyName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtCountry, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtCity, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtPhone, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompanyName;
        private ListBox lstListe;
        private CheckBox chkAktif;
        private TextBox txtContactTitle;
        private Label label2;
        private Label label1;
        private TextBox txtCountry;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
    }
}