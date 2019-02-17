using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAPI.ClassModel
{
    public class Post
    {
        public string userId { get; set; }

        public string title { get; set; }

        public string body { get; set; }

        public DateTime created { get; set; }

    }
}
