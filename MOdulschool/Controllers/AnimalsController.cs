using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Modulschool.BusinessLogic;
using Modulschool.Models;


namespace Modulschool.Controllers
{
    [Route("api/animals")]
    public class AnimalsController: ControllerBase
    {
        private readonly GetAnimalsInfoRequestHandler _getAnimalsInfoRequestHandler;

        public AnimalsController(GetAnimalsInfoRequestHandler getAnimalsInfoRequestHandler)
        {
            _getAnimalsInfoRequestHandler = getAnimalsInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<Animal> GetAnimalInfo(int id)
        {
            return _getAnimalsInfoRequestHandler.Handle(id);
        }

        /*[HttpPut("{id}")]
        public Task<Animal> PutAnimalInfo(int id,Animal animal)
        {
              return _getAnimalsInfoRequestHandler.PutHandle(id,animal);
        }*/
        [HttpPut("{id}")]
        public void PutAnimalInfo(int id, Animal animal)
        {
             _getAnimalsInfoRequestHandler.PutHandle(id, animal);
        }
    }
}
