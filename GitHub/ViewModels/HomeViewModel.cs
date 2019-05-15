namespace GitHub.ViewModels
{
    using GitHub.Models;
    using System.Collections.Generic;

    public class HomeViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
    }
}