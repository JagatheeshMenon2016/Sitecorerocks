namespace SitecoreRocks.Sublayouts
{
    using Glass.Mapper.Sc;
    using System;
    using SitecoreRocks.Models;

    public partial class TopNavigationSublayout : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {
            // Put user code to initialize the page here
            var context = new SitecoreContext();
            Model = context.GetHomeItem<MenuItem>();

        }
        public MenuItem Model { get; set; }
    }
}