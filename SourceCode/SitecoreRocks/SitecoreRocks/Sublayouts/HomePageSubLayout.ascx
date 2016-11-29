<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HomePageSubLayout.ascx.cs" Inherits="SitecoreRocks.Sublayouts.HomePageSubLayout" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>




<%--<div class="navbar">
  <div class="navbar-inner">
    <a class="brand" href="<%=Model.Url %>"><%=Model.Title %></a>
    <ul class="nav">
        <% foreach (var item in Model.Children)
           {%>
                <li><a href="<%=item.Url %>"><%=item.Title %></a></li>
          <% } %>
    </ul>
  </div>
</div>--%>


<div class="hero-unit">
    <h1><%=HomeModel.Title %></h1>
    <%=HomeModel.MainBody %>
</div>

<div class="span6">
    <h3>Featured News</h3>
    <ul class="thumbnails">
        <% foreach (var news in HomeModel.News)
           { %>
        <li class="span3">
            <div class="thumbnail">
                <img src="<%=news.FeaturedImage.Src %>" alt="<%=news.FeaturedImage.Alt %>">
                <h4>
                    <a href="<%=news.Url %>">
                        <%=news.Title %>
                    </a>
                </h4>
                <p><%=news.Abstract %></p>
            </div>
        </li>

        <% } %>
    </ul>
</div>
