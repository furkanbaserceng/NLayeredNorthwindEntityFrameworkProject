using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernateFake;
using Northwind.Entities.Concrete;

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

            
            cbxProductCategoryAdd.DataSource = _categoryService.GetAll();
            cbxProductCategoryAdd.DisplayMember = "CategoryName";
            cbxProductCategoryAdd.ValueMember = "CategoryId";


            cbxProductCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxProductCategoryUpdate.DisplayMember = "CategoryName";
            cbxProductCategoryUpdate.ValueMember = "CategoryId";
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
            if (!String.IsNullOrEmpty(tbxSearchProductName.Text))
            {
                dgwProducts.DataSource = _productService.GetSearchProductName(tbxSearchProductName.Text);
            }
            else
            {
                ListProducts();
            }
            
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxProductCategoryAdd.SelectedValue),
                ProductName = tbxProductNameAdd.Text,
                UnitPrice = Convert.ToDecimal(tbxProductUnitPriceAdd.Text),
                UnitsInStock = Convert.ToInt16(tbxProductUnitsInStockAdd.Text),
                QuantityPerUnit = tbxProductQuantityPerUnitAdd.Text



            });

            MessageBox.Show("Product Added Successfully!");

            ListProducts();

            ClearAddProductGroupBoxItems();

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {

            _productService.Update(new Product
            {

                ProductId=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                CategoryId=Convert.ToInt32(cbxProductCategoryUpdate.SelectedValue),
                ProductName=tbxProductNameUpdate.Text,
                UnitPrice=Convert.ToDecimal(tbxProductUnitPriceUpdate.Text),
                UnitsInStock=Convert.ToInt16(tbxProductUnitsInStockUpdate.Text),
                QuantityPerUnit=tbxProductQuantityPerUnitUpdate.Text


            });

            MessageBox.Show("Product Updated Successfully!");

            ListProducts();

            ClearUpdateOrDeleteProductGroupBoxItems();

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProducts.CurrentRow != null)
                {
                    _productService.Delete(new Product
                    {

                        ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),



                    });

                    MessageBox.Show("Product Deleted Successfully!");

                    ListProducts();

                    ClearUpdateOrDeleteProductGroupBoxItems();
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void ClearUpdateOrDeleteProductGroupBoxItems()
        {
            tbxProductNameUpdate.Clear();
            tbxProductQuantityPerUnitUpdate.Clear();
            tbxProductUnitPriceUpdate.Clear();
            tbxProductUnitsInStockUpdate.Clear();
            cbxProductCategoryUpdate.Text = "";
        }

        private void ClearAddProductGroupBoxItems()
        {
            tbxProductNameAdd.Clear();
            tbxProductQuantityPerUnitAdd.Clear();
            tbxProductUnitPriceAdd.Clear();
            tbxProductUnitsInStockAdd.Clear();
            cbxProductCategoryAdd.Text = "";
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           


            tbxProductNameUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxProductUnitPriceUpdate.Text=dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxProductQuantityPerUnitUpdate.Text=dgwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxProductUnitsInStockUpdate.Text=dgwProducts.CurrentRow.Cells[5].Value.ToString();
            cbxProductCategoryUpdate.SelectedValue = dgwProducts.CurrentRow.Cells[1].Value;




        }

        
    }
}