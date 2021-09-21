using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingApp.Data;
using TrainingApp.IRepo;
using TrainingApp.Models;
using TrainingApp.Repo;
using TrainingApp.ViewModels;

namespace TrainingApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepo _Repo;
        private readonly IMapper _mapper;


        public PostsController(IPostRepo Repo, IMapper mapper)
        {
            _Repo = Repo;
            _mapper = mapper;
        }

        // GET: api/Posts
        [HttpGet]
        public  List<PostViewModel> GetPost()
        {
            var post = _Repo.Get();
            return _mapper.Map<List<PostViewModel>>(post);
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public PostViewModel GetPost(long id)
        {
            var post =  _Repo.GetbyId(id);

            if (post == null)
            {
                return null;
            }

            return _mapper.Map<PostViewModel>(post);
           
        }

        // PUT: api/Posts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public void PutPost([FromBody] PostViewModel postvm)
        {
            var post = _mapper.Map<Post>(postvm);
            _Repo.Update(post);  
            
        }

        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostPost([FromBody]PostViewModel postvm)
        {
            var post = _mapper.Map<Post>(postvm);

            _Repo.Add(post);

        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public void DeletePost(long id)
        {
             _Repo.Delete(id);
         
        }
       

    }
}
