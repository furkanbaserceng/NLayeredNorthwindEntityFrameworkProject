using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        List<Product> GetSearchProductName(string searchKey);

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);


    }
}
