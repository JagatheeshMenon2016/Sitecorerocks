<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommentList.ascx.cs" Inherits="SitecoreRocks.Sublayouts.CommentList" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>

  <div class="formRow">
        <asp:Label ID="lblContent" Text="Comment" runat="server" />
    </div>


<asp:Repeater ID="rpComments" ItemType="Sitecore.Data.Items.Item" runat="server">
    <HeaderTemplate>
        <div class="indentedSection">
	        <h3>Comments</h3>
    </HeaderTemplate>
    <ItemTemplate>
		<p><strong>Martina Welander</strong></p>
		<p>I loved this holiday.</p>
		<p><a href="#">http://www.mywebsite.com/</a></p>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>

