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


            
    
    }
}
