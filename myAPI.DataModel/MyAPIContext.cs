using myAPI.ClassModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAPI.DataModel
{
    public class MyAPIContext : DbContext
  
    {
       
        public DbSet<User> Users { get; set; }  

        public DbSet<Post> Posts { get; set; }





    }
}
