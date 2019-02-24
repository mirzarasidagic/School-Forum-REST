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
        public int Id { get; set; }
        /// <summary>
        /// The user's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The user's lastname.
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// The user's username.
        /// </summary>
        public string Username { get; set; } 
        /// <summary>
        /// The users Email adress.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The users Website.
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// The users phone number
        /// </summary>
        public string Phone { get; set; }
        

    }
}
