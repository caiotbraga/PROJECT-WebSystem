using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext context;

        public DepartmentService(SalesWebMvcContext c)
        {
            context = c;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await context.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
