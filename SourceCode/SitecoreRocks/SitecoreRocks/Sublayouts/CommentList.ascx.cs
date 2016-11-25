namespace SitecoreRocks.Sublayouts
{
    using Sitecore.Data.Items;
    using Sitecore.Web.UI.WebControls;
    using System;
    using System.Web.UI.WebControls;

    public partial class CommentList : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                this.BindRepeater();
            }          

        }

        private void BindRepeater()
        {
            
            rpComments.DataSource = Sitecore.Context.Item.GetChildren();
            rpComments.DataBind();
        }


  
    }

}