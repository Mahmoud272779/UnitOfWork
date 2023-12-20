using App.DataAccess.Context;
using App.Domain.Entities;
using App.Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Implementation
{
    public class BiographyRepo : GenericRepo<Biography>, IBiographyRepo
    {
        public BiographyRepo(ApplicationDbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
