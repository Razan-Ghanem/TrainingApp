using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingApp.Models;
using TrainingApp.ViewModels;

namespace TrainingApp.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();

        }


    }
}
