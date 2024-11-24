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
    public partial class CategoryForm : BaseForm
    {
        private readonly CategoryService _categoryService;
        private readonly CategoryRepository _categoryRepository;


        public CategoryForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _categoryRepository = new CategoryRepository(dbContext);
            _categoryService = new CategoryService(_categoryRepository);
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        private void FormuTemizle()
        {
            txtKategoriAdi.Clear();
            txtAciklama.Clear();
            chkAktif.Checked = false;
            txtKategoriAdi.Focus();
        }
        private void GetAllCategories()
        {
            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "CategoryName";
            lstListe.DataSource = _categoryService.GetAll();
            lstListe.SelectedIndex = -1;
            FormuTemizle();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //formdan verileri al
                string cName = txtKategoriAdi.Text;
                string cDesc = txtAciklama.Text;

                // category nesnesi oluştur.
                Category newCat = new Category()
                {
                    CategoryName = cName,
                    Description = cDesc,
                    IsActive = chkAktif.Checked
                };

                _categoryService.Create(newCat);

                MessageBox.Show("Kategori başarıyla eklendi.");
                GetAllCategories();
                // Formu temizleyin veya ilgili kontrolleri sıfırlayın
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        
        private void cmkAktif_CheckedChanged(object sender, EventArgs e)
        {
            chkAktif.Text = chkAktif.Checked ? "Aktif" : "Pasif";
        }

        Category secilenCategory;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilenCategory = (Category?)lstListe.SelectedItem;

                if (secilenCategory != null)
                {
                    txtKategoriAdi.Text = secilenCategory.CategoryName;
                    txtAciklama.Text = secilenCategory.Description;
                    chkAktif.Checked = secilenCategory.IsActive;
                }
            }
        }

        protected override void btnList_Click(object sender, EventArgs e)
        {
            GetAllCategories();
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenCategory != null)
                {
                    secilenCategory.CategoryName = txtKategoriAdi.Text;
                    secilenCategory.Description = txtAciklama.Text;
                    secilenCategory.IsActive = chkAktif.Checked;
                }
                _categoryService.Update(secilenCategory);
                MessageBox.Show("Güncelleme İşlemi Başarılı.");
                GetAllCategories() ;
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
                if (secilenCategory != null)
                    _categoryService.Delete(secilenCategory.Id);

                GetAllCategories();
                MessageBox.Show("Silme İşlemi Başarılı.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
