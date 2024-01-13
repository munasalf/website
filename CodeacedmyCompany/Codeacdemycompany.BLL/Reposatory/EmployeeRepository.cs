using Codeacdemycompany.BLL.Interfaces;
using CodeacdemyCompany.DAL.ApplicationDbContext;
using CodeacdemyCompany.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeacdemycompany.BLL.Reposatory
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Employee> address(string name)
        {
            var employees = _context.Employees.Where(e => e.Name == name);
            return employees;
        }
    }
    

    
}
