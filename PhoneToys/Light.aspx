<%@ Page Title="" Language="C#" MasterPageFile="~/Phonetoys2.Master" AutoEventWireup="true" CodeBehind="Light.aspx.cs" Inherits="PhoneToys.Light" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="LightOnBTN" runat="server" CssClass="button radius large-10 medium-8 small-6" Text="Turn on LED" OnClick="LightOnBTN_Click" />
    <br />
    <asp:Button ID="LightOffBTN" runat="server" CssClass="button radius large-10 medium-8 small-6" Text="Turn off LED" OnClick="LightOffBTN_Click" />
</asp:Content>
