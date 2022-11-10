using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstracts
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetById(int id);
        IDataResult<List<Product>> GetByCategory(int category);
        IResult Add(Product brand);
        IResult Delete(Product brand);
        IResult Update(Product brand);
    }
}
