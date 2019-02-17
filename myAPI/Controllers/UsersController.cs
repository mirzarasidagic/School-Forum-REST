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
    /// <summary>
    /// This is where I give you all the information about users.
    /// </summary>
    public class UsersController : ApiController
    {

        //List<User> users = new List<User>();
        IUserServices _userService = null;

        public UsersController()
        {
            _userService = new UserServices();
            //users.Add(new User { name = "Mirza Rasidagic", username = "Mirza", id = 1, email = "mirzarasidagic@gmail.com", website = "radiosarajevo.ba", phone = "387 61 123 456" });
            //users.Add(new User { name = "Leanne Graham", username = "Bret", id = 2, email = "Sincere@april.biz", website = "hildegard.org", phone = "653 5654 6848" });
            //users.Add(new User { name = "Ervin Howell", username = "Antonette", id = 3, email = "Shanna@melissa.tv", website = "anastasia.net", phone = "957 6945 4548" });

        }

        
        // GET: api/Users
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }

        // GET: api/Users/id
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }

        // POST: api/Users
        public void Post(User val)
        {
           // users.Add(val);
        }

    }
}
