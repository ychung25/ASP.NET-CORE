using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExploreCalifornia.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreCalifornia.Controllers
{
    public class BlogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Post[] posts = {
                new Post
                {
                    Title = "My blog post",
                    Posted = DateTime.Now,
                    Author = "Yongik Chung",
                    Body = "This is a great blog post, don't you think?"
                },
                new Post
                {
                    Title = "My other blog post",
                    Posted = DateTime.Now,
                    Author = "Yongik Chung",
                    Body = "I don't know about this"
                }
            };
            return View(posts);
        }

        [Route("blog/{year:int}/{month:int}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            Post post = new Post()
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Yongik Chung",
                Body = "This is a great blog post, don't you think?",
                Stuff = new string[]{"one", "two", "three"}
            };
            
            return View(post);
        }
    }
}
