using System.Collections.Generic;
using SitecoreRocks.Models.NewsArtciles;

namespace SitecoreRocks.Models
{
    public class HomePage
    {
        public virtual string Title { get; set; }
        public virtual string MainBody { get; set; }

        //public virtual IEnumerable<MenuItem> Children { get; set; }


        public virtual IEnumerable<NewsArticle> News { get; set; }
    }
}