using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreRocks.Models
{
    [SitecoreType]
    public class NewsArticle
    {
        [SitecoreField]
        public virtual Guid id { get; set; }

        [SitecoreField]

        public virtual string Title { get; set; }

        [SitecoreField]
        public virtual string Abstract { get; set; }

        [SitecoreField]
        public virtual string MainBody { get; set; }

        [SitecoreField]
        public virtual Image FeaturedImage { get; set; }

        [SitecoreField]
        public virtual DateTime Date { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }

        //public virtual IEnumerable<NewsArtcile> News { get; set; }
    }
}