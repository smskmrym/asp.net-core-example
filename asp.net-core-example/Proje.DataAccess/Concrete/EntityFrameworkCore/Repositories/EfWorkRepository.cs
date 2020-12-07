using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proje.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Proje.DataAccess.Interfaces;
using Proje.Entities.Concrete;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfWorkRepository : EfGenericRepository<Work>, IWorkDal
    {
        
    }
}
