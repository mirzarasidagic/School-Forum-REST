using myAPI.ClassModel;
using myAPI.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAPI.Services
{
    public class PostServices : IPostServices  
    {
        public List<Post> GetAllPosts()
        {
            List<Post> listOfPosts = null;

            using (var context = new MyAPIContext())
            {
                listOfPosts = context.Posts.ToList();
            }

            return listOfPosts;

        }

        public List<Post> GetAllPostsByUser(int id)
        {
            List<Post> listOfPostsByUserId = null;

            using (var context = new MyAPIContext())
            {
                listOfPostsByUserId = context.Posts.Where(s => s.UserId == id).ToList();
            }

            return listOfPostsByUserId;
        }

        

        public User GetUserByPost(int id)
        {
            User listOfUsers = null;

            using (var context = new MyAPIContext())
            {
                listOfUsers = context.Users.Single(s => s.Id == id);
            }

            return listOfUsers;
        }
    }
}
