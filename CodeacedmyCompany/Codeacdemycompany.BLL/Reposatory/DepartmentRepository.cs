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
    public class DepartmentRepository  : GenericRepository<Department> , IDepartmentReposatory
    {

        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {


        }
    }
}
