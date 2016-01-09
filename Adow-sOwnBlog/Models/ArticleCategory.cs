using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adow_sOwnBlog.Models
{
    public class ArticleCategory
    {
        /// This archive was created by Matheus Assis Rios(aka Adow Tatep)
        /// at Adow-sOwnBlog Project
        /// This file contains category related info
        public int id { get; set; }
        public string name { get; set; }

        public ArticleCategory(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}