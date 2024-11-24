namespace NTierArchitecture.UI.Forms
{
    partial class ProductForm
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
            txtProductName = new TextBox();
            lstListe = new ListBox();
            label1 = new Label();
            txtUnitPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbSupplier = new ComboBox();
            nmrUnitInStock = new NumericUpDown();
            chkIsActive = new CheckBox();
            lstUrunleriListele = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nmrUnitInStock).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(160, 70);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(252, 39);
            txtProductName.TabIndex = 11;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 32;
            lstListe.Location = new Point(12, 171);
            lstListe.Margin = new Padding(4, 3, 4, 3);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(807, 132);
            lstListe.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 7;
            label1.Text = "Ürün Adı     :";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(160, 115);
            txtUnitPrice.Margin = new Padding(4, 3, 4, 3);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(252, 39);
            txtUnitPrice.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 12;
            label2.Text = "Ürün Fiyatı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 14;
            label3.Text = "Stok Miktarı :";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(160, 7);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(252, 40);
            cmbCategory.TabIndex = 16;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 17;
            label4.Text = "Kategori     :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 14);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 32);
            label5.TabIndex = 19;
            label5.Text = "Tedarikçi     :";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(568, 10);
            cmbSupplier.Margin = new Padding(4, 3, 4, 3);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(251, 40);
            cmbSupplier.TabIndex = 18;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // nmrUnitInStock
            // 
            nmrUnitInStock.Location = new Point(573, 65);
            nmrUnitInStock.Margin = new Padding(4, 3, 4, 3);
            nmrUnitInStock.Name = "nmrUnitInStock";
            nmrUnitInStock.Size = new Size(81, 39);
            nmrUnitInStock.TabIndex = 20;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(682, 68);
            chkIsActive.Margin = new Padding(4, 3, 4, 3);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(153, 36);
            chkIsActive.TabIndex = 21;
            chkIsActive.Text = "Aktif / Pasif";
            chkIsActive.UseVisualStyleBackColor = true;
            chkIsActive.CheckedChanged += chkIsActive_CheckedChanged;
            // 
            // lstUrunleriListele
            // 
            lstUrunleriListele.FormattingEnabled = true;
            lstUrunleriListele.ItemHeight = 32;
            lstUrunleriListele.Location = new Point(843, 30);
            lstUrunleriListele.Margin = new Padding(4, 3, 4, 3);
            lstUrunleriListele.Name = "lstUrunleriListele";
            lstUrunleriListele.Size = new Size(370, 356);
            lstUrunleriListele.TabIndex = 23;
            lstUrunleriListele.SelectedIndexChanged += lstUrunleriListele_SelectedIndexChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 595);
            Controls.Add(lstUrunleriListele);
            Controls.Add(chkIsActive);
            Controls.Add(nmrUnitInStock);
            Controls.Add(label5);
            Controls.Add(cmbSupplier);
            Controls.Add(label4);
            Controls.Add(cmbCategory);
            Controls.Add(label3);
            Controls.Add(txtUnitPrice);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(lstListe);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(12, 15, 12, 15);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(txtProductName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtUnitPrice, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(cmbCategory, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(cmbSupplier, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(nmrUnitInStock, 0);
            Controls.SetChildIndex(chkIsActive, 0);
            Controls.SetChildIndex(lstUrunleriListele, 0);
            ((System.ComponentModel.ISupportInitialize)nmrUnitInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private ListBox lstListe;
        private Label label1;
        private TextBox txtUnitPrice;
        private Label label2;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label4;
        private Label label5;
        private ComboBox cmbSupplier;
        private NumericUpDown nmrUnitInStock;
        private CheckBox chkIsActive;
        private ListBox lstUrunleriListele;
    }
}