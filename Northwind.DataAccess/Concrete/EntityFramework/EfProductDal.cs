using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework.Context;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<NorthwindContext,Product>, IProductDal
    {
        

       

        
    }
}
