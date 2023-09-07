using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFremwork
{
    public class EfBrandDal : IBrandDal
    {

        List<Brand> brand = new List<Brand>();


        public void Add(Brand entity)
        {
            brand.Add(entity);
            
        }

        public void Delete(Brand entity)
        {
            brand.Remove(entity);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
