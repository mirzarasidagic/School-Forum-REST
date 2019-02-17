using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAPI.ClassModel
{
    /// <summary>
    /// Represents one specific user
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// The user's name.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The user's username.
        /// </summary>
        public string username { get; set; } 
        /// <summary>
        /// The users Email adress.
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// The users Website.
        /// </summary>
        public string website { get; set; }
        /// <summary>
        /// The users phone number
        /// </summary>
        public string phone { get; set; }

    }
}
