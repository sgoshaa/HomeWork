using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Modulschool.Models;
using Modulschool.Services.Interface;
using Npgsql;
using Modulschool.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Modulschool.Services
{
    public class AnimalInfoService : IAnimalInfoService
    {
        //int pass = 1;
        private const string ConnectionString =
           "host=localhost;port=5432;database=animals;username=postgres;password=1";



        public async Task<Animal> GetById(int id)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                return await connection.QuerySingleAsync<Animal>(
                    "SELECT * FROM animal WHERE Id = @id", new { id });
            }
        }

        /* public  async Task<Animal> PutById(int id,Animal animal)
         {
             using (var connection = new NpgsqlConnection(ConnectionString))
             {
                  await connection.ExecuteAsync(
                     "UPDATE animal SET nickname = @Nickname, typeanimal = @Typeanimal, age = @Age WHERE id = @Id", new { id, animal.Nickname, animal.TypeAnimal, animal.Age }); //{ id, Nickname="Кузьма", typeanimal="ПСИНА",Age=7});//
                 return NoContentResult() ;

             }*/
        public async void PutById(int id, Animal animal)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                await connection.ExecuteAsync(
                   "UPDATE animal SET nickname = @Nickname, typeanimal = @Typeanimal, age = @Age WHERE id = @Id", new { id, Nickname = "Кузьма", typeanimal = "ПСИНА",Age = 7}); //{ id, Nickname="Кузьма", typeanimal="ПСИНА",Age=7});//
               

            }
       
        }

        private Animal NoContentResult()
        {
            throw new NotImplementedException();
        }
    }
}
