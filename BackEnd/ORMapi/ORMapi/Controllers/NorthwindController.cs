﻿using Microsoft.AspNetCore.Mvc;
using ORMapi.Modelo;
using ORMapi.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ORMapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindController : ControllerBase
    {
        private readonly INorthwindRepository _repository;

        public NorthwindController(INorthwindRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        [Route("api/TodosLosEmpleados")]

        public async Task<List<Employee>> GetAll()
        {
            return await _repository.ObtenerTodosLosEmpleados()
        }
    }
}
