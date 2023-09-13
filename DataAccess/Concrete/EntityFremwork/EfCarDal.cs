using Core.DataAccess.EntityFremwork;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFremwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car,ReCapDbContext>, ICarDal, IEntityRepository<Car>
    {
        //
    }
}
