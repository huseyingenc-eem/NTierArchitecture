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
    public partial class EmployeeForm : BaseForm
    {
        private readonly EmployeeService _employeeService;
        private readonly EmployeeRepository _employeeRepository;
        public EmployeeForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _employeeRepository = new EmployeeRepository(dbContext);
            _employeeService = new EmployeeService(_employeeRepository);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            GetAllEmployee();
        }
        private void FormuTemizle()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtCountry.Clear();
            txtCity.Clear();
            txtPhone.Clear();
            chkAktif.Checked = true;
            txtName.Focus();
        }
        private void GetAllEmployee()
        {
            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "FullName";
            lstListe.DataSource = _employeeService.GetAll();
            lstListe.SelectedIndex = -1;
            FormuTemizle();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //formdan verileri al
                string eName = txtName.Text;
                string eSurname = txtSurname.Text;
                string eCountry = txtCountry.Text;
                string eCity = txtCity.Text;
                string ePhone = txtPhone.Text;
                // Employee nesnesi oluştur.
                Employee newCat = new Employee()
                {
                    Name = eName,
                    SurName = eSurname,
                    Country = eCountry,
                    City = eCity,
                    Phone = ePhone,
                    IsActive = chkAktif.Checked
                };

                _employeeService.Create(newCat);

                MessageBox.Show("Çalışan başarıyla eklendi.");
                GetAllEmployee();
                // Formu temizleyin veya ilgili kontrolleri sıfırlayın

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Employee selectedEmployee;
        private string oldPhone;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                selectedEmployee = (Employee?)lstListe.SelectedItem;

                if (selectedEmployee != null)
                {
                    txtName.Text = selectedEmployee.Name;
                    txtSurname.Text = selectedEmployee.SurName;
                    txtPhone.Text = selectedEmployee.Phone;
                    txtCity.Text = selectedEmployee.City;
                    txtCountry.Text = selectedEmployee.Country;
                    chkAktif.Checked = selectedEmployee.IsActive;
                    oldPhone = txtPhone.Text;
                }
            }
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectedEmployee != null)
                {
                        selectedEmployee.Name = txtName.Text;
                        selectedEmployee.SurName = txtSurname.Text;
                        selectedEmployee.City = txtCity.Text;
                        selectedEmployee.Country = txtCountry.Text;
                        selectedEmployee.Phone = txtPhone.Text;
                        selectedEmployee.IsActive = chkAktif.Checked;
                        
                }
                _employeeService.Update(selectedEmployee);
                MessageBox.Show("Güncelleme İşlemi Başarılı.");
                GetAllEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPhone.Text=oldPhone;
            }
        }


        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee != null)
                    _employeeService.Delete(selectedEmployee.Id);

                GetAllEmployee();
                MessageBox.Show("Silme İşlemi Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void btnList_Click(object sender, EventArgs e)
        {
            GetAllEmployee();
        }
        

        private void chkAktif_CheckedChanged(object sender, EventArgs e)
        {
            chkAktif.Text = chkAktif.Checked ? "Aktif" : "Pasif";
        }

    }
}
