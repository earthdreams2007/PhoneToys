<%@ Page Title="" Language="C#" MasterPageFile="~/Phonetoys2.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="PhoneToys.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="LabelA1" runat="server" Text="Användarnamn" AssociatedControlID="UnameTB" ForeColor="Black"></asp:Label>
    <asp:TextBox runat="server" ID="UnameTB"></asp:TextBox>
    <asp:Label ID="LabelA2" runat="server" Text="Lösenord" AssociatedControlID="PWTB" ForeColor="Black"></asp:Label>
    <asp:TextBox runat="server" ID="PWTB" TextMode="Password"></asp:TextBox>
    <asp:Button ID="LogInABTN" runat="server" Text="Logga in" Onclick="LogInABTN_Click"/>


</asp:Content>
