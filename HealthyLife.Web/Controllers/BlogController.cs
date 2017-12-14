using HealthyLife.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web;

namespace HealthyLife.Web.Controllers
{
    public class BlogController : SurfaceController
    {
        // GET: Blog
        public ActionResult GetLatestBlogs()
        {

            var articles = new List<Article>();
            var allArticles = CurrentPage.Children;
            //allArticles = allArticles.Where(x => x.GetPropertyValue<DateTime>("articleDate").Month == 11);
            foreach (var article in allArticles)
            {

                articles.Add(new Article(
                    article.GetPropertyValue<string>("articleTitle"),
                    article.GetPropertyValue<string>("articleContent"),
                    article.GetPropertyValue<DateTime>("articleDate")));
            }
            
            return PartialView("/Views/Partials/BlogContent.cshtml", articles);
        }

        public ActionResult GetBlogArchives()
        {
            var allArticles = CurrentPage.Children;
            return PartialView("/Views/Partials/BlogArchives.cshtml", allArticles);
        }
    }
}