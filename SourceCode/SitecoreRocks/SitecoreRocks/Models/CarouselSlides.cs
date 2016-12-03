using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreRocks.Models
{
    public class CarouselSlide:CustomItem
    {

        public CarouselSlide(Item item):base(item) { }
        public string Title
        {
            get { return InnerItem["Title"]; }
        }
        public HtmlString Image
        {
            get { return new HtmlString(FieldRenderer.Render(InnerItem, "Image")); }

        }

  
        public string Url
        {
            get
            {
                Item linkitem = Sitecore.Context.Database.GetItem(InnerItem["LinkItem"]);
                if(linkitem!=null)
                   return LinkManager.GetItemUrl(linkitem);
                return "";
            }

        }
    }
}