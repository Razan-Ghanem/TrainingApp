using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp
{
    public interface ImodelBase
    {
        public long Id { get; set; }
        public DateTime creatDate { get; set; }
    }
}
