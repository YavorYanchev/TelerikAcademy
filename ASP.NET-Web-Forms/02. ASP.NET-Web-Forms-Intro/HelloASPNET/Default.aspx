<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloASPNET._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p>Hello, ASP.NET</p>
        <asp:Label ID="hello" runat="server"></asp:Label>
        <br />
        <asp:Label ID="location" runat="server"></asp:Label>
    </div>


</asp:Content>
