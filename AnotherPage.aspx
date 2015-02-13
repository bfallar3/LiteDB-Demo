<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnotherPage.aspx.cs" Inherits="LiteDB_Demo.AnotherPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h1>Another LiteDB Demo</h1>
                <asp:LinkButton runat="server" Text="Back" PostBackUrl="~/Default.aspx"></asp:LinkButton>
                <br /><br />
                <asp:DataGrid runat="server" ID="grid1" EnableViewState="false"></asp:DataGrid>
            </div>
        </div>
    </form>
</body>
</html>
