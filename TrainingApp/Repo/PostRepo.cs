using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingApp.Data;
using TrainingApp.IRepo;
using TrainingApp.Models;

namespace TrainingApp.Repo
{
    public class PostRepo : genRepo<Post>, IPostRepo
    {
        public PostRepo(TodoContext repo):base(repo)
        {
            
        }
    }
}
