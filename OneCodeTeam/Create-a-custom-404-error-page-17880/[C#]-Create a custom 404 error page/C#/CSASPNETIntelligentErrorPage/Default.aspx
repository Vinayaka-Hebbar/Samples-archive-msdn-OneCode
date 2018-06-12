﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSASPNETIntelligentErrorPage._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="lvwPageList" runat="server">
        <LayoutTemplate>
        Useful links:<br /><br />
        <ul>
        <asp:PlaceHolder runat="server" id="itemPlaceholder"></asp:PlaceHolder>
        </ul>
        </LayoutTemplate>
        <ItemTemplate>    
	    <li><a href='<%# Eval("Path") %>'><%# Eval("Name") %></a></li>     
        </ItemTemplate>
        <EmptyDataTemplate>
        ListView control failed to load data.
        </EmptyDataTemplate>
        </asp:ListView>
        Useless links:<br />
        <ul>
    <li><a href="Relative Pages/Asp.aspx">Asp</a></li>
    <li><a href="Relative Pages/Hi.aspx">Hi</a></li>
    </ul>
    </div>
    </form>
</body>
</html>