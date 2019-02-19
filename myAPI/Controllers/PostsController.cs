using myAPI.ClassModel;
using myAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace myAPI.Controllers
{
    public class PostsController : ApiController
    {
        IPostServices _postService = null;

        public PostsController()
        {
            _postService = new PostServices();
        }

        // GET ALL POSTS
        public List<Post> Get()
        {
            return _postService.GetAllPosts();
        }

        // GET ALL POSTS BY USER
        public List<Post> Get(int id)
        {
            return _postService.GetAllPostsByUser(id);
        }

    }

}