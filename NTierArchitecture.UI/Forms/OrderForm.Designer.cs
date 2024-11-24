namespace NTierArchitecture.UI.Forms
{
    partial class OrderForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnAddBasket = new Button();
            label3 = new Label();
            label2 = new Label();
            nmrQuantity = new NumericUpDown();
            label1 = new Label();
            txtUnitPrice = new TextBox();
            txtSearch = new TextBox();
            lstProductList = new ListBox();
            dgwOrderList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            ShipCountry = new DataGridViewTextBoxColumn();
            ShipCity = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shipAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shipCityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shipCountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            createdDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            groupBox3 = new GroupBox();
            dgwOrderDetailList = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            KdvliFiyat = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            btnDelete = new Button();
            btnSaveOrder = new Button();
            btnNewOrder = new Button();
            lstBasket = new ListBox();
            lblBasketCount = new Label();
            lblBasketTotal = new Label();
            orderDetailBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetailList).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddBasket);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nmrQuantity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(lstProductList);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(590, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Listesi";
            // 
            // btnAddBasket
            // 
            btnAddBasket.Location = new Point(13, 257);
            btnAddBasket.Margin = new Padding(2);
            btnAddBasket.Name = "btnAddBasket";
            btnAddBasket.Size = new Size(564, 40);
            btnAddBasket.TabIndex = 2;
            btnAddBasket.Text = "Sepete Ekle";
            btnAddBasket.UseVisualStyleBackColor = true;
            btnAddBasket.Click += btnAddBasket_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 229);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 1;
            label3.Text = "Birim Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 224);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // nmrQuantity
            // 
            nmrQuantity.Location = new Point(101, 224);
            nmrQuantity.Margin = new Padding(11, 13, 11, 13);
            nmrQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrQuantity.Name = "nmrQuantity";
            nmrQuantity.Size = new Size(111, 32);
            nmrQuantity.TabIndex = 3;
            nmrQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 25);
            label1.TabIndex = 1;
            label1.Text = "Lütfen aramak istediğiniz ürünü giriniz:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(353, 224);
            txtUnitPrice.Margin = new Padding(2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(225, 32);
            txtUnitPrice.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 62);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(566, 32);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lstProductList
            // 
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 25;
            lstProductList.Location = new Point(13, 95);
            lstProductList.Margin = new Padding(2);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(566, 129);
            lstProductList.TabIndex = 4;
            lstProductList.SelectedIndexChanged += lstProductList_SelectedIndexChanged;
            // 
            // dgwOrderList
            // 
            dgwOrderList.AutoGenerateColumns = false;
            dgwOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgwOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrderList.Columns.AddRange(new DataGridViewColumn[] { Id, OrderDate, ShipCountry, ShipCity, orderDateDataGridViewTextBoxColumn, shipAddressDataGridViewTextBoxColumn, shipCityDataGridViewTextBoxColumn, shipCountryDataGridViewTextBoxColumn, employeeDataGridViewTextBoxColumn, employeeIDDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, customerIDDataGridViewTextBoxColumn, orderDetailsDataGridViewTextBoxColumn, ıdDataGridViewTextBoxColumn, ısActiveDataGridViewCheckBoxColumn, createdDateDataGridViewTextBoxColumn1 });
            dgwOrderList.DataSource = orderBindingSource;
            dgwOrderList.Location = new Point(13, 42);
            dgwOrderList.Margin = new Padding(2);
            dgwOrderList.Name = "dgwOrderList";
            dgwOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwOrderList.Size = new Size(1113, 248);
            dgwOrderList.TabIndex = 5;
            dgwOrderList.CellContentClick += dgwOrderList_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Sipariş No";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 123;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "Sipariş Tarihi";
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 144;
            // 
            // ShipCountry
            // 
            ShipCountry.DataPropertyName = "ShipCountry";
            ShipCountry.HeaderText = "Ülke";
            ShipCountry.Name = "ShipCountry";
            ShipCountry.ReadOnly = true;
            ShipCountry.Width = 74;
            // 
            // ShipCity
            // 
            ShipCity.DataPropertyName = "ShipCity";
            ShipCity.HeaderText = "Şehir";
            ShipCity.Name = "ShipCity";
            ShipCity.ReadOnly = true;
            ShipCity.Width = 80;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.Visible = false;
            orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipAddressDataGridViewTextBoxColumn
            // 
            shipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress";
            shipAddressDataGridViewTextBoxColumn.HeaderText = "ShipAddress";
            shipAddressDataGridViewTextBoxColumn.Name = "shipAddressDataGridViewTextBoxColumn";
            shipAddressDataGridViewTextBoxColumn.Visible = false;
            shipAddressDataGridViewTextBoxColumn.Width = 141;
            // 
            // shipCityDataGridViewTextBoxColumn
            // 
            shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
            shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
            shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
            shipCityDataGridViewTextBoxColumn.Visible = false;
            shipCityDataGridViewTextBoxColumn.Width = 106;
            // 
            // shipCountryDataGridViewTextBoxColumn
            // 
            shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry";
            shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry";
            shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn";
            shipCountryDataGridViewTextBoxColumn.Visible = false;
            shipCountryDataGridViewTextBoxColumn.Width = 141;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.Visible = false;
            employeeDataGridViewTextBoxColumn.Width = 119;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            employeeIDDataGridViewTextBoxColumn.Visible = false;
            employeeIDDataGridViewTextBoxColumn.Width = 137;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.Visible = false;
            customerDataGridViewTextBoxColumn.Width = 118;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            customerIDDataGridViewTextBoxColumn.Visible = false;
            customerIDDataGridViewTextBoxColumn.Width = 136;
            // 
            // orderDetailsDataGridViewTextBoxColumn
            // 
            orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            orderDetailsDataGridViewTextBoxColumn.Visible = false;
            orderDetailsDataGridViewTextBoxColumn.Width = 143;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.Visible = false;
            ıdDataGridViewTextBoxColumn.Width = 53;
            // 
            // ısActiveDataGridViewCheckBoxColumn
            // 
            ısActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            ısActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            ısActiveDataGridViewCheckBoxColumn.Name = "ısActiveDataGridViewCheckBoxColumn";
            ısActiveDataGridViewCheckBoxColumn.Visible = false;
            ısActiveDataGridViewCheckBoxColumn.Width = 82;
            // 
            // createdDateDataGridViewTextBoxColumn1
            // 
            createdDateDataGridViewTextBoxColumn1.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn1.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn1.Name = "createdDateDataGridViewTextBoxColumn1";
            createdDateDataGridViewTextBoxColumn1.Visible = false;
            createdDateDataGridViewTextBoxColumn1.Width = 142;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Entities.Models.Order);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwOrderList);
            groupBox2.Location = new Point(0, 319);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1146, 319);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sipariş Bilgisi";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(765, 316);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(357, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Fatura Toplam Tutarı :  12.500 + %20 KDV";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgwOrderDetailList);
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Location = new Point(4, 642);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(1142, 358);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sipariş Detay Raporu";
            // 
            // dgwOrderDetailList
            // 
            dgwOrderDetailList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgwOrderDetailList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrderDetailList.Columns.AddRange(new DataGridViewColumn[] { OrderID, ProductID, ProductName, Quantity, UnitPrice, KdvliFiyat });
            dgwOrderDetailList.Location = new Point(13, 34);
            dgwOrderDetailList.Margin = new Padding(2);
            dgwOrderDetailList.Name = "dgwOrderDetailList";
            dgwOrderDetailList.Size = new Size(1109, 270);
            dgwOrderDetailList.TabIndex = 5;
            dgwOrderDetailList.DataBindingComplete += dgwOrderDetailList_DataBindingComplete;
            // 
            // OrderID
            // 
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "Sipariş No";
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Width = 123;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "Ürün No";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Width = 109;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Ürün Adı";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 112;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Adet";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 76;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "Ürün Fiyatı";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 128;
            // 
            // KdvliFiyat
            // 
            KdvliFiyat.DataPropertyName = "KdvliFiyat";
            KdvliFiyat.HeaderText = "Kdvli Fiyat";
            KdvliFiyat.Name = "KdvliFiyat";
            KdvliFiyat.ReadOnly = true;
            KdvliFiyat.Width = 122;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDelete);
            groupBox4.Controls.Add(btnSaveOrder);
            groupBox4.Controls.Add(btnNewOrder);
            groupBox4.Controls.Add(lstBasket);
            groupBox4.Controls.Add(lblBasketCount);
            groupBox4.Controls.Add(lblBasketTotal);
            groupBox4.Location = new Point(604, 7);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(541, 300);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Müşteri Sepeti";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(457, 214);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 38);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(172, 258);
            btnSaveOrder.Margin = new Padding(2);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(173, 38);
            btnSaveOrder.TabIndex = 2;
            btnSaveOrder.Text = "Sipariş Kaydet";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(349, 256);
            btnNewOrder.Margin = new Padding(2);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(173, 38);
            btnNewOrder.TabIndex = 2;
            btnNewOrder.Text = "Yeni Sipariş";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // lstBasket
            // 
            lstBasket.FormattingEnabled = true;
            lstBasket.ItemHeight = 25;
            lstBasket.Location = new Point(4, 41);
            lstBasket.Margin = new Padding(2);
            lstBasket.Name = "lstBasket";
            lstBasket.Size = new Size(520, 154);
            lstBasket.TabIndex = 5;
            // 
            // lblBasketCount
            // 
            lblBasketCount.AutoSize = true;
            lblBasketCount.Location = new Point(4, 230);
            lblBasketCount.Margin = new Padding(2, 0, 2, 0);
            lblBasketCount.Name = "lblBasketCount";
            lblBasketCount.Size = new Size(127, 25);
            lblBasketCount.TabIndex = 1;
            lblBasketCount.Text = "Ürün Adedi: 5";
            // 
            // lblBasketTotal
            // 
            lblBasketTotal.AutoSize = true;
            lblBasketTotal.Location = new Point(4, 203);
            lblBasketTotal.Margin = new Padding(2, 0, 2, 0);
            lblBasketTotal.Name = "lblBasketTotal";
            lblBasketTotal.Size = new Size(217, 25);
            lblBasketTotal.TabIndex = 1;
            lblBasketTotal.Text = "Sepet Toplamı: 12.500 TL";
            // 
            // orderDetailBindingSource
            // 
            orderDetailBindingSource.DataSource = typeof(Entities.Models.OrderDetail);
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1157, 1154);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetailList).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private GroupBox groupBox1;
        private ListBox lstProductList;
        private NumericUpDown nmrQuantity;
        private Button btnAddBasket;
        private Label label1;
        private TextBox txtSearch;
        private Label label3;
        private Label label2;
        private TextBox txtUnitPrice;
        private DataGridView dgwOrderList;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgwOrderDetailList;
        private GroupBox groupBox4;
        private Button btnSaveOrder;
        private Button btnNewOrder;
        private ListBox lstBasket;
        private Label lblBasketCount;
        private Label lblBasketTotal;
        private Button btnDelete;
        private Label lblTotal;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn ShipCountry;
        private DataGridViewTextBoxColumn ShipCity;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ısActiveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn1;
        private BindingSource orderDetailBindingSource;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn KdvliFiyat;
    }
}