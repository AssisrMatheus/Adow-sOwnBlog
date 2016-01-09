using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adow_sOwnBlog.Models
{
    public class Author : User
    {
        /// This archive was created by Matheus Assis Rios(aka Adow Tatep)
        /// at Adow-sOwnBlog Project
        /// This file contains author:user related info
        public string description { get; set; }
        public string website { get; set; }

        public Author(int id, string name, string email, string password) : base(id,name,email,password)
        {
            this.description = "";
            this.website = "";
        }

        public Author(int id, string name, string email, string password, string description, string website)
            : base(id, name, email, password)
        {
            this.description = description;
            this.website = website;
        }
    }
}