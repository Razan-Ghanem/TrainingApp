using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.Models
{
    public class User : ImodelBase
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime creatDate { get; set; }
        public ICollection<Post> posts {get; set;}
    }
}
