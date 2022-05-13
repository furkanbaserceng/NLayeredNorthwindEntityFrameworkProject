using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.Context;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete
{
    public class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using (NorthwindContext context=new NorthwindContext())
            {

                return context.Products.ToList();

            }
        }

        public Product Get(int id)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);

            }
        }

        

        public void Add(Product product)
        {
            using (NorthwindContext context=new NorthwindContext())
            {

                var addedEntity = context.Entry(product);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                var updatedEntity = context.Entry(product);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                var deletedEntity = context.Entry(product);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

       

        
    }
}
