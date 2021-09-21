using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.Models
{
    public class Post: ImodelBase
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public string Title { get; set; }
        public long UserId { get; set; }
        [ForeignKey(name:"UserId")]
        public User user { get; set; }
        public DateTime creatDate { get; set; }
    }
}
