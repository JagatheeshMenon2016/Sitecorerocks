using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using SitecoreRocks.Models;

namespace SitecoreRocks.Models
{

    public class Home
    {
        public virtual Guid ID { get; set; }
        public virtual string Title { get; set; }

        public virtual string Text { get; set; }

        
        [SitecoreField("PublishedDate")]
        public virtual DateTime PublishedDate { get; set; }


        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; set; }

        [SitecoreField]
        public virtual IEnumerable<Home> Children { get; set; }



    }
    public class MenuItem
    {
        public virtual string Title { get; set; }

        public virtual string Url { get; set; }
        public virtual IEnumerable<MenuItem> Children { get; set; }

    }



}