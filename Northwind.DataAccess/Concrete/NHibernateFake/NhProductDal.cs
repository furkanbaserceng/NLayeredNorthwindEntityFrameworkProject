using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernateFake
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product{
                    ProductId = 1,
                    CategoryId = 1,
                    ProductName = "Asus Laptop",
                    UnitPrice = 12000,
                    UnitsInStock = 5000,
                    QuantityPerUnit = "3 in a box"},
                new Product{
                    ProductId = 2,
                    CategoryId = 1,
                    ProductName = "Lenovo Laptop",
                    UnitPrice = 16000,
                    UnitsInStock = 1000,
                    QuantityPerUnit = "5 in a box"}
            };
            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
