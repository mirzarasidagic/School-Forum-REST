using myAPI.ClassModel;
using myAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myAPI.Controllers
{
    public class UsersController : ApiController
    {

        IUserServices _userService = null;
        IPostServices _postService = null;

        public UsersController()
        {
            _userService = new UserServices();
            
        }
        
        
        // GET: api/Users
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }

        // GET: api/Users/id
        [HttpGet]
        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        // GET User by post Id
        [HttpGet]
        public User GetUserByPostId(int id)
        {
            return _postService.GetUserByPost(id);
        }


    }
}
