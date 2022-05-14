using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetSearchProductName(string searchKey)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(searchKey.ToLower())).ToList();
        }

        public void Add(Product product)
        {
            ProductValidator productValidator = new ProductValidator(); //static classdan alınabalir.
            var result = productValidator.Validate(product);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            else 
            {
                _productDal.Add(product);
            }
        }

        public void Update(Product product)
        {
            ProductValidator productValidator = new ProductValidator(); //static classdan alınabalir.
            var result = productValidator.Validate(product);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            else
            {
                _productDal.Update(product);
            }

            
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {

                throw new Exception("Unsuccesfull Operations!!!");
            }
        }
    }
}
