using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingApp.Models;
using TrainingApp.ViewModels;

namespace TrainingApp.IRepo
{
    public interface IUserRepo: IgenRepo<User>
    {
        List<User> getPosts();
        List<UserViewModel> getProj();

    }
}
