using myAPI.ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAPI.Services
{
    public interface IPostServices
    {
        List<Post> GetAllPosts();

        User GetUserByPost(int id);

        List<Post> GetAllPostsByUser(int id);


    }
}
