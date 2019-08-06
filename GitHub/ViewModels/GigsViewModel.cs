namespace GitHub.ViewModels
{
    using GitHub.Models;
    using System.Collections.Generic;

    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
        public string SearchTerm { get; set; }
    }
}