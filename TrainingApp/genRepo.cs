using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingApp.Data;

namespace TrainingApp
{
    public class genRepo<T> : IgenRepo<T> where T : class, ImodelBase
    {
        private readonly TodoContext _context;

        public genRepo(TodoContext repo)
        {
            _context = repo;
        }

        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }
        public T GetbyId(long id)
        {
                return _context.Set<T>().FirstOrDefault(i => i.Id ==id);


        }

        public void Update(T obj)
        {
            _context.Set<T>().Update(obj);
            _context.SaveChanges();

        }



        public void Add(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();

        }

        public void Delete(long id)
        {
            var obj = _context.Set<T>().FirstOrDefault(i => i.Id == id);
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChangesAsync();
        }

      
        

 
    }
}
