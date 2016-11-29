﻿using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreRocks.Models
{
    [SitecoreType]
    public class Prod_Details
    {
        [SitecoreField]
        public virtual string Title { get; set; }

        [SitecoreField]
        public virtual string Description { get; set; }

        [SitecoreField]
        public virtual Image Image { get; set; }

        [SitecoreField]
        public virtual string Price { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }

        //public virtual IEnumerable<Prod_Details> ProductDetails { get; set; }

    }
}




