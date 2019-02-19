using myAPI.ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAPI.Services
{
    public interface IUserServices
    {
        List<User> GetAllUsers();

        User GetUserById(int id);


    }
}
