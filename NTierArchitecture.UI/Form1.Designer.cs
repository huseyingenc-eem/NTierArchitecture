namespace NTierArchitecture.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıEkleToolStripMenuItem = new ToolStripMenuItem();
            çalışanEklemeToolStripMenuItem1 = new ToolStripMenuItem();
            tedarikİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            tedarikçiEklemeToolStripMenuItem = new ToolStripMenuItem();
            ürünİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kategoriEklemeToolStripMenuItem = new ToolStripMenuItem();
            ürünEklemeToolStripMenuItem = new ToolStripMenuItem();
            siparişİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturmaToolStripMenuItem = new ToolStripMenuItem();
            siparişDetaylarıToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tToolStripMenuItem, tedarikİşlemleriToolStripMenuItem, ürünİşlemleriToolStripMenuItem, siparişİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2335, 45);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            tToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullanıcıEkleToolStripMenuItem, çalışanEklemeToolStripMenuItem1 });
            tToolStripMenuItem.Name = "tToolStripMenuItem";
            tToolStripMenuItem.Size = new Size(247, 41);
            tToolStripMenuItem.Text = "Üye Tanımlamaları";
            tToolStripMenuItem.Click += tToolStripMenuItem_Click;
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            kullanıcıEkleToolStripMenuItem.Size = new Size(286, 42);
            kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekleme";
            kullanıcıEkleToolStripMenuItem.Click += kullanıcıEkleToolStripMenuItem_Click;
            // 
            // çalışanEklemeToolStripMenuItem1
            // 
            çalışanEklemeToolStripMenuItem1.Name = "çalışanEklemeToolStripMenuItem1";
            çalışanEklemeToolStripMenuItem1.Size = new Size(286, 42);
            çalışanEklemeToolStripMenuItem1.Text = "Çalışan Ekleme";
            çalışanEklemeToolStripMenuItem1.Click += çalışanEklemeToolStripMenuItem1_Click;
            // 
            // tedarikİşlemleriToolStripMenuItem
            // 
            tedarikİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tedarikçiEklemeToolStripMenuItem });
            tedarikİşlemleriToolStripMenuItem.Name = "tedarikİşlemleriToolStripMenuItem";
            tedarikİşlemleriToolStripMenuItem.Size = new Size(264, 41);
            tedarikİşlemleriToolStripMenuItem.Text = "Tedarik Tanımlamarı";
            // 
            // tedarikçiEklemeToolStripMenuItem
            // 
            tedarikçiEklemeToolStripMenuItem.Name = "tedarikçiEklemeToolStripMenuItem";
            tedarikçiEklemeToolStripMenuItem.Size = new Size(289, 42);
            tedarikçiEklemeToolStripMenuItem.Text = "Tedarikçi Ekleme";
            tedarikçiEklemeToolStripMenuItem.Click += tedarikçiEklemeToolStripMenuItem_Click;
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kategoriEklemeToolStripMenuItem, ürünEklemeToolStripMenuItem });
            ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            ürünİşlemleriToolStripMenuItem.Size = new Size(193, 41);
            ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // kategoriEklemeToolStripMenuItem
            // 
            kategoriEklemeToolStripMenuItem.Name = "kategoriEklemeToolStripMenuItem";
            kategoriEklemeToolStripMenuItem.Size = new Size(287, 42);
            kategoriEklemeToolStripMenuItem.Text = "Kategori Ekleme";
            kategoriEklemeToolStripMenuItem.Click += kategoriEklemeToolStripMenuItem_Click;
            // 
            // ürünEklemeToolStripMenuItem
            // 
            ürünEklemeToolStripMenuItem.Name = "ürünEklemeToolStripMenuItem";
            ürünEklemeToolStripMenuItem.Size = new Size(287, 42);
            ürünEklemeToolStripMenuItem.Text = "Ürün Ekleme";
            ürünEklemeToolStripMenuItem.Click += ürünEklemeToolStripMenuItem_Click;
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            siparişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturmaToolStripMenuItem, siparişDetaylarıToolStripMenuItem });
            siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            siparişİşlemleriToolStripMenuItem.Size = new Size(213, 41);
            siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // siparişOluşturmaToolStripMenuItem
            // 
            siparişOluşturmaToolStripMenuItem.Name = "siparişOluşturmaToolStripMenuItem";
            siparişOluşturmaToolStripMenuItem.Size = new Size(302, 42);
            siparişOluşturmaToolStripMenuItem.Text = "Sipariş Oluşturma";
            siparişOluşturmaToolStripMenuItem.Click += siparişOluşturmaToolStripMenuItem_Click;
            // 
            // siparişDetaylarıToolStripMenuItem
            // 
            siparişDetaylarıToolStripMenuItem.Name = "siparişDetaylarıToolStripMenuItem";
            siparişDetaylarıToolStripMenuItem.Size = new Size(302, 42);
            siparişDetaylarıToolStripMenuItem.Text = "Sipariş Detayları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2335, 1120);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 20F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tToolStripMenuItem;
        private ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private ToolStripMenuItem tedarikİşlemleriToolStripMenuItem;
        private ToolStripMenuItem tedarikçiEklemeToolStripMenuItem;
        private ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private ToolStripMenuItem çalışanEklemeToolStripMenuItem1;
        private ToolStripMenuItem kategoriEklemeToolStripMenuItem;
        private ToolStripMenuItem ürünEklemeToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturmaToolStripMenuItem;
        private ToolStripMenuItem siparişDetaylarıToolStripMenuItem;
    }
}
