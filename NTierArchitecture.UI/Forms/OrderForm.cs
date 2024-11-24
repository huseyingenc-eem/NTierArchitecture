using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace NTierArchitecture.UI.Forms
{
    public partial class OrderForm : Form
    {
        private readonly OrderService _orderService;
        private readonly OrderRepository _orderRepository;

        private readonly ProductService _productService;
        private readonly ProductRepository _productRepository;

        private readonly OrderDetailService _orderDetailService;
        private readonly OrderDetailRepository _orderDetailRepository;

        public OrderForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _orderRepository = new OrderRepository(dbContext);
            _orderService = new OrderService(_orderRepository);

            _productRepository = new ProductRepository(dbContext);
            _productService = new ProductService(_productRepository);

            _orderDetailRepository = new OrderDetailRepository(dbContext);
            _orderDetailService = new OrderDetailService(_orderDetailRepository);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetAllProductsBySearchText(string.Empty);
            lstBasket.DisplayMember = "DisplayName";

            dgwOrderList.AutoGenerateColumns = false;
            dgwOrderDetailList.AutoGenerateColumns = false;

            dgwOrderList.DataSource = _orderService.GetAll();
        }

        private void GetAllProductsBySearchText(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText.ToLower()) && searchText.Length >= 3)
            {
                //ürünleri filtreye göre getir.
                var productList = _productService.GetAll()
                    .Where(p => p.ProductName.ToLower().Contains(searchText.ToLower()));

                lstProductList.ValueMember = "Id";
                lstProductList.DisplayMember = "ProductName";
                lstProductList.DataSource = productList.ToList();
            }
            if (searchText.Length <= 2)
            {
                lstProductList.ValueMember = "Id";
                lstProductList.DisplayMember = "ProductName";
                lstProductList.DataSource = _productService.GetAll().ToList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetAllProductsBySearchText(txtSearch.Text);
        }
        Product? selectedProduct;
        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductList.SelectedItem is Product selectedProduct)
            {
                txtUnitPrice.Text = selectedProduct.UnitPrice.ToString("F2");
            }

        }


        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            selectedProduct = (Product?)lstProductList.SelectedItem;

            if (selectedProduct == null)
                throw new Exception("Lütfen sepete eklemek için bir ürün seçin.");
            lstBasket.Items.Add(new Product
            {
                Id = selectedProduct.Id,
                ProductName = selectedProduct.ProductName,
                UnitPrice = selectedProduct.UnitPrice,
                UnitsInStock = (int)nmrQuantity.Value
            });
            UpdateBasket();

        }
        private void UpdateBasket()
        {
            double total = 0;
            int count = 0;
            foreach (var item in lstBasket.Items)
            {

                if (item is Product product)
                {
                    total += product.UnitPrice * product.UnitsInStock;
                    count += product.UnitsInStock;
                }
            }
            lblBasketTotal.Text = $"Sepet Toplamı: {total:F2} TL";
            lblBasketCount.Text = $"Ürün Adedi: {count}";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBasket.SelectedIndex == -1)
                throw new Exception("Lütfen silmek istediğiniz bir ürünü seçin.");

            selectedProduct = (Product?)lstBasket.SelectedItem;

            lstBasket.Items.Remove(selectedProduct);

            UpdateBasket();
        }
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrder();
        }
        Order? selectedOrder;
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {

        }

        private void NewOrder()
        {
            try
            {
                Order newOrder = new Order
                {
                    OrderDate = DateOnly.FromDateTime(DateTime.Now),
                    ShipCountry = "Türkiye",
                    ShipCity = "İstanbul",
                    CustomerID = Guid.Parse("66aaa813-2a7b-4aec-9a68-b7600427b600"),
                    EmployeeID = Guid.Parse("83e98871-779a-4a79-a1b1-0883b7399c5c")
                };

                _orderService.Create(newOrder);
                MessageBox.Show("Sipariş başarıyla kaydedildi.");

                foreach (var item in lstBasket.Items)
                {
                    if (item is Product product)
                    {
                        OrderDetail newDetail = new OrderDetail
                        {
                            OrderID = newOrder.Id,
                            ProductID = product.Id,
                            ProductName = product.ProductName,
                            Quantity = product.UnitsInStock,
                            UnitPrice = product.UnitPrice,
                            KdvliFiyat = product.UnitsInStock * product.UnitPrice * 1.20
                        };
                        _orderDetailService.Create(newDetail);
                    }
                }
                lstBasket.Items.Clear();

                dgwOrderList.DataSource = _orderService.GetAll().ToList();

                var filteredOrderDetails = _orderDetailService.GetAll()
                            .Where(od => od.OrderID == newOrder.Id)
                            .Select(od => new
                            {
                                OrderID = od.OrderID,
                                ProductID = od.ProductID,
                                ProductName = od.Product?.ProductName ?? "Ürün Adı Yok",
                                Quantity = od.Quantity,
                                UnitPrice = od.UnitPrice,
                                KdvliFiyat = od.Quantity * od.UnitPrice * 1.2
                            })
                            .ToList();

                dgwOrderDetailList.DataSource = filteredOrderDetails;
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }

        private void dgwOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var selectedRow = dgwOrderList.Rows[e.RowIndex];

                var orderId = selectedRow.Cells["Id"].Value;

                if (orderId != null)
                {
                    var filteredOrderDetails = _orderDetailService.GetAll()
                            .Where(od => od.OrderID == (Guid)orderId)
                            .Select(od => new
                            {
                                OrderID = od.OrderID,
                                ProductID = od.ProductID,
                                ProductName = od.Product?.ProductName ?? "Ürün Adı Yok",
                                Quantity = od.Quantity,
                                UnitPrice = od.UnitPrice,
                                KdvliFiyat = od.Quantity * od.UnitPrice * 1.2
                            })
                            .ToList();

                    dgwOrderDetailList.DataSource = filteredOrderDetails;
                }
            }

        }

        private void dgwOrderDetailList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            double totalKdvliFiyat = 0;

            foreach (DataGridViewRow row in dgwOrderDetailList.Rows)
            {
                if (row.Cells["KdvliFiyat"].Value != null)
                {

                    if (double.TryParse(row.Cells["KdvliFiyat"].Value.ToString(), out double kdvliFiyat))
                    {
                        totalKdvliFiyat += kdvliFiyat;
                    }
                }
            }
            lblTotal.Text= $"Fatura Toplamı (Kdv Dahil): {totalKdvliFiyat:F2} TL";
        }
    }
}
