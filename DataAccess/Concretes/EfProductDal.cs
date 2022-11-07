using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Connection;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfProductDal: EfEntityRepositoryBase<Product, AppDbContext>, IProductDal
    {
    }
}
