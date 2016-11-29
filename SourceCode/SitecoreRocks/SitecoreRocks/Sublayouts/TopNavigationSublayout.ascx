<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopNavigationSublayout.ascx.cs" Inherits="SitecoreRocks.Sublayouts.TopNavigationSublayout" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>



<div class="navbar">
  <div class="navbar-inner">
    <a class="brand" href="<%=Model.Url %>"><%=Model.Title %></a>
    <ul class="nav">
        <% foreach (var item in Model.Children)
           {%>
                <li><a href="<%=item.Url %>"><%=item.Title %></a></li>
          <% } %>
    </ul>
  </div> 


   
