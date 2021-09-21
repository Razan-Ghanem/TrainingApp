using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp
{
    public interface IgenRepo<T> where T:class, ImodelBase
    {
        List<T> Get();
        T GetbyId(long id);
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        void Delete(long id);
    }
}
