using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulschool.Models;

namespace Modulschool.Services.Interface
{
    public interface IAnimalInfoService
    {
        Task<Animal> GetById(int id);
        void PutById(int id,Animal animal);
    }
}
