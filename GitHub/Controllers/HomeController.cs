﻿namespace GitHub.Controllers
{
    using GitHub.Models;
    using GitHub.ViewModels;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(string query=null)
        {
            var upcomingGigs = _context.Gigs
                .Include("Artist")
                .Include("Genre")
                .Where(g => g.DateTime > DateTime.Now && !g.IsCanceled);
            if (!string.IsNullOrWhiteSpace(query))
            {
                upcomingGigs = upcomingGigs
                    .Where(g =>
                            g.Artist.Name.Contains(query) ||
                            g.Genre.Name.Contains(query) ||
                            g.Venue.Contains(query)
                            );
            }
            var viewModel = new GigsViewModel
            {
                UpcomingGigs = upcomingGigs,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Upcoming Gigs",
                SearchTerm= query
            };

            return View("Gigs", viewModel);
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
    }
}