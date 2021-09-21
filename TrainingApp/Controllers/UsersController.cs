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

    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _Repo;
        private readonly IMapper _mapper;

        public UsersController(IUserRepo repo, IMapper mapper)
        {
            _Repo = repo;
            _mapper = mapper;

        }

        // GET: api/Users
        [HttpGet]

        public List<UserViewModel> GetUser()
        {
            var user = _Repo.Get();
            return _mapper.Map<List<UserViewModel>>(user);

        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public UserViewModel GetUser([FromBody] long id)
        {
            var user = _Repo.GetbyId(id);

            if (user == null)
            {
                return null;
            }

            return _mapper.Map<UserViewModel>(user);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]

        public void PutUser([FromBody] UserViewModel uservm)
        {
            var user = _mapper.Map<User>(uservm);
            _Repo.Update(user);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostUser([FromBody] UserViewModel uservm)
        {
            var user = _mapper.Map<User>(uservm);

            _Repo.Add(user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public void DeleteUser(long id)
        {
            _Repo.Delete(id);

        }
        [HttpGet("getPosts")]
        public  List<UserViewModel> GetUserPosts()
        {
            var user = _Repo.getPosts();
            return _mapper.Map<List<UserViewModel>>(user);
        }

        [HttpGet("getProj")]
        public List<UserViewModel> getProj()
        {
            return _Repo.getProj().ToList();
        }



        //private bool UserExists(long id)
        //{
        //    return _context.User.Any(e => e.Id == id);
        //}
    }
}
