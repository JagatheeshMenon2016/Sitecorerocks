namespace SitecoreRocks.Sublayouts
{
    using Sitecore.Data.Items;
    using System;

    public partial class CommentForm : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {
            // Put user code to initialize the page here
        }
        //"{6B4D3346-F9B3-40DB-AA51-1566277F27DF}"
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Getting Master Database
            Sitecore.Data.Database masterDB = Sitecore.Configuration.Factory.GetDatabase("master");
            //Getting a Sitecore Item
            //Sitecore.Data.Items.Item home = masterDB.GetItem("/sitecore/content/Home");
            Sitecore.Data.Items.Item home = masterDB.GetItem("{6B4D3346-F9B3-40DB-AA51-1566277F27DF}");

            //Using Begin, End, Cancel Edit and Security Disabler
            BeginEditAndSecurityDisabler(home);
            //Using EditContext and Security User Switcher
            EditContextAndSecurityUserSwitcher(home);
        }
        private void BeginEditAndSecurityDisabler(Sitecore.Data.Items.Item home)
        {
            using (new Sitecore.SecurityModel.SecurityDisabler())
            {
                home.Editing.BeginEdit();
                try
                {
                    home["Title"] = "Title from Code";
                    //Commit the changes
                    home.Editing.EndEdit();
                }
                catch (Exception)
                {
                    //Revert the Changes
                    home.Editing.CancelEdit();
                }
            }
        }

        /// <summary>
        /// Using EditContext and Security User Switcher
        /// </summary>
        /// <param name="home"></param>
        private void EditContextAndSecurityUserSwitcher(Sitecore.Data.Items.Item home)
        {
            //User which is already created in Sitecore User Manager
            string testUser = @"sitecore\testuser";
            //User existing or not
            if (Sitecore.Security.Accounts.User.Exists(testUser))
            {
                //Getting Sitecore User Object with UserName
                Sitecore.Security.Accounts.User scUser = Sitecore.Security.Accounts.User.FromName(testUser, false);
                //Switching Context User
                using (new Sitecore.Security.Accounts.UserSwitcher(scUser))
                {
                    //Using EditContext to edit an Item
                    using (new Sitecore.Data.Items.EditContext(home))
                    {
                        home["Text"] = "Modified Text from Code";
                    }
                }
            }
        }

        protected void SampleTest_Click(object sender, EventArgs e)
        {
            Sitecore.Data.Database masterDB = Sitecore.Configuration.Factory.GetDatabase("master");

            Item parentItem = Sitecore.Context.Item;

            string name = "Comment_" + Sitecore.DateUtil.IsoNow;

            TemplateItem template = masterDB.GetTemplate("/sitecore/templates/User Defined/Comment");
            

            using (new Sitecore.SecurityModel.SecurityDisabler())
            {
                try
                {
                    Item newItem = parentItem.Add("Name", template);
                    if (newItem != null)
                    {
                        newItem.Editing.BeginEdit();
                        newItem["Author"] = txtAuthor.Text;
                        newItem["CommentText"] = txtContent.Text;
                        newItem.Editing.EndEdit();
                    }
                }
                catch
                {
                    Item newItem = Sitecore.Context.Item;
                    newItem.Editing.CancelEdit();
                }
            }

        }
    }
}