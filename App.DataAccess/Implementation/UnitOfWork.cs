using App.DataAccess.Context;
using App.Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ActorRepo=new ActorRepo(_db);
            BiographyRepo=new BiographyRepo(_db);
            GenreRepo=new GenreRepo(_db);
            MovieRepo=new MovieRepo(_db);
        }

        public IActorRepo ActorRepo { private set; get; }

        public IBiographyRepo BiographyRepo { private set; get; }

        public IGenreRepo GenreRepo { private set; get; }

        public IMovieRepo MovieRepo { private set; get; }

        public void Dispose()
        {
             _db.Dispose();
            
        }

        public int save()
        {
          return  _db.SaveChanges();
        }
    }
}
