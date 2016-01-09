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

        public Article(int id, Author author, string title, string description, string content, string tags, string featuredImage, List<ArticleCategory> categories)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.description = description;
            this.content = content;
            this.tags = tags;
            this.featuredImage = featuredImage;
            this.categories = categories;
        }
    }
}