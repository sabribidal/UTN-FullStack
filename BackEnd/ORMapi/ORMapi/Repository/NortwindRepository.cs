using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ORMapi.Data;
using ORMapi.Modelo;

namespace ORMapi.Repository
{
    public class NortwindRepository : INorthwindRepository
    {
        private readonly DataContext _context;

        public NortwindRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<Employee>> ObtenerTodosLosEmpleados()
        {
            return await this._context.Employees.ToListAsync();
        }

        public async Task<int> ObtenerlaCantidadDeEmpleados()
        {
            return await this._context.Employees.CountAsync();
        }
    }
}
