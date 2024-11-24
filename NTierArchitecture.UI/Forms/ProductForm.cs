using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierArchitecture.UI.Forms
{
    public partial class ProductForm : BaseForm
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;

        private readonly SupplierService _supplierService;
        public ProductForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();

            _productService = new ProductService(new ProductRepository(dbContext));
            _categoryService = new CategoryService(new CategoryRepository(dbContext));
            _supplierService = new SupplierService(new SupplierRepository(dbContext));
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            
            cmbCategory.SelectedIndexChanged -= cmbCategory_SelectedIndexChanged;
            cmbSupplier.SelectedIndexChanged -= cmbSupplier_SelectedIndexChanged;

            GetAllData();
            chkIsActive.Checked = true;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
        }

        private void GetAllData()
        {
            cmbCategory.DataSource = _categoryService.GetAll();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;

            cmbSupplier.DataSource = _supplierService.GetAll();
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "Id";
            cmbSupplier.SelectedIndex = -1;
        }

        private void GetAllProduct()
        {
            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "PList";
            lstListe.DataSource = _productService.GetAll();
            lstListe.SelectedIndex = -1;
            //FormuTemizle();
        }



        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // category nesnesi oluştur.
                Product newCat = new Product()
                {
                    Category = selectedCategory,
                    Supplier = selectedSupplier,

                    ProductName = txtProductName.Text,
                    UnitPrice = Convert.ToDouble(txtUnitPrice.Text),
                    UnitsInStock = (int)nmrUnitInStock.Value,

                    IsActive = chkIsActive.Checked
                };

                _productService.Create(newCat);

                MessageBox.Show("Ürün başarıyla eklendi.");
                GetAllProduct();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Category? selectedCategory;
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbCategory.SelectedIndex != -1 )
            {
                selectedCategory = (Category?)cmbCategory.SelectedItem;
                
                FilterProducts();
            }
            

        }
        Supplier? selectedSupplier;
        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedIndex != -1 )
            {
                selectedSupplier = (Supplier?)cmbSupplier.SelectedItem;
                FilterProducts();
            }
        }
        private void FilterProducts()
        {
            lstUrunleriListele.SelectedIndexChanged -= lstUrunleriListele_SelectedIndexChanged;

            selectedCategory = cmbCategory.SelectedItem as Category;
            selectedSupplier = cmbSupplier.SelectedItem as Supplier;

            var filteredProducts = _productService.GetAll();

            if (selectedCategory != null)
            {
                filteredProducts = filteredProducts
                    .Where(p => p.CategoryID == selectedCategory.Id)
                    .ToList();
            }
            if (selectedSupplier != null)
            {
                filteredProducts = filteredProducts
                    .Where(p => p.SupplierID == selectedSupplier.Id)
                    .ToList();
            }
            // Listeyi güncelle
            lstUrunleriListele.DataSource = null;
            lstUrunleriListele.DataSource = filteredProducts;
            lstUrunleriListele.DisplayMember = "ProductName";
            lstUrunleriListele.ValueMember = "Id";
            lstUrunleriListele.SelectedIndex = -1;

            lstUrunleriListele.SelectedIndexChanged += lstUrunleriListele_SelectedIndexChanged;

        }

        Product selectedProduct;
        private void lstUrunleriListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunleriListele.SelectedIndex != -1)
            {
                selectedProduct = (Product?)lstUrunleriListele.SelectedItem;

                if (selectedProduct != null)
                {
                    txtProductName.Text = selectedProduct.ProductName;
                    txtUnitPrice.Text = selectedProduct.UnitPrice.ToString("F2");
                    nmrUnitInStock.Value = selectedProduct.UnitsInStock;
                    chkIsActive.Checked = selectedProduct.IsActive;
                    cmbSupplier.SelectedValue = selectedProduct.SupplierID;
                    cmbCategory.SelectedValue = selectedProduct.CategoryID;

                }
            }
        }


        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectedProduct != null)
                {
                    DialogResult cvp = MessageBox.Show("Seçilen ürünü silmek istediğinizden emin misiniz?", "Ürüne ait tüm data silinecek.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (cvp == DialogResult.Yes)
                    {
                        _productService.Delete(selectedProduct.Id);
                        MessageBox.Show("Silme işlemi başarılı.");
                        GetAllProduct();
                    }
                    else
                    {
                        
                        //_productService.ChangeProductStatus(selectedProduct.Id);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override void btnList_Click(object sender, EventArgs e)
        {
            GetAllProduct();
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct != null)
                {
                    selectedProduct.ProductName = txtProductName.Text;
                    selectedProduct.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
                    selectedProduct.UnitsInStock = Convert.ToInt16(nmrUnitInStock.Text);
                    selectedProduct.IsActive = chkIsActive.Checked;
                    selectedProduct.Category = selectedCategory;
                    selectedProduct.Supplier = selectedSupplier;


                    _productService.Update(selectedProduct);
                    MessageBox.Show("Güncelleme İşlemi Başarılı.");
                    GetAllProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            chkIsActive.Text = chkIsActive.Checked ? "Aktif" : "Pasif";
        }


    }

}
