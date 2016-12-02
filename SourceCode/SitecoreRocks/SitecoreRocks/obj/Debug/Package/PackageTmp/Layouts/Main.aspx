<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="SitecoreRocks.Layouts.Main" %>

<!DOCTYPE html>
<!--[if (gte IE 9)|!(IE)]><!--><html> <!--<![endif]-->
	<head>
		<meta charset="utf-8" />
		<title>Campaign Page</title>
		<meta name="description" content="Test" />
		<meta name="author" content="" />
		
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
		<link rel="stylesheet" href="../../Media Lib/css/campaigns.css" /> 
		
	</head>
	<body>
		<form id="Form1" runat="server" method="post">
			<div class="container">
               <sc:Placeholder Key="main" runat="server" /> 
			</div>
		</form>
	</body>
</html>