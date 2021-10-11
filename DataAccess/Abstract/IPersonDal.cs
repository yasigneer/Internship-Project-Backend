using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IPersonDal : IEntityRepository<Person>
    {
    }
}
