using Microsoft.AspNetCore.Mvc;
using WebApp.EjemploInterfaz;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        [HttpGet("perro")]
        public string GetPerro()
        {
            IAnimal perro = new Perro("Luna");
            return $"{perro.Name} dice {perro.HacerSonido()}";
        }

        [HttpGet("gato")]
        public string GetGato()
        {
            IAnimal gato = new Gato("Veneno");
            return $"{gato.Name} dice {gato.HacerSonido()}";
        }
    }
}