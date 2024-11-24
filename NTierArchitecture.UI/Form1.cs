using NTierArchitecture.UI.Forms;

namespace NTierArchitecture.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanýcýEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            //Formun instance alýnýr.
            CustomerForm ctrForm = new CustomerForm();
            ctrForm.MdiParent = this;
            FormControl(ctrForm);
        }

        private void FormControl(Form frm)
        {
            bool acikMi=false;
            foreach (var item in Application.OpenForms) 
            {
                if (item.GetType()==frm.GetType()) 
                {
                    acikMi = true;
                    break;
                }
            }
            if (acikMi) 
                MessageBox.Show("Form Zaten Açýk duurmda");
            else 
                frm.Show();
        }

        private void çalýþanEklemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.MdiParent = this;
            FormControl(empForm);
        }

        private void tedarikçiEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.MdiParent = this;
            FormControl(supplierForm);
        }

        private void kategoriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.MdiParent = this;
            FormControl(categoryForm);
        }

        private void ürünEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            FormControl(productForm);
        }

        private void sipariþOluþturmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.MdiParent = this;
            FormControl(orderForm);
        }
    }
}
