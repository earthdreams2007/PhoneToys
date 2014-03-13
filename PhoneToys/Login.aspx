<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/Phonetoys2.Master" Inherits="PhoneToys.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <%--    <asp:TextBox runat="server" ID="loginEmailTB"></asp:TextBox>
    <asp:TextBox runat="server" ID="loginPWTB"></asp:TextBox>
    <asp:Button runat="server" ID="loginBTN" CssClass="button radius large-10 medium-8 small-6" OnClick="loginBTN_Click" />
    <br />
    <asp:Button runat="server" ID="AdminBTN" CssClass="button tiny" Text="Are you an admin? Click here!" OnClick="AdminBTN_Click" ForeColor="Navy" BackColor="White"> </asp:Button> --%>
    
    <asp:Button runat="server" Text="Logga in som Medlem" ID="MemberBTN" CssClass="button large-3" OnClick="MemberBTN_Click"/>
    <br />
    <asp:Button runat="server" Text="Logga in som Admin eller Redaktör" CssClass="button large-3" ID="AdminBTN" Onclick="AdminBTN_Click1"/>
</asp:Content>
