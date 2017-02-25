<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Sumator.aspx.cs" Inherits="SimpleSumatorWebFroms.Sumator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>

            <input id="firstNum" type="number" runat="server" />
            <asp:RequiredFieldValidator ID="firstNumValidator" runat="server" ErrorMessage="This field is required" ControlToValidate="firstNum">
            </asp:RequiredFieldValidator>

            &nbsp;
            <div>
            </div>
        </div>
        <p>

            <input id="secondNum" type="number" runat="server" /><asp:RequiredFieldValidator ID="secondNumValidator" runat="server" ErrorMessage="This field is required" ControlToValidate="secondNum">
            </asp:RequiredFieldValidator>

        </p>
        <p>

            <input id="submitBtn" value="Calculate Sum" type="submit" runat="server" onserverclick="OnSubmitButtonClick" />
        </p>
        <p>
            <asp:Label runat="server" ID="sumResult"></asp:Label>
        </p>
</asp:Content>

