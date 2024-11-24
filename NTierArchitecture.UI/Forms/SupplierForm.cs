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
    public partial class SupplierForm : BaseForm
    {
        private readonly SupplierService _supplierService;
        private readonly SupplierRepository _supplierRepository;
        public SupplierForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _supplierRepository = new SupplierRepository(dbContext);
            _supplierService = new SupplierService(_supplierRepository);
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            GetAllSuppliers();
        }
        private void GetAllSuppliers()
        {
            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "CompanyName";
            lstListe.DataSource = _supplierService.GetAll();
            lstListe.SelectedIndex = -1;
            FormuTemizle();
        }
        private void FormuTemizle()
        {
            txtCompanyName.Clear();
            txtContactTitle.Clear();
            txtCountry.Clear();
            txtCity.Clear();
            txtPhone.Clear();
            chkAktif.Checked = true;
            txtCompanyName.Focus();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // category nesnesi oluştur.
                Supplier newSup = new Supplier()
                {
                    CompanyName = txtCompanyName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Phone = txtPhone.Text,
                    IsActive = chkAktif.Checked
                };

                _supplierService.Create(newSup);

                MessageBox.Show("Tedarikçi başarıyla eklendi.");
                GetAllSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Supplier? selectedSupplier;
        
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                selectedSupplier = (Supplier?)lstListe.SelectedItem;

                if (selectedSupplier != null)
                {
                    txtCompanyName.Text = selectedSupplier.CompanyName;
                    txtContactTitle.Text = selectedSupplier.ContactTitle;
                    txtCountry.Text = selectedSupplier.Country;
                    txtCity.Text = selectedSupplier.City;
                    txtPhone.Text = selectedSupplier.Phone;
                    chkAktif.Checked = selectedSupplier.IsActive;
                }
            }
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSupplier != null)
                {
                    selectedSupplier.ContactTitle = txtContactTitle.Text;
                    selectedSupplier.Country = txtCountry.Text;
                    selectedSupplier.City = txtCity.Text;
                    
                    selectedSupplier.Phone = txtPhone.Text;
                    selectedSupplier.IsActive = chkAktif.Checked;
                }
                _supplierService.Update(selectedSupplier);
                MessageBox.Show("Güncelleme İşlemi Başarılı.");
                GetAllSuppliers();
                lstListe.SelectedIndex = lstListe.Items.IndexOf(selectedSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void btnList_Click(object sender, EventArgs e)
        {
            GetAllSuppliers();
        }
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSupplier != null)
                    _supplierService.Delete(selectedSupplier.Id);

                GetAllSuppliers();
                MessageBox.Show("Silme İşlemi Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkAktif_CheckedChanged(object sender, EventArgs e)
        {
            chkAktif.Text = chkAktif.Checked ? "Aktif" : "Pasif";
        }



    }
}
