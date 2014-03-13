<%@ Page Title="" Language="C#" MasterPageFile="~/Phonetoys2.Master" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="PhoneToys.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label runat="server" Text="Användarnamn" AssociatedControlID="UnameTB" ForeColor="Black"></asp:Label>
    <asp:TextBox runat="server" ID="UnameTB"></asp:TextBox>
    <asp:Label runat="server" Text="Lösenord" AssociatedControlID="PWTB" ForeColor="Black"></asp:Label>
    <asp:TextBox runat="server" ID="PWTB" TextMode="Password"></asp:TextBox>
    <asp:Button ID="LogInBTN" runat="server" Text="Logga in" Onclick="LogInBTN_Click"/>
</asp:Content>
