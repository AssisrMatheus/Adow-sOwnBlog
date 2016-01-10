using Adow_sOwnBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Adow_sOwnBlog.Controllers
{
    public class HomeController : Controller
    {
        //Create a simple test category for those articles
        private List<ArticleCategory> categories;

        private List<Article> articles;

        public HomeController()
        {
            //Create a simple test author
            Author test = new Author(1, "Test", "test@test.com", "testpass");
            
            //Create categories to add on those news
            categories = new List<ArticleCategory>();
            categories.Add(new ArticleCategory(1, "Mexico"));
            categories.Add(new ArticleCategory(2, "Prision"));

            //Create Articles
            articles = new List<Article>();
            articles.Add(new Article(1, test, "The Latest: 'El Chapo' Being Taken to Same Prison He Escaped", "The latest on Mexican drug lord Joaquin \"El Chapo\" Guzman who was recaptured six months after he escaped from a maximum security prison: (all times local)", "Mexican Attorney General Ariely Gomez says drug lord Joaquin \"El Chapo\" Guzman is being taken back to Antiplano — the same maximum-security prison where he escaped last July 11 using an elaborate tunnel that was dug to his shower stall.<br><br>Guzman was captured by Mexican marines early Friday in a coastal city, and the attorney general says the drug boss was tracked down partly because he was making a biographical movie.<br><br>The attorney general spoke at a ceremony Friday night at Mexico City's airport where Mexican marines displayed Guzman to journalists.<br>Guzman was put on a navy helicopter to be flown to the prison.", "prision, mexico", "", categories));
            articles.Add(new Article(2, test, "The Latest: 'El Chapo' Being Taken to Same Prison He Escaped", "The latest on Mexican drug lord Joaquin \"El Chapo\" Guzman who was recaptured six months after he escaped from a maximum security prison: (all times local)", "Mexican Attorney General Ariely Gomez says drug lord Joaquin \"El Chapo\" Guzman is being taken back to Antiplano — the same maximum-security prison where he escaped last July 11 using an elaborate tunnel that was dug to his shower stall.<br><br>Guzman was captured by Mexican marines early Friday in a coastal city, and the attorney general says the drug boss was tracked down partly because he was making a biographical movie.<br><br>The attorney general spoke at a ceremony Friday night at Mexico City's airport where Mexican marines displayed Guzman to journalists.<br>Guzman was put on a navy helicopter to be flown to the prison.", "prision, mexico", "", categories));
            articles.Add(new Article(3, test, "The Latest: 'El Chapo' Being Taken to Same Prison He Escaped", "The latest on Mexican drug lord Joaquin \"El Chapo\" Guzman who was recaptured six months after he escaped from a maximum security prison: (all times local)", "Mexican Attorney General Ariely Gomez says drug lord Joaquin \"El Chapo\" Guzman is being taken back to Antiplano — the same maximum-security prison where he escaped last July 11 using an elaborate tunnel that was dug to his shower stall.<br><br>Guzman was captured by Mexican marines early Friday in a coastal city, and the attorney general says the drug boss was tracked down partly because he was making a biographical movie.<br><br>The attorney general spoke at a ceremony Friday night at Mexico City's airport where Mexican marines displayed Guzman to journalists.<br>Guzman was put on a navy helicopter to be flown to the prison.", "prision, mexico", "", categories));
            articles.Add(new Article(4, test, "The Latest: 'El Chapo' Being Taken to Same Prison He Escaped", "The latest on Mexican drug lord Joaquin \"El Chapo\" Guzman who was recaptured six months after he escaped from a maximum security prison: (all times local)", "Mexican Attorney General Ariely Gomez says drug lord Joaquin \"El Chapo\" Guzman is being taken back to Antiplano — the same maximum-security prison where he escaped last July 11 using an elaborate tunnel that was dug to his shower stall.<br><br>Guzman was captured by Mexican marines early Friday in a coastal city, and the attorney general says the drug boss was tracked down partly because he was making a biographical movie.<br><br>The attorney general spoke at a ceremony Friday night at Mexico City's airport where Mexican marines displayed Guzman to journalists.<br>Guzman was put on a navy helicopter to be flown to the prison.", "prision, mexico", "", categories));
        }

        public ActionResult Index()
        {
            ViewData["Categories"] = categories;
            //Passes the news to the index view
            return View(articles);
        }

        public ActionResult About()
        {
            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult showArticle(int id, string title, ArticleCategory category)
        {
            return View(articles.FirstOrDefault(x => x.id == id));
        }

        public ActionResult showCategory(int id)
        {   
            List<Article> selecCategoryArticles = articles.Where(x => x.id == id).ToList();
            return View(selecCategoryArticles);
        }

    }
}