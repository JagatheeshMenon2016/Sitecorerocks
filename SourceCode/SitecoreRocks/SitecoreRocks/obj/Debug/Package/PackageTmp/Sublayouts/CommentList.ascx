<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommentList.ascx.cs" Inherits="SitecoreRocks.Sublayouts.CommentList" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>


<asp:Repeater ID="rpComments" ItemType="Sitecore.Data.Items.Item" runat="server">
    <HeaderTemplate>
        <div class="indentedSection">
	        <h3>Comments</h3>
    </HeaderTemplate>
    <ItemTemplate>

        <p><sc:Text Field="Author" runat="server" Item="<%# (Sitecore.Data.Items.Item)Container.DataItem %>" /></p>
		<p><sc:Text Field="CommentText" runat="server" Item="<%# (Sitecore.Data.Items.Item)Container.DataItem %>" /></p>
        <strong>
        <p>
            <%# Sitecore.DateUtil.FormatIsoDate(Item.Fields[Sitecore.FieldIDs.Created].Value, "dd-MMM-yyyy hh:mm") %></p>
            </strong>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>