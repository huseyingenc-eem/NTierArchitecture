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

        private void kullan�c�EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            //Formun instance al�n�r.
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
                MessageBox.Show("Form Zaten A��k duurmda");
            else 
                frm.Show();
        }

        private void �al��anEklemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.MdiParent = this;
            FormControl(empForm);
        }

        private void tedarik�iEklemeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void �r�nEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            FormControl(productForm);
        }

        private void sipari�Olu�turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.MdiParent = this;
            FormControl(orderForm);
        }
    }
}
