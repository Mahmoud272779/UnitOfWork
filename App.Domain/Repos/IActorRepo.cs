using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Repos
{
    public interface IActorRepo:IGenericRepo<Actor>
    {
        public IEnumerable<Actor> getallActors();
    }
}
