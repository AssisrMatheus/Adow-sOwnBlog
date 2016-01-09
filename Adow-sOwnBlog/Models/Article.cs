using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adow_sOwnBlog.Models
{
    public class Article
    {
        /// This archive was created by Matheus Assis Rios(aka Adow Tatep)
        /// at Adow-sOwnBlog Project
        /// This file contains article related info
        public int id { get; set; }
        public Author author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public string tags { get; set; }
        public string featuredImage { get; set; }
        public List<ArticleCategory> categories { get; set; }
    }
}