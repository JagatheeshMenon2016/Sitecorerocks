namespace SitecoreRocks.Sublayouts
{
    using Glass.Mapper.Sc;
    using Models;
    using System;

    public partial class HomePageSubLayout : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {
            var context = new SitecoreContext();
            HomeModel = context.GetHomeItem<HomePage>();
            
            // Put user code to initialize the page here
        }
        public HomePage HomeModel { get; set; }
    }
}