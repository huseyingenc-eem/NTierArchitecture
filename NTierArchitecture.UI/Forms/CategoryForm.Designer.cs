namespace NTierArchitecture.UI.Forms
{
    partial class CategoryForm
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
            label1 = new Label();
            label2 = new Label();
            txtAciklama = new TextBox();
            chkAktif = new CheckBox();
            lstListe = new ListBox();
            txtKategoriAdi = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 1;
            label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(158, 37);
            label2.TabIndex = 2;
            label2.Text = "Açıklama   : ";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(185, 67);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(264, 203);
            txtAciklama.TabIndex = 3;
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.Location = new Point(280, 276);
            chkAktif.Name = "chkAktif";
            chkAktif.Size = new Size(169, 41);
            chkAktif.TabIndex = 4;
            chkAktif.Text = "Aktif / Pasif";
            chkAktif.UseVisualStyleBackColor = true;
            chkAktif.CheckedChanged += cmkAktif_CheckedChanged;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(455, 17);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(238, 300);
            lstListe.TabIndex = 5;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(185, 17);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(264, 43);
            txtKategoriAdi.TabIndex = 6;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 526);
            Controls.Add(txtKategoriAdi);
            Controls.Add(lstListe);
            Controls.Add(chkAktif);
            Controls.Add(txtAciklama);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(13, 17, 13, 17);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtAciklama, 0);
            Controls.SetChildIndex(chkAktif, 0);
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(txtKategoriAdi, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAciklama;
        private CheckBox chkAktif;
        private ListBox lstListe;
        private TextBox txtKategoriAdi;
    }
}