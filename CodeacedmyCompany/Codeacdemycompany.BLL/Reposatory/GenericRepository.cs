using Codeacdemycompany.BLL.Interfaces;
using CodeacdemyCompany.DAL.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeacdemycompany.BLL.Reposatory
{
    public class GenericRepository<T> : IGenericRepository<T>  where T : class
    {


        private readonly ApplicationDbContext _context; //==> EMPTY 

        public GenericRepository(ApplicationDbContext context)
        {
            //_context = new ApplicationDbContext()
            _context = context; //
        }


        public int Create(T item)
        {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
        }

        public int Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        public T Get(int id)
           => _context.Set<T>().Find(id);



        //public IEnumerable<T> GetAll()
        //
        //=> _context.Set<T>().ToList();
        IEnumerable<T> GetAll()
        {  return _context.Set<T>().ToList();
        }



        public int Update(T item)
        {

            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }

       
    }
}
