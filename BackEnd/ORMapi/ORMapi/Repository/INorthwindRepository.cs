using ORMapi.Modelo;

namespace ORMapi.Repository
{
    public interface INorthwindRepository
    {
       

        Task<List<Employee>> ObtenerTodosLosEmpleados();

        Task<int> ObtenerlaCantidadDeEmpleados();



    }
}
}
