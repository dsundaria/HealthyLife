using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Web.Models
{
    public class Article
    {
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public DateTime ArticleDate { get; set; }

        public Article(string title,string content, DateTime date)
        {
            this.ArticleTitle = title;
            this.ArticleContent = content;
            this.ArticleDate = date;
        }
    }
}