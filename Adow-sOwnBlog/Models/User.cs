using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adow_sOwnBlog.Models
{    
    public class User
    {   /// This archive was created by Matheus Assis Rios(aka Adow Tatep)
        /// at Adow-sOwnBlog Project
        /// This file contains user related info
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(int id, string name, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }

    }
}