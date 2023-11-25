using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
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
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        //NuGet
        //IDisposable pattern implementation of c#
        //Belleği hızlıca temizleme
        //State: Durum

    }
}
