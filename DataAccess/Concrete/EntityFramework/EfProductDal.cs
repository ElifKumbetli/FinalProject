using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Burası entityframework e göre kodlanacak.
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetail(int id)
        {
            throw new NotImplementedException();
        }

        //NuGet
        //IDisposable pattern implementation of c#
        //Belleği hızlıca temizleme
        //State: Durum
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, 
                                 CategoryName = c.CategoryName, UnitsInStock =p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
