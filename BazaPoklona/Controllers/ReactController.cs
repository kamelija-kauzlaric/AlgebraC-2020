using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazaPoklona.Models;
using Microsoft.AspNetCore.Mvc;

// TO DO: Pokušaj se spojiti na bazu i prikazati context preko reacta
namespace BazaPoklona.Controllers
{
    public class ReactController : Controller
    {
        private static readonly IList<CommentModel> _comments;

        static ReactController()
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "Marko Markić",
                    Text = "Hello ReactJS.NET World!"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Stipe",
                    Text = "Prodajem rakiju"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                },
            };
        }

        [Route("comments")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Comments()
        {
            return Json(_comments);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
