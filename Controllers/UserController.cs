using Annabakes.API.Context;
using Annabakes.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annabakes.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("users")]
        [HttpGet]
        public List<User> GetAllUsers()
        {
            using var dbContext = new BakeryDbContext();
            return dbContext.Users.ToList();

        }

        [Route("users")]
        [HttpPost]
        public bool CreateUsers(User users)
        {
            using var dbContext = new BakeryDbContext();

            dbContext.Users.Add(users);
            dbContext.SaveChanges();

            return true;
        }
    }
}
