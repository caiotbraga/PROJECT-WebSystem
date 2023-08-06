using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext context;

        public DepartmentService(SalesWebMvcContext c)
        {
            context = c;
        }

        public List<Department> FindAll()
        {
            return context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
