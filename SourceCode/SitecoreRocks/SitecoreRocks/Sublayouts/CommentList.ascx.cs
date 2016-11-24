namespace SitecoreRocks.Sublayouts
{
    using System;

    public partial class CommentList : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {
            Sitecore.Data.Fields.Field myField = Sitecore.Context.Item.Fields["Author"];
            if (myField != null)
                lblContent.Text = myField.Value;
            // Put user code to initialize the page here
        }
    }
}