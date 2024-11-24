using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.UI.Forms
{
    public partial class CustomerForm : BaseForm
    {
        private readonly CustomerService _customerService;
        private readonly CustomerRepository _customerRepository;


        public CustomerForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _customerRepository = new CustomerRepository(dbContext);
            _customerService = new CustomerService(_customerRepository);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            GetAllCustomers();
        }
        private void GetAllCustomers()
        {
            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "CustomerName";
            lstListe.DataSource = _customerService.GetAll().ToList(); // Liste olarak bağlayın
            lstListe.SelectedIndex = -1;
            FormuTemizle();
        }
        private void FormuTemizle()
        {
            txtCustomerName.Clear();
            txtCountry.Clear();
            txtCity.Clear();
            txtPhone.Clear();
            chkAktif.Checked = true;
            txtCustomerName.Focus();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //formdan verileri al
                string customerName = txtCustomerName.Text;
                string county = txtCountry.Text;
                string city = txtCity.Text;
                string phone = txtPhone.Text;

                //customer nesnesi oluştur.
                Customer newCust = new Customer()
                {
                    CustomerName = customerName,
                    Country = county,
                    City = city,
                    Phone = phone,
                    IsActive = chkAktif.Checked
                };
                _customerService.Create(newCust);

                MessageBox.Show("Müşteri başarıyla eklendi.");
                GetAllCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenCustomer != null)
                    _customerService.Delete(secilenCustomer.Id);

                GetAllCustomers();
                MessageBox.Show("Silme İşlemi Başarılı.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        Customer secilenCustomer;
        private string oldPhone;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili öğeye göre işlemleri burada yapabilirsiniz
            secilenCustomer = (Customer)lstListe.SelectedItem; // Customer olarak dönüştür
            if (secilenCustomer != null)
            {
                txtCustomerName.Text = secilenCustomer.CustomerName;
                txtCountry.Text = secilenCustomer.Country;
                txtCity.Text = secilenCustomer.City;
                txtPhone.Text = secilenCustomer.Phone;
                chkAktif.Checked = secilenCustomer.IsActive;
                oldPhone = secilenCustomer.Phone; // Telefon numarasını sakla
            }
            
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenCustomer != null)
                {
                    secilenCustomer.CustomerName = txtCustomerName.Text;
                    secilenCustomer.Country = txtCountry.Text;
                    secilenCustomer.City = txtCity.Text;
                    secilenCustomer.Phone = txtPhone.Text;
                    secilenCustomer.IsActive = chkAktif.Checked;

                }
                _customerService.Update(secilenCustomer);
                MessageBox.Show("Müşteri Güncelleme İşlemi Başarılı.");
                GetAllCustomers();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPhone.Text = oldPhone;
            }
        }

        private void chkAktif_Checked(object sender, EventArgs e)
        {
            chkAktif.Text = chkAktif.Checked ? "Aktif" : "Pasif";
        }


        protected override void btnList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        
    }
}
