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

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productService.GetAll();
        }
    }
}