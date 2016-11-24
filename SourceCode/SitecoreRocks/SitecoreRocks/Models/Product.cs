using Sitecore.Data.Items;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreRocks.Models
{
    public class Product :Sitecore.Mvc.Presentation.RenderingModel
    {
        public HtmlString Title { get { return new HtmlString(FieldRenderer.Render(Item, "title")); } }
        public HtmlString Description { get { return new HtmlString(FieldRenderer.Render(Item, "description")); } }
        public HtmlString Image { get { return new HtmlString(FieldRenderer.Render(Item, "Image")); } }
        public HtmlString Price { get { return new HtmlString(FieldRenderer.Render(Item, "price")); } }

    }
}