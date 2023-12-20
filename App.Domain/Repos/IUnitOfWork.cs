using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Repos
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepo ActorRepo { get; }
        IBiographyRepo BiographyRepo { get; }
        IGenreRepo  GenreRepo { get; }
        IMovieRepo MovieRepo { get; }
        int save();
    }
}
