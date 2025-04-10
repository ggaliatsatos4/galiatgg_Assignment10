<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="galiatgg_Assignment10.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
    <asp:Panel runat="server" ID="container">

        <asp:HyperLink runat="server" ID="lnknasa">Go to NASA.gov</asp:HyperLink>
        <br />
        <br />

        <asp:Label runat="server" ID="lblabout">About Space Exploration</asp:Label>
        <br />
        <asp:Literal runat="server" ID="txtabout"></asp:Literal>


        <br />
    <asp:Label runat="server" ID="lblkeymission">Key Missions</asp:Label>
        <asp:BulletedList runat="server" ID="blkeymissions"></asp:BulletedList>



        <asp:Label runat="server" ID="lblSpaceAgencies">Notable Space Agencies</asp:Label>
        <asp:Table runat="server" ID="tblSpaceAgencies" BorderWidth="1" GridLines="Both"></asp:Table>

        <asp:Label runat="server" ID="lblquote">Famous Quote</asp:Label>
        <br />
        <asp:Literal runat="server" ID="txtquote"></asp:Literal>
        <br />
        <asp:Label runat="server" ID="lblgallery">Gallery</asp:Label>
        <br />
        <asp:Image runat="server" ID="img1" />
    </asp:Panel>
    </form>
</body>
</html>
