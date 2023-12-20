using App.DataAccess.Context;
using App.Domain.Entities;
using App.Domain.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Implementation
{
    public class ActorRepo : GenericRepo<Actor>, IActorRepo
    {
        public ActorRepo(ApplicationDbContext dbcontext) : base(dbcontext)
        {

        }

        public IEnumerable<Actor> getallActors()
        {
            return _dbcontext.Actors.Include(e => e.Movies).ToList();
        }
    }
}
