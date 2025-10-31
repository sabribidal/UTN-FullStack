using System.Collections.Generic;

namespace MiPrimerAPI.Repositories
{
    public class InstrumentRepository
    {
        public List<string> Instruments { get; set; }

        public InstrumentRepository()
        {
            Instruments = new List<string> { "Bajo", "Guitarra", "Flauta" };
        }
    }
}