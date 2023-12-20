using App.Domain.Entities;
using App.Domain.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ActorsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(unitOfWork.ActorRepo.getall());
        }

        [HttpGet("GetActorsWithMovies")]
        public ActionResult<IEnumerable<Actor>> Getall()
        {
            return Ok(unitOfWork.ActorRepo.getallActors());
        }
    }
}
