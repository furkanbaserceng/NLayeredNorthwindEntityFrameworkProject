using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IProductService _productservice = new ProductManager(new ProductDal());

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productservice.GetAll();
        }
    }
}