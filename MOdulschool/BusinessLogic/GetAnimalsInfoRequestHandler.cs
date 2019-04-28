using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulschool.Services.Interface;
using Modulschool.Models;


namespace Modulschool.BusinessLogic
{
    public class GetAnimalsInfoRequestHandler
    {
        private readonly IAnimalInfoService _animalInfoService;

        public GetAnimalsInfoRequestHandler(IAnimalInfoService animalInfoService)
        {
            _animalInfoService = animalInfoService;
        }

        public Task<Animal> Handle(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Некорректный идентификатор пользователя", nameof(id));
            }
            return _animalInfoService.GetById(id);
        }
        public void PutHandle(int id,Animal animal)
        {
            if (id == 0)
            {
                throw new ArgumentException("Некорректный идентификатор пользователя", nameof(id));
            }
             _animalInfoService.PutById(id,animal);
        }

    }
}
