using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using SitecoreRocks.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SitecoreRocks.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Carousel()
        {
            List<CarouselSlide> slides = new List<CarouselSlide>();
            MultilistField multilistField = Sitecore.Context.Item.Fields["Carousel Slider"];
            if(multilistField!=null)
            {
                Item[] carouselItems = multilistField.GetItems();
               foreach (Item item in carouselItems)
                {
                    slides.Add(new CarouselSlide(item));
                }
            }
            return PartialView(slides);
        }
    }
}