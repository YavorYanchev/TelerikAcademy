<%@ Page Language="C#" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <h1 id="welcome-text">Welcome to the web site</h1>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/bg/Home">BG</asp:HyperLink>

    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/en/Home">EN</asp:HyperLink>
</asp:Content>