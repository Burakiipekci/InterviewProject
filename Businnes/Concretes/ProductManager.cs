using Businnes.Abstracts;
using Businnes.Constants;
using Core.Concretes;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concretes
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
    
        public IResult Add(Product brand)
        {
            _productDal.Add(brand);
            return new SuccessResult(Messages.Added); 
        }

        public IResult Delete(Product brand)
        {
            _productDal.delete(brand);
            return new SuccessResult(Messages.Deleted); 
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Product>> GetByCategory(string category)
        {
            if (category == null)
                return new SuccessDataResult<List<Product>>(_productDal.GetAll());
            else
                return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.Category == category));
        }

        public IDataResult<List<Product>> GetById(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(b => b.Id == id));
        }

        public IResult Update(Product brand)
        {
            _productDal.update(brand);
            return new SuccessResult(Messages.Updated);
        }
    }
}
