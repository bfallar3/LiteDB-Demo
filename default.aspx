<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LiteDB_Demo._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LiteDB Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LiteDB Demo</h1>
            <asp:LinkButton runat="server" Text="Another Page" PostBackUrl="~/AnotherPage.aspx"></asp:LinkButton>
            <br /><br />
            <asp:DataGrid runat="server" ID="grid1" EnableViewState="false"></asp:DataGrid>
        </div>
    </form>
</body>
</html>
