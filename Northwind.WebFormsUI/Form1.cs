using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernateFake;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IProductService _productService = new ProductManager(new EfProductDal()); //form1 ctorunda new leme iþlemi yapýlabilirdi.
                                                                                  // IProductService _productService = new ProductManager(new NhProductDal()); //sistem kolayca nhibernate e geçirilebiliyor.

        ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }
        private void ListCategories()
        {
            cbxListCategories.DataSource = _categoryService.GetAll();
            cbxListCategories.DisplayMember = "CategoryName";
            cbxListCategories.ValueMember = "CategoryId";
        }

        private void cbxListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetByCategoryId(Convert.ToInt32(cbxListCategories.SelectedValue));
            }
            catch 
            {

               
            }
        }

        private void tbxSearchProductName_TextChanged(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productService.GetSearchProductName(tbxSearchProductName.Text);
        }
    }
}