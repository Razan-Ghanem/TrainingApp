using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingApp.Data;
using TrainingApp.IRepo;
using TrainingApp.Models;
using TrainingApp.ViewModels;

namespace TrainingApp.Repo
{
   
    public class UserRepo :genRepo<User> , IUserRepo 
    {
        private readonly TodoContext _context;
        private readonly IMapper _mapper;

        public UserRepo(TodoContext repo, IMapper mapper): base(repo)
        {
            _context = repo;
            _mapper = mapper;
        }

        public List<UserViewModel> getProj()
        {
            return _context.User.ProjectTo<UserViewModel>(_mapper.ConfigurationProvider).ToList();
        }

        public List<User> getPosts()
        {

            return _context.User.Include(u => u.posts).ToList();
        }




    } 
}
