using Microsoft.AspNetCore.Mvc; 
using WebApp.Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class InstrumentsController : ControllerBase
    {
        private readonly InstrumentRepository repository;

        public InstrumentsController(InstrumentRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]

        public ActionResult<IEnumerable<string>> GetInstruments()
        {
            return Ok(repository.Instruments); 
        }

        [HttpPost]
        public ActionResult<string> AddInstrument([FromBody] string instrument)
        {
            repository.Instruments.Add(instrument);
            return Ok($"Instrumento agregado: {instrument}");
        }

        [HttpPut("{index}")] 
        public ActionResult<string> UpdateInstrument(int index, [FromBody] string newInstrument)
        {
            if (index < 0 || index >= repository.Instruments.Count)
            {
                return NotFound($"No existe un instrumento en la posición {index}");
            }

            repository.Instruments[index] = newInstrument;
            return Ok($"Instrumento en posición {index} actualizado a: {newInstrument}");
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteInstrument(int id)
        {
            if (id < 0 || id >= repository.Instruments.Count)
            {
                return NotFound($"No existe un intrumento para borrar en la posición {id}");
            }
            repository.Instruments.RemoveAt(id);
            return Ok($"Instrumento en posición {id} eliminado.");
        }
    }
}