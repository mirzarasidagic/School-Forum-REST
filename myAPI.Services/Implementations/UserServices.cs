using myAPI.ClassModel;
using myAPI.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAPI.Services
{
    public class UserServices : IUserServices
    {
        public List<User> GetAllUsers()
        {
            List<User> listOfUsers = null;
            using (var context = new MyAPIContext()) {

                listOfUsers = context.Users.ToList();
            }

            return listOfUsers;
        } 

        public User GetUserById(int id)
        {
            User userByID = null;
            using (var context = new MyAPIContext())
            {
                userByID = context.Users.Single(s => s.Id == id);
            }

            return userByID;
           
        }
    }
}
